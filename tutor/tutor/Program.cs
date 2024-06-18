using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;
using System.Threading;

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

            // Console.Write("Enter a number: ");
            // int number = Convert.ToInt32(Console.ReadLine());
            // for(int i = 1; i <= 10; i++){
            //     Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
            // }
            // Console.Write("Enter a number: ");
            // int number = Convert.ToInt32(Console.ReadLine());
            // for (int i = 1; i <= 10; i++)
            // {
            //     Console.WriteLine("{0} x {1} = {2}", i, number, i * number);
            // }
            // Console.ReadLine();
            string name = "Abatha";
            int age = 25;
            Console.WriteLine("Name: "+ name);
            Console.WriteLine("Age: "+ age);
            Console.WriteLine("My name is {0} and I am {1} years old", name, age);
            Console.WriteLine();
            Console.WriteLine("Name: "+ name + "\nAge: "+age);
             Console.WriteLine("Name: {0}\nAge: {1}",name,age);
             Console.WriteLine($"Your name is: {name} and you are {age} years old");
             string test = string.Concat($"Your name is {name} and you are {age}years old");
             Console.WriteLine(test);
             string[] names = new string []{"Aba", "Test", "Test2"};
             Console.WriteLine(string.Concat(names));
            //  Console.Write("Enter your name:");
            //  string greet = Console.ReadLine();
             
            //  if(greet != string.Empty){
            //      Console.WriteLine($"You are welcome {greet}");
            //  }
            //  else{
            //   Console.WriteLine("You didn't enter anything");
            //  }
            
            //  Console.ReadLine();
            //  string message = "Hello";
            // string compare = "Hello World";
            // if(message.Equals(compare))
            // {
            //   Console.WriteLine("Same");
            // }
            // else
            // {
            //   Console.WriteLine("Not same");
            // }
            // Console.WriteLine("Enter your name");
            // string named = Console.ReadLine();
            // if(named != string.Empty)
            // {
            //   Console.WriteLine($"Your name is {named}");
            // }
            // else
            // {
            //   Console.WriteLine("You didn't enter anything");
            // }
            // char[] chars = new char[]{'H', 'e', 'l', 'l', 'o'};
            // object newCompare = new string(chars);
            // if(message ==newCompare)
            // {
            //   Console.WriteLine("Same");
            // }
            // else
            // {
            //   Console.WriteLine("Not same");
            // }
            // Console.WriteLine(chars);
            string message = "C# is awesome";
           for(int i = 0; i < message.Length; i++)
           {
            Console.Write(message[i]);
            Thread.Sleep(50);
           }
           Console.WriteLine();
           Console.WriteLine(message.Contains("#"));

    }
    
  
  }
}