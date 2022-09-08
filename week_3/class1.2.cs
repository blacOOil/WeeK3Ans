using System;
public class exchange{
    public static void money_in (){
       double Money ;
        Console.WriteLine("Please input money :");
        Money = double.Parse(Console.ReadLine());
        double lagpun    = Money - (Money % 1000);
        double lagroi    =   (Money - lagpun)- (Money % 100);
        double lagsib    = (Money - (lagpun+lagroi)-(Money  % 10));
        double lagnuang  = (Money - (lagpun+lagroi+lagsib)-(Money  % 1));
        double lagsatang = (Money % 1);
        tronpun(ref Money); 
        tronroi(ref Money);
        tronsib(ref Money);
        tronnuang(ref Money);
        tronsatang(ref Money );
         
       }
      public static double tronpun(ref double Money){
        double tronpun;
         double lagpun    = Money - (Money % 1000);
      tronpun = lagpun/1000;
      Console.WriteLine("1000 :{0} ",tronpun);
      Money = Money - lagpun;
      return Money;


      }
       
     public static double tronroi(ref double Money){
        double tronroi;
        double tronharoi;
        double lagpun     =    Money - (Money % 1000);
         double lagroi    =   (Money - lagpun)- (Money % 100);
      tronharoi = lagroi/500;
      Money = (Money - (500*tronharoi));
      tronroi = lagroi/100;
      Console.WriteLine("500 : {0} ",Math.Floor(tronroi/5));
      if(tronroi >= 5)
      Console.WriteLine("100 : {0} ",Math.Floor(tronroi-5));
      else
      {
        Console.WriteLine("100 : {0}",Math.Floor(tronroi));
      }
      return Money;
          }
         public static double tronsib(ref double Money){
        double tronhasib;
        double tronyesib;
        
        double lagpun    = Money - (Money % 1000);
        double lagroi    =   (Money - lagpun)- (Money % 100);
        double lagsib    = (Money - (lagpun+lagroi)-(Money  % 10));
      tronhasib = lagsib/50;
      
      tronyesib = lagsib/20;
      Console.WriteLine("50 : {0} ",Math.Floor(tronhasib/5));
      if(tronyesib >= 5)
      Console.WriteLine("20 : {0} ",Math.Floor(tronyesib-5));
      else
      {
        Console.WriteLine("20 : {0}",Math.Floor(tronyesib));
      }
      if(tronyesib > 2 )
      Console.WriteLine("10 : {0}",1);
      return Money;
          }
            public static double tronnuang(ref double Money){
        double tronha;
        
        double lagpun = Money - (Money % 1000);
        double lagroi =   (Money - lagpun)- (Money % 100);
        double lagsib= (Money - (lagpun+lagroi)-(Money  % 10));
        double lagnuang= (Money - (lagpun+lagroi+lagsib)-(Money  % 1));
      tronha = lagnuang/5;
     
      
      Console.WriteLine("5 : {0} ",Math.Floor(tronha/5));
      if(tronha > 5)
      Console.WriteLine("1 : {0} ",Math.Floor(tronha-5));
      else
      {
        Console.WriteLine("1 : {0}",Math.Floor(tronha));
      }
      
      return Money;
          }
           public static double tronsatang(ref double Money){
        double tronsatang;  
        double lagsatang= (Money % 1);
      tronsatang = lagsatang/0.50;
     
      
      Console.WriteLine("0.5 : {0} ",Math.Floor(tronsatang/5));
      if(tronsatang > 5 )
      Console.WriteLine("0.25 : {0} ",Math.Floor(tronsatang-5));
      else
      {
        Console.WriteLine("0.25 : {0}",Math.Floor(tronsatang));
      }
      
      return Money;
          }

     
          }
          
       
        
        
        

       
    
 

    
