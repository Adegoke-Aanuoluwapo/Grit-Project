using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace Tutorial
{   
  public static class Program{

   
           static void Main(string[] args)
           {
          
              bool threeDiv = false;
              bool fiveDiv = false;

              // Console.WriteLine("Enter a number: ");
              // int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 100; i++)
            {
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;
                   
              if(threeDiv && fiveDiv)
              {
                Console.WriteLine("The number is FizzBuzz");
              }
            

              else if(fiveDiv)
              {
                Console.WriteLine("The number is Buzz");

              }

              else if(threeDiv)
              
              {
                Console.WriteLine("The number is Fizz");
              }
            }
            
             
           


    }
    
  
  }
}