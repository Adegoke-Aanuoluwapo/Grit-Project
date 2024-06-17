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
          
              
           
          //Console.WriteLine("Hello World");   

                
                // bool success = true;
                // while (success)
                // {
                //     Console.Write("Enter a number: ");
                //     string newInput = Console.ReadLine();
                //     int number = 0;

                       
                //     if(int.TryParse(newInput, out number))
                //     {
                //         success = false;
                //         Console.WriteLine("You entered :", number);
                //     }
                //         else
                //         {
                //             Console.WriteLine("Invalid input");
                //         }

                
                // }
                //     Console.ReadLine();

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 10; i++){
                Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
            }
            // Console.Write("Enter a number: ");
            // int number = Convert.ToInt32(Console.ReadLine());
            // for (int i = 1; i <= 10; i++)
            // {
            //     Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
            // }
            Console.ReadLine();


    }
    
  
  }
}