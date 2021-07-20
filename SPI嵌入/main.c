/*******************************************************************************
*File: Main.c
*功能: LED数码管显示0-F字符,同时控制4个LED显示对应的十六进制
*******************************************************************************/
#include  "config.h"
#define   HC595_CS    0x00000100            /*P0.8口为74HC595的片选*/
uint8 rcv_data;
/*******************************************************************************
*名称: DelayNS()
*功能: 长软件延时
*******************************************************************************/
void DelayNS(uint32 dly)
{  uint32  i;
   for (;dly>0;dly--)
      for(i=0;i<50000;i++);
}
/*******************************************************************************
*名称: MSpiIni()
*功能: 初始化SPI接口,设置为主机
*******************************************************************************/
void MSpiIni(void)
{ S0PCCR=0x52;           //设置SPI时钟分频
  S0PCR=0x30;            //设置SPI接口模式,MSTR=1,CPOL=1,CPHA=0,LSBF=0
}
/*******************************************************************************
*名称: MSendData()
*功能: 向SPI总线发送数据
*******************************************************************************/
uint8 MSendData(uint8 data)
{ IO0CLR=HC595_CS;                             //片选
  S0PDR=data;
  while(0==(S0PSR&0x80));                  //等待SPIF置位,即等待数据发送完毕
  IO0SET=HC595_CS;
  return(S0PDR);
}
/*此表为0~F的字模*/
  uint8 const DISP_TAB[16]={0xC0,0xF9,0xA4,0xB0,0x99,0x92,0x82,0xF8,0x80,0x90,
                            0x88,0x83,0xC6,0xA1,0x86,0x8E};
/*******************************************************************************
*名称: main()
*功能: 使用硬件SPI接口输出0~F的数据,控制LED显示
*******************************************************************************/

int main(void)
{ 
  uint8 i;  
  
  PINSEL0=0x00005500;                 //设置SPI引脚连接
  PINSEL1=0x00000000;
  
  IO0DIR=HC595_CS; 
  MSpiIni();                         //初始化SPI接口
  while(1)
  { for (i=0;i<16;i++) 
    {rcv_data=MSendData(DISP_TAB[i]);   //发送显示数据
      DelayNS(50);                     //延时
    }
  }
  
}
