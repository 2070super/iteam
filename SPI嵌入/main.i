#line 1 "main.c"
#line 1 "config.h"


 










typedef unsigned char  uint8;                    
typedef signed   char  int8;                     
typedef unsigned short uint16;                   
typedef signed   short int16;                    
typedef unsigned int   uint32;                   
typedef signed   int   int32;                    
typedef float          fp32;                     
typedef double         fp64;                     


 
 
 

#line 1 "LPC2138.h"


 

 
 





 
 





 
 


 
 





 
 



 
 


 
 



 
 
#line 89 "LPC2138.h"

 
 




 
 

























 
 
#line 135 "LPC2138.h"

 
 
#line 150 "LPC2138.h"

 
 
#line 160 "LPC2138.h"

 
 
         


















 
 
#line 207 "LPC2138.h"

#line 231 "LPC2138.h"

#line 255 "LPC2138.h"

#line 279 "LPC2138.h"

#line 303 "LPC2138.h"

#line 327 "LPC2138.h"





#line 340 "LPC2138.h"


 
 
#line 360 "LPC2138.h"

 
 
#line 379 "LPC2138.h"

 
 
#line 397 "LPC2138.h"

 
 



 
 
#line 431 "LPC2138.h"

 
 





 
 
#line 448 "LPC2138.h"



 
#line 29 "config.h"

 
 	
 





#line 1 "target.h"































 


extern void Reset(void);
















 

extern void TargetInit(void);
















 





 
#line 39 "config.h"

#line 1 "C:\\Keil\\ARM\\RV31\\INC\\stdio.h"
 
 
 





 






 









#line 34 "C:\\Keil\\ARM\\RV31\\INC\\stdio.h"


  
  typedef unsigned int size_t;    








 
 

 
  typedef struct __va_list __va_list;





typedef struct __fpos_t_struct {
    unsigned __int64 __pos;
    



 
    struct {
        unsigned int __state1, __state2;
    } __mbstate;
} fpos_t;
   


 


   

 

typedef struct __FILE FILE;
   






 

extern FILE __stdin, __stdout, __stderr;
extern FILE *__aeabi_stdin, *__aeabi_stdout, *__aeabi_stderr;

#line 115 "C:\\Keil\\ARM\\RV31\\INC\\stdio.h"
    

    

    





     



   


 


   


 

   



 

   


 




   


 





    


 






extern __declspec(__nothrow) int remove(const char *  );
   





 
extern __declspec(__nothrow) int rename(const char *  , const char *  );
   








 
extern __declspec(__nothrow) FILE *tmpfile(void);
   




 
extern __declspec(__nothrow) char *tmpnam(char *  );
   











 

extern __declspec(__nothrow) int fclose(FILE *  );
   







 
extern __declspec(__nothrow) int fflush(FILE *  );
   







 
extern __declspec(__nothrow) FILE *fopen(const char * __restrict  ,
                           const char * __restrict  );
   








































 
extern __declspec(__nothrow) FILE *freopen(const char * __restrict  ,
                    const char * __restrict  ,
                    FILE * __restrict  );
   








 
extern __declspec(__nothrow) void setbuf(FILE * __restrict  ,
                    char * __restrict  );
   




 
extern __declspec(__nothrow) int setvbuf(FILE * __restrict  ,
                   char * __restrict  ,
                   int  , size_t  );
   















 
#pragma __printf_args
extern __declspec(__nothrow) int fprintf(FILE * __restrict  ,
                    const char * __restrict  , ...);
   


















 
#pragma __printf_args
extern __declspec(__nothrow) int _fprintf(FILE * __restrict  ,
                     const char * __restrict  , ...);
   



 
#pragma __printf_args
extern __declspec(__nothrow) int printf(const char * __restrict  , ...);
   




 
#pragma __printf_args
extern __declspec(__nothrow) int _printf(const char * __restrict  , ...);
   



 
#pragma __printf_args
extern __declspec(__nothrow) int sprintf(char * __restrict  , const char * __restrict  , ...);
   






 
#pragma __printf_args
extern __declspec(__nothrow) int _sprintf(char * __restrict  , const char * __restrict  , ...);
   



 

#pragma __printf_args
extern __declspec(__nothrow) int snprintf(char * __restrict  , size_t  ,
                     const char * __restrict  , ...);
   















 

#pragma __printf_args
extern __declspec(__nothrow) int _snprintf(char * __restrict  , size_t  ,
                      const char * __restrict  , ...);
   



 
#pragma __scanf_args
extern __declspec(__nothrow) int fscanf(FILE * __restrict  ,
                    const char * __restrict  , ...);
   






























 
#pragma __scanf_args
extern __declspec(__nothrow) int _fscanf(FILE * __restrict  ,
                     const char * __restrict  , ...);
   



 
#pragma __scanf_args
extern __declspec(__nothrow) int scanf(const char * __restrict  , ...);
   






 
#pragma __scanf_args
extern __declspec(__nothrow) int _scanf(const char * __restrict  , ...);
   



 
#pragma __scanf_args
extern __declspec(__nothrow) int sscanf(const char * __restrict  ,
                    const char * __restrict  , ...);
   








 
#pragma __scanf_args
extern __declspec(__nothrow) int _sscanf(const char * __restrict  ,
                     const char * __restrict  , ...);
   



 

 
extern __declspec(__nothrow) int vfscanf(FILE * __restrict  , const char * __restrict  , __va_list);
extern __declspec(__nothrow) int vscanf(const char * __restrict  , __va_list);
extern __declspec(__nothrow) int vsscanf(const char * __restrict  , const char * __restrict  , __va_list);

extern __declspec(__nothrow) int _vfscanf(FILE * __restrict  , const char * __restrict  , __va_list);
extern __declspec(__nothrow) int _vscanf(const char * __restrict  , __va_list);
extern __declspec(__nothrow) int _vsscanf(const char * __restrict  , const char * __restrict  , __va_list);

extern __declspec(__nothrow) int vprintf(const char * __restrict  , __va_list  );
   





 
extern __declspec(__nothrow) int _vprintf(const char * __restrict  , __va_list  );
   



 
extern __declspec(__nothrow) int vfprintf(FILE * __restrict  ,
                    const char * __restrict  , __va_list  );
   






 
extern __declspec(__nothrow) int vsprintf(char * __restrict  ,
                     const char * __restrict  , __va_list  );
   






 

extern __declspec(__nothrow) int vsnprintf(char * __restrict  , size_t  ,
                     const char * __restrict  , __va_list  );
   







 

extern __declspec(__nothrow) int _vsprintf(char * __restrict  ,
                      const char * __restrict  , __va_list  );
   



 
extern __declspec(__nothrow) int _vfprintf(FILE * __restrict  ,
                     const char * __restrict  , __va_list  );
   



 
extern __declspec(__nothrow) int _vsnprintf(char * __restrict  , size_t  ,
                      const char * __restrict  , __va_list  );
   



 
extern __declspec(__nothrow) int fgetc(FILE *  );
   







 
extern __declspec(__nothrow) char *fgets(char * __restrict  , int  ,
                    FILE * __restrict  );
   










 
extern __declspec(__nothrow) int fputc(int  , FILE *  );
   







 
extern __declspec(__nothrow) int fputs(const char * __restrict  , FILE * __restrict  );
   




 
extern __declspec(__nothrow) int getc(FILE *  );
   







 




    extern __declspec(__nothrow) int (getchar)(void);

   





 
extern __declspec(__nothrow) char *gets(char *  );
   









 
extern __declspec(__nothrow) int putc(int  , FILE *  );
   





 




    extern __declspec(__nothrow) int (putchar)(int  );

   



 
extern __declspec(__nothrow) int puts(const char *  );
   





 
extern __declspec(__nothrow) int ungetc(int  , FILE *  );
   






















 

extern __declspec(__nothrow) size_t fread(void * __restrict  ,
                    size_t  , size_t  , FILE * __restrict  );
   











 

extern __declspec(__nothrow) size_t __fread_bytes_avail(void * __restrict  ,
                    size_t  , FILE * __restrict  );
   











 

extern __declspec(__nothrow) size_t fwrite(const void * __restrict  ,
                    size_t  , size_t  , FILE * __restrict  );
   







 

extern __declspec(__nothrow) int fgetpos(FILE * __restrict  , fpos_t * __restrict  );
   








 
extern __declspec(__nothrow) int fseek(FILE *  , long int  , int  );
   














 
extern __declspec(__nothrow) int fsetpos(FILE * __restrict  , const fpos_t * __restrict  );
   










 
extern __declspec(__nothrow) long int ftell(FILE *  );
   











 
extern __declspec(__nothrow) void rewind(FILE *  );
   





 

extern __declspec(__nothrow) void clearerr(FILE *  );
   




 

extern __declspec(__nothrow) int feof(FILE *  );
   


 
extern __declspec(__nothrow) int ferror(FILE *  );
   


 
extern __declspec(__nothrow) void perror(const char *  );
   









 

extern __declspec(__nothrow) int _fisatty(FILE *   );
    
 

extern __declspec(__nothrow) void __use_no_semihosting_swi(void);
extern __declspec(__nothrow) void __use_no_semihosting(void);
    





 











#line 934 "C:\\Keil\\ARM\\RV31\\INC\\stdio.h"



 
#line 41 "config.h"



 
#line 2 "main.c"






 
void  Delayms(uint32  dly)
{  uint32  i;

   for(; dly>0; dly--)
      for(i=0; i<9000; i++);
}





 
void  MSpiIni(void)
{
   (*((volatile unsigned char *) 0xE002000C)) = 0x52;			
   (*((volatile unsigned char *) 0xE0020000)) = 0x30;		    
}







 
uint8  MSendData(uint8 data)
{  (*((volatile unsigned long *) 0xE002800C)) = (1<<29);			    
   
   (*((volatile unsigned char *) 0xE0020008)) = data;
   while( 0==((*((volatile unsigned char *) 0xE0020004))&0x80) );		
   
   (*((volatile unsigned long *) 0xE0028004)) = (1<<29);
   return((*((volatile unsigned char *) 0xE0020008)));
}


 
uint8 const DISP_TAB[16] = { 0xC0,0xF9,0xA4,0xB0,0x99,0x92,0x82,0xF8,0x80,0x90,
                             0x88,0x83,0xC6,0xA1,0x86,0x8E
	                   };
uint8  rcv_data; 	                   



 
int  main(void)
{
   uint32  i = 0;
   
   (*((volatile unsigned long *) 0xE002C000)) = 0x00001500;			
   (*((volatile unsigned long *) 0xE002C004)) = 0x00000000;
   (*((volatile unsigned long *) 0xE0028008)) = (1<<29);				
   MSpiIni();					
   while(1)	
   {
     
      rcv_data = MSendData(~DISP_TAB[i % 10]);	     
      rcv_data = MSendData(~DISP_TAB[i % 100 / 10]);	
      rcv_data = MSendData(~DISP_TAB[i % 1000 / 100]);	
      rcv_data = MSendData(~DISP_TAB[i / 1000 % 10]);	
      i++;
      Delayms(100);		
   }
 }
