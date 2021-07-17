#line 1 "ADC.C"
#line 1 "config.h"













typedef unsigned char  uint8;                    
typedef signed   char  int8;                     
typedef unsigned short uint16;                   
typedef signed   short int16;                    
typedef unsigned int   uint32;                   
typedef signed   int   int32;                    
typedef float          fp32;                     
typedef double         fp64;                     


 
 
 



 

 
 





 
 





 
 


 
 





 
 



 
 


 
 



 
 
#line 116 "config.h"

 
 




 
 

























 
 
#line 162 "config.h"

 
 
#line 177 "config.h"

 
 
#line 187 "config.h"

 
 
         


















 
 
#line 234 "config.h"

#line 258 "config.h"

#line 282 "config.h"

#line 306 "config.h"

#line 330 "config.h"

#line 354 "config.h"





#line 367 "config.h"


 
 
#line 387 "config.h"

 
 
#line 406 "config.h"

 
 
#line 424 "config.h"

 
 



 
 
#line 458 "config.h"

 
 





 
 
#line 475 "config.h"



 


 
 	
 





#line 1 "target.h"




extern void Reset(void);
extern void TargetInit(void);
extern void TargetResetInit(void);

#line 490 "config.h"

#line 1 "C:\\Keil_v5\\ARM\\ARMCC\\Bin\\..\\include\\stdio.h"
 
 
 





 






 







 




  
 








#line 47 "C:\\Keil_v5\\ARM\\ARMCC\\Bin\\..\\include\\stdio.h"


  



    typedef unsigned int size_t;    









 
 

 



    typedef struct __va_list __va_list;






   




 




typedef struct __fpos_t_struct {
    unsigned __int64 __pos;
    



 
    struct {
        unsigned int __state1, __state2;
    } __mbstate;
} fpos_t;
   


 


   

 

typedef struct __FILE FILE;
   






 

#line 136 "C:\\Keil_v5\\ARM\\ARMCC\\Bin\\..\\include\\stdio.h"


extern FILE __stdin, __stdout, __stderr;
extern FILE *__aeabi_stdin, *__aeabi_stdout, *__aeabi_stderr;

#line 166 "C:\\Keil_v5\\ARM\\ARMCC\\Bin\\..\\include\\stdio.h"
    

    

    





     



   


 


   


 

   



 

   


 




   


 





    


 






extern __declspec(__nothrow) int remove(const char *  ) __attribute__((__nonnull__(1)));
   





 
extern __declspec(__nothrow) int rename(const char *  , const char *  ) __attribute__((__nonnull__(1,2)));
   








 
extern __declspec(__nothrow) FILE *tmpfile(void);
   




 
extern __declspec(__nothrow) char *tmpnam(char *  );
   











 

extern __declspec(__nothrow) int fclose(FILE *  ) __attribute__((__nonnull__(1)));
   







 
extern __declspec(__nothrow) int fflush(FILE *  );
   







 
extern __declspec(__nothrow) FILE *fopen(const char * __restrict  ,
                           const char * __restrict  ) __attribute__((__nonnull__(1,2)));
   








































 
extern __declspec(__nothrow) FILE *freopen(const char * __restrict  ,
                    const char * __restrict  ,
                    FILE * __restrict  ) __attribute__((__nonnull__(2,3)));
   








 
extern __declspec(__nothrow) void setbuf(FILE * __restrict  ,
                    char * __restrict  ) __attribute__((__nonnull__(1)));
   




 
extern __declspec(__nothrow) int setvbuf(FILE * __restrict  ,
                   char * __restrict  ,
                   int  , size_t  ) __attribute__((__nonnull__(1)));
   















 
#pragma __printf_args
extern __declspec(__nothrow) int fprintf(FILE * __restrict  ,
                    const char * __restrict  , ...) __attribute__((__nonnull__(1,2)));
   


















 
#pragma __printf_args
extern __declspec(__nothrow) int _fprintf(FILE * __restrict  ,
                     const char * __restrict  , ...) __attribute__((__nonnull__(1,2)));
   



 
#pragma __printf_args
extern __declspec(__nothrow) int printf(const char * __restrict  , ...) __attribute__((__nonnull__(1)));
   




 
#pragma __printf_args
extern __declspec(__nothrow) int _printf(const char * __restrict  , ...) __attribute__((__nonnull__(1)));
   



 
#pragma __printf_args
extern __declspec(__nothrow) int sprintf(char * __restrict  , const char * __restrict  , ...) __attribute__((__nonnull__(1,2)));
   






 
#pragma __printf_args
extern __declspec(__nothrow) int _sprintf(char * __restrict  , const char * __restrict  , ...) __attribute__((__nonnull__(1,2)));
   



 

#pragma __printf_args
extern __declspec(__nothrow) int snprintf(char * __restrict  , size_t  ,
                     const char * __restrict  , ...) __attribute__((__nonnull__(3)));
   















 

#pragma __printf_args
extern __declspec(__nothrow) int _snprintf(char * __restrict  , size_t  ,
                      const char * __restrict  , ...) __attribute__((__nonnull__(3)));
   



 
#pragma __scanf_args
extern __declspec(__nothrow) int fscanf(FILE * __restrict  ,
                    const char * __restrict  , ...) __attribute__((__nonnull__(1,2)));
   






























 
#pragma __scanf_args
extern __declspec(__nothrow) int _fscanf(FILE * __restrict  ,
                     const char * __restrict  , ...) __attribute__((__nonnull__(1,2)));
   



 
#pragma __scanf_args
extern __declspec(__nothrow) int scanf(const char * __restrict  , ...) __attribute__((__nonnull__(1)));
   






 
#pragma __scanf_args
extern __declspec(__nothrow) int _scanf(const char * __restrict  , ...) __attribute__((__nonnull__(1)));
   



 
#pragma __scanf_args
extern __declspec(__nothrow) int sscanf(const char * __restrict  ,
                    const char * __restrict  , ...) __attribute__((__nonnull__(1,2)));
   








 
#pragma __scanf_args
extern __declspec(__nothrow) int _sscanf(const char * __restrict  ,
                     const char * __restrict  , ...) __attribute__((__nonnull__(1,2)));
   



 

 
extern __declspec(__nothrow) int vfscanf(FILE * __restrict  , const char * __restrict  , __va_list) __attribute__((__nonnull__(1,2)));
extern __declspec(__nothrow) int vscanf(const char * __restrict  , __va_list) __attribute__((__nonnull__(1)));
extern __declspec(__nothrow) int vsscanf(const char * __restrict  , const char * __restrict  , __va_list) __attribute__((__nonnull__(1,2)));

extern __declspec(__nothrow) int _vfscanf(FILE * __restrict  , const char * __restrict  , __va_list) __attribute__((__nonnull__(1,2)));
extern __declspec(__nothrow) int _vscanf(const char * __restrict  , __va_list) __attribute__((__nonnull__(1)));
extern __declspec(__nothrow) int _vsscanf(const char * __restrict  , const char * __restrict  , __va_list) __attribute__((__nonnull__(1,2)));

extern __declspec(__nothrow) int vprintf(const char * __restrict  , __va_list  ) __attribute__((__nonnull__(1)));
   





 
extern __declspec(__nothrow) int _vprintf(const char * __restrict  , __va_list  ) __attribute__((__nonnull__(1)));
   



 
extern __declspec(__nothrow) int vfprintf(FILE * __restrict  ,
                    const char * __restrict  , __va_list  ) __attribute__((__nonnull__(1,2)));
   






 
extern __declspec(__nothrow) int vsprintf(char * __restrict  ,
                     const char * __restrict  , __va_list  ) __attribute__((__nonnull__(1,2)));
   






 

extern __declspec(__nothrow) int vsnprintf(char * __restrict  , size_t  ,
                     const char * __restrict  , __va_list  ) __attribute__((__nonnull__(3)));
   







 

extern __declspec(__nothrow) int _vsprintf(char * __restrict  ,
                      const char * __restrict  , __va_list  ) __attribute__((__nonnull__(1,2)));
   



 
extern __declspec(__nothrow) int _vfprintf(FILE * __restrict  ,
                     const char * __restrict  , __va_list  ) __attribute__((__nonnull__(1,2)));
   



 
extern __declspec(__nothrow) int _vsnprintf(char * __restrict  , size_t  ,
                      const char * __restrict  , __va_list  ) __attribute__((__nonnull__(3)));
   



 
extern __declspec(__nothrow) int fgetc(FILE *  ) __attribute__((__nonnull__(1)));
   







 
extern __declspec(__nothrow) char *fgets(char * __restrict  , int  ,
                    FILE * __restrict  ) __attribute__((__nonnull__(1,3)));
   










 
extern __declspec(__nothrow) int fputc(int  , FILE *  ) __attribute__((__nonnull__(2)));
   







 
extern __declspec(__nothrow) int fputs(const char * __restrict  , FILE * __restrict  ) __attribute__((__nonnull__(1,2)));
   




 
extern __declspec(__nothrow) int getc(FILE *  ) __attribute__((__nonnull__(1)));
   







 




    extern __declspec(__nothrow) int (getchar)(void);

   





 
extern __declspec(__nothrow) char *gets(char *  ) __attribute__((__nonnull__(1)));
   









 
extern __declspec(__nothrow) int putc(int  , FILE *  ) __attribute__((__nonnull__(2)));
   





 




    extern __declspec(__nothrow) int (putchar)(int  );

   



 
extern __declspec(__nothrow) int puts(const char *  ) __attribute__((__nonnull__(1)));
   





 
extern __declspec(__nothrow) int ungetc(int  , FILE *  ) __attribute__((__nonnull__(2)));
   






















 

extern __declspec(__nothrow) size_t fread(void * __restrict  ,
                    size_t  , size_t  , FILE * __restrict  ) __attribute__((__nonnull__(1,4)));
   











 

extern __declspec(__nothrow) size_t __fread_bytes_avail(void * __restrict  ,
                    size_t  , FILE * __restrict  ) __attribute__((__nonnull__(1,3)));
   











 

extern __declspec(__nothrow) size_t fwrite(const void * __restrict  ,
                    size_t  , size_t  , FILE * __restrict  ) __attribute__((__nonnull__(1,4)));
   







 

extern __declspec(__nothrow) int fgetpos(FILE * __restrict  , fpos_t * __restrict  ) __attribute__((__nonnull__(1,2)));
   








 
extern __declspec(__nothrow) int fseek(FILE *  , long int  , int  ) __attribute__((__nonnull__(1)));
   














 
extern __declspec(__nothrow) int fsetpos(FILE * __restrict  , const fpos_t * __restrict  ) __attribute__((__nonnull__(1,2)));
   










 
extern __declspec(__nothrow) long int ftell(FILE *  ) __attribute__((__nonnull__(1)));
   











 
extern __declspec(__nothrow) void rewind(FILE *  ) __attribute__((__nonnull__(1)));
   





 

extern __declspec(__nothrow) void clearerr(FILE *  ) __attribute__((__nonnull__(1)));
   




 

extern __declspec(__nothrow) int feof(FILE *  ) __attribute__((__nonnull__(1)));
   


 
extern __declspec(__nothrow) int ferror(FILE *  ) __attribute__((__nonnull__(1)));
   


 
extern __declspec(__nothrow) void perror(const char *  );
   









 

extern __declspec(__nothrow) int _fisatty(FILE *   ) __attribute__((__nonnull__(1)));
    
 

extern __declspec(__nothrow) void __use_no_semihosting_swi(void);
extern __declspec(__nothrow) void __use_no_semihosting(void);
    





 











#line 985 "C:\\Keil_v5\\ARM\\ARMCC\\Bin\\..\\include\\stdio.h"



 

#line 492 "config.h"

#line 2 "ADC.C"







 
void  Delayms(uint32  dly)
{
   uint32  i;
   for(; dly>0; dly--)
   for(i=0; i<50000; i++);
}









 
void  UART0_Init(void)
{
   uint16  Fdiv;

   (*((volatile unsigned char *) 0xE000C00C)) = 0x83;		             
   Fdiv = (((20000000 * 3) / 4) * 2 / 16) / 9600;           
   (*((volatile unsigned char *) 0xE000C004)) = Fdiv / 256;							
   (*((volatile unsigned char *) 0xE000C000)) = Fdiv % 256;						
   (*((volatile unsigned char *) 0xE000C00C)) = 0x03;
}
				






 
void  UART0_SendByte(uint8 data)
{

  (*((volatile unsigned char *) 0xE000C000)) = data;				     
  while( ((*((volatile unsigned char *) 0xE000C014))&0x40)==0 );	             
}






 
void  ISendStr(char *str)
{  while(1)
   {  if(*str=='\0') break;                  
      UART0_SendByte(*str++);                
   }
}






 
void  MSpiIni(void)
{
   (*((volatile unsigned char *) 0xE002000C)) = 0x52;			     
   (*((volatile unsigned char *) 0xE0020000)) = 0x20;		             
}







 
uint8  MSendData(uint8 data)
{
   uint8 temp = (*((volatile unsigned char *) 0xE0020008));

   (*((volatile unsigned long *) 0xE002800C)) = (1<<29);			        

   (*((volatile unsigned char *) 0xE0020008)) = data;
   while( 0==((*((volatile unsigned char *) 0xE0020004))&0x80) );		        

   (*((volatile unsigned long *) 0xE0028004)) = (1<<29);
   return((*((volatile unsigned char *) 0xE0020008)));
}


 
uint8 const DISP_TAB[16] = { 0xC0,0xF9,0xA4,0xB0,0x99,0x92,0x82,0xF8,0x80,0x90,
                             0x88,0x83,0xC6,0xA1,0x86,0x8E
	                   };	





 
 int main(void)
{
   uint32  ADC_Data;
   char    str[20];
   (*((volatile unsigned long *) 0xE002C000)) = 0x00001505;            			 
   (*((volatile unsigned long *) 0xE002C004)) = 0x01000000;		        	 
   (*((volatile unsigned long *) 0xE0028008)) = (1<<29);				         
   UART0_Init();					 
   MSpiIni();                                            

    
   (*((volatile unsigned long *) 0xE0034000)) = (1 << 1)                    |		 
          ((((20000000 * 3) / 4) * 2 / 1000000 - 1) << 8) | 		 
          (0 << 16)                    |		 
          (0 << 17)                    | 		 
          (1 << 21)                    | 		 
          (0 << 22)                    | 		 
          (1 << 24)                    | 		 
          (0 << 27);				         
   Delayms(10);								
   ADC_Data = (*((volatile unsigned long *) 0xE0034004));					 

   while(1)
   {
      (*((volatile unsigned long *) 0xE0034000)) = ((*((volatile unsigned long *) 0xE0034000))&0xFFFFFF00)|0x02|(1 << 24);	 
      while( ((*((volatile unsigned long *) 0xE0034004))&0x80000000)==0 );			 
      (*((volatile unsigned long *) 0xE0034000)) = (*((volatile unsigned long *) 0xE0034000)) | (1 << 24);			 
      while( ((*((volatile unsigned long *) 0xE0034004))&0x80000000)==0 );
      ADC_Data = (*((volatile unsigned long *) 0xE0034004));					 
      ADC_Data = (ADC_Data>>6) & 0x3FF;
      ADC_Data = ADC_Data * 3300;
      ADC_Data = ADC_Data / 1024;
      sprintf(str, "VIN1=%4dmV \r\n", ADC_Data);
      ISendStr(str);                                     
      MSendData(~DISP_TAB[ADC_Data % 10]);	         
      MSendData(~DISP_TAB[ADC_Data % 100 / 10]);	         
      MSendData(~DISP_TAB[ADC_Data % 1000 / 100]);	 
      MSendData(~DISP_TAB[ADC_Data / 1000 % 10]);	 
      Delayms(200);

	  }


}

				
