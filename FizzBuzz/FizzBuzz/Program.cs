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
          
              
              Console.WriteLine("Enter a number: ");
              int number = Convert.ToInt32(Console.ReadLine());
            
               
              if(number % 3 == 0 && number % 5 == 0)
              {
                Console.WriteLine("The number is FizzBuzz");
              }
            
              else if(number % 5 == 0)
              {
                Console.WriteLine("The number is Buzz");

              }

              else if(number % 3 == 0)
              
              {
                Console.WriteLine("The number is Fizz");
              }
             
           


    }
    
  
  }
}