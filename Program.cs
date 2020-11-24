using System;  
  public class primszame_Pelsoczi_Domokos_12A
{  
     public static void Main(string[] args)  
      {
          int szam, i, kettovel_osztva = 0;
          bool prim=true;    
          Console.Write("Adja meg a számot: ");    
          szam = int.Parse(Console.ReadLine());  
          kettovel_osztva=szam/2;    
          for(i = 2; i <= kettovel_osztva; i++)    
          {    
           if(szam % i == 0)    
            {        
             prim=false;    
            }    
          }    
          if (prim==true)    
            Console.Write("A szám prím.");
          else
            Console.Write("A szám nem prím."); 
     }  
   }  