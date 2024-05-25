using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator;
class Program
{
 static void Main(string[] args)
 {
  int num1;
  int num2;
  string answer;
  int result = 0;

  //Console.WriteLine("Hello, World!");
  Console.WriteLine("Please enter a number");

  num1 = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Please enter the second number");
  num2 = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("What type of operation would you like to do");
  Console.WriteLine("a. Addition, s. Subtraction, m. multiplication, d. Division");
  answer = Console.ReadLine();
  if (answer == "a")
  {
   result = num1 + num2;
  }
  else if (answer == "s")
  {
   result = num1 - num2;
  }
  else if (answer == "m")
  {
   result = num1 * num2;
  }
  else if (answer == "d")
  {
   result = num1 / num2;
  }
  Console.WriteLine("The result is " + result);
  Console.WriteLine("Thanks for using this calculator");
  Console.ReadKey();

 }
}