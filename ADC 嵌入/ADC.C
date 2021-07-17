#include "config.h"
#define  HC595_CS       (1<<29)      /* P0.29口为74HC595的片选 */
#define  UART_BPS	9600		     /* 定义通讯波特率 */
/****************************************************************************
* 名称：Delayms()
* 功能：长软件延时
* 入口参数：dly		延时参数，值越大，延时越久
* 出口参数：无
****************************************************************************/
void  Delayms(uint32  dly)
{
   uint32  i;
   for(; dly>0; dly--)
   for(i=0; i<50000; i++);
}
#define S0SPCR           (*((volatile unsigned char *) 0xE0020000))      /* no in lpc210x*/
#define S0SPSR           (*((volatile unsigned char *) 0xE0020004))      /* no in lpc210x*/
#define S0SPDR           (*((volatile unsigned char *) 0xE0020008))      /* no in lpc210x*/
#define S0SPCCR          (*((volatile unsigned char *) 0xE002000C))      /* no in lpc210x*/
/****************************************************************************
* 名称：UART0_Init()
* 功能：初始化串口0。设置为8位数据位，1位停止位，无奇偶校验，波特率为115200
* 入口参数：无
* 出口参数：无
****************************************************************************/
void  UART0_Init(void)
{
   uint16  Fdiv;

   U0LCR = 0x83;		             // DLAB = 1，可设置波特率
   Fdiv = (Fpclk / 16) / UART_BPS;           // 设置波特率
   U0DLM = Fdiv / 256;							
   U0DLL = Fdiv % 256;						
   U0LCR = 0x03;
}
				

/****************************************************************************
* 名称：UART0_SendByte()
* 功能：向串口发送字节数据，并等待发送完毕。
* 入口参数：data		要发送的数据
* 出口参数：无
****************************************************************************/
void  UART0_SendByte(uint8 data)
{

  U0THR = data;				     // 发送数据
  while( (U0LSR&0x40)==0 );	             // 等待数据发送完毕
}

/****************************************************************************
* 名称：ISendStr()
* 功能：向PC机发送字串，以便显示。
* 入口参数：str      要发送的字符串，字串以'\0'结束
* 出口参数：无
****************************************************************************/
void  ISendStr(char *str)
{  while(1)
   {  if(*str=='\0') break;                  // 若为'\0'，则退出
      UART0_SendByte(*str++);                // 发送显示数据
   }
}
#if 1
/****************************************************************************
* 名称：MSpiIni()
* 功能：初始化SPI接口，设置为主机。
* 入口参数：无
* 出口参数：无
****************************************************************************/
void  MSpiIni(void)
{
   S0SPCCR = 0x52;			     // 设置SPI时钟分频
   S0SPCR = 0x20;		             // 设置SPI接口模式，MSTR=1，CPOL=1，CPHA=0，LSBF=0
}


/****************************************************************************
* 名称：MSendData()
* 功能：向SPI总线发送数据。
* 入口参数：data        待发送的数据
* 出口参数：返回值为读取的数据
****************************************************************************/
uint8  MSendData(uint8 data)
{
   uint8 temp = S0SPDR;

   IO0CLR = HC595_CS;			        // 片选

   S0SPDR = data;
   while( 0==(S0SPSR&0x80) );		        // 等待SPIF置位，即等待数据发送完毕

   IO0SET = HC595_CS;
   return(S0SPDR);
}
#endif

/* 此表为0--F的字模 */
uint8 const DISP_TAB[16] = { 0xC0,0xF9,0xA4,0xB0,0x99,0x92,0x82,0xF8,0x80,0x90,
                             0x88,0x83,0xC6,0xA1,0x86,0x8E
	                   };	

/****************************************************************************
* 名称：main()
* 功能：进行通道1电压ADC转换，并把结果转换成电压值，然后发送到串口,并用LED进行显示。
* 说明：在CONFIG.H文件中包含stdio.h。
****************************************************************************/
 int main(void)
{
   uint32  ADC_Data;
   char    str[20];
   PINSEL0 = 0x00001505;            			 // 设置P0.0、P0.1连接到UART0的TXD、RXD
   PINSEL1 = 0x01000000;		        	 // 设置P0.28连接到AIN1
   IO0DIR = HC595_CS;				         // 设置HC595_CS控制口为输出
   UART0_Init();					 // 初始化UART0
   MSpiIni();                                            // 初始化SPI接口

   /* 进行ADC模块设置，其中x<<n表示第n位设置为x(若x超过一位，则向高位顺延) */
   ADCR = (1 << 1)                    |		 // SEL = 1 ，选择通道0
          ((Fpclk / 1000000 - 1) << 8) | 		 // CLKDIV = Fpclk / 1000000 - 1 ，即转换时钟为1MHz
          (0 << 16)                    |		 // BURST = 0 ，软件控制转换操作
          (0 << 17)                    | 		 // CLKS = 0 ，使用11clock转换
          (1 << 21)                    | 		 // PDN = 1 ， 正常工作模式(非掉电转换模式)
          (0 << 22)                    | 		 // TEST1:0 = 00 ，正常工作模式(非测试模式)
          (1 << 24)                    | 		 // START = 1 ，直接启动ADC转换
          (0 << 27);				         // EDGE = 0 (CAP/MAT引脚下降沿触发ADC转换)
   Delayms(10);								
   ADC_Data = ADDR;					 // 读取ADC结果，并清除DONE标志位

   while(1)
   {
      ADCR = (ADCR&0xFFFFFF00)|0x02|(1 << 24);	 // 切换通道并进行第一次转换
      while( (ADDR&0x80000000)==0 );			 // 等待转换结束
      ADCR = ADCR | (1 << 24);			 // 再次启运转换
      while( (ADDR&0x80000000)==0 );
      ADC_Data = ADDR;					 // 读取ADC结果
      ADC_Data = (ADC_Data>>6) & 0x3FF;
      ADC_Data = ADC_Data * 3300;
      ADC_Data = ADC_Data / 1024;
      sprintf(str, "VIN1=%4dmV \r\n", ADC_Data);
      ISendStr(str);                                     // 从串口中输出结果
      MSendData(~DISP_TAB[ADC_Data % 10]);	         //  发送显示数据个位
      MSendData(~DISP_TAB[ADC_Data % 100 / 10]);	         //  发送显示数据十位
      MSendData(~DISP_TAB[ADC_Data % 1000 / 100]);	 //  发送显示数据百位
      MSendData(~DISP_TAB[ADC_Data / 1000 % 10]);	 //  发送显示数据千位
      Delayms(200);

	  }


}

				