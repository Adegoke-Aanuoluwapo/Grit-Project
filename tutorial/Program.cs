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
          
              
           
              // int age = 10;
              // string result = age >= 0 ? "Valid" : "Invalid";
              // Console.WriteLine(result);  
              double  value = 1000D /12.340;
              Console.WriteLine(value);
              Console.WriteLine(string.Format("{0:0}", value));
              Console.WriteLine(string.Format("{0:0.#}", value));
              Console.WriteLine(string.Format("{0:0.00}", value));
              

              double money = 100 / 3D;
              Console.WriteLine(money);
              Console.WriteLine(string.Format("$10 /$3 ={0:0.00}", money));
              Console.WriteLine(money.ToString("C"));
              
              Console.WriteLine(money.ToString("C0"));
              Console.WriteLine(money.ToString("C1"));
              Console.WriteLine("Hello World");
              Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
              Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));
              Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
              Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
              Console.ReadLine();



    }
    
  
  }
}