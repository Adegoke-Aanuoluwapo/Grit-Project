﻿using System;
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
            //string name = "Abatha";
            // int age = 25;
            // Console.WriteLine("Name: "+ name);
            // Console.WriteLine("Age: "+ age);
            // Console.WriteLine("My name is {0} and I am {1} years old", name, age);
            // Console.WriteLine();
            // Console.WriteLine("Name: "+ name + "\nAge: "+age);
            //  Console.WriteLine("Name: {0}\nAge: {1}",name,age);
            //  Console.WriteLine($"Your name is: {name} and you are {age} years old");
            //  string test = string.Concat($"Your name is {name} and you are {age}years old");
            //  Console.WriteLine(test);
            //  string[] names = new string []{"Aba", "Test", "Test2"};
            //  Console.WriteLine(string.Concat(names));
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
          //   string message = "C# is awesome";
          //  for(int i = 0; i < message.Length; i++)
          //  {
          //   Console.Write(message[i]);
          //   Thread.Sleep(50);
          //  }
          //  Console.WriteLine();
          //  Console.WriteLine(message.Contains("#"));
          //  bool contains = false;
          //  for(int i = 0; i < message.Length; i++)
          //  {
          //   if(message[i].Equals('a'))
          //   {
          //     contains = true;
          //   }
          //  }
          //  Console.WriteLine(contains);
          //  Console.ReadLine();
          // Console.WriteLine("Enter your name");
          // string name = Console.ReadLine();
          // Console.WriteLine($"Your name is {name}");
          // if(name != "")
        
          //   Console.WriteLine("0");
         
          // if(!name.Equals(""))
          //   Console.WriteLine("1");

          // if(!string.IsNullOrEmpty(name))
          // {
          //   if(name.Equals("Aba"))
          //   {
          //       Console.WriteLine("Correct");
          //   }
          // }
            // for( int i = 0; i < message.Length; i++)
          // {
          //     Console.Write(message[i]);
          //       Thread.Sleep(400);
          // }
          // else
          // {
          //   Console.Write("Please enter password:");
          // }


          // Console.Write(message[0]);
          
          // Console.WriteLine();
          // Console.WriteLine(message.Length);
          // for (int i = 0; i < message.Length; i++)
          // {
          //    Console.Write(message[i]);
          //    Thread.Sleep(400);
          // }
          // Console.WriteLine();
          // for(int i = message.Length -1; i >= 0;  i--)
          // {
          //   Console.Write(message[i]);
          //   Thread.Sleep(400);
          // }

          
          // for(int i = 0; i < message.Length; i++){
          //   Console.Write(message[i]);
          //   Thread.Sleep(240);
          // }
          // string reversedMessage = message.reversedMessage;
          // Console.WriteLine("\nReversed message: " + reversedMessage);
        //   string  password;
        //   string  confirmPassword;
        //   do
        //   {
        //       Console.Write(" Please enter your password: ");
        //       password = Console.ReadLine();

        //   Console.Write("Confirm your password: ");
        //    confirmPassword = Console.ReadLine();
        //  if(password.Equals(string.Empty))
        //  {
        //   Console.Write("Password cannot be empty. Please enter your password: ");
        //   continue;
        //  }
        //  if(password.Length < 6 && confirmPassword.Length < 6)
        //     {
               
              
        //          Console.Write("Password not be less than six digit");
        //          continue;
          
          
        //     }
        //  if (!password.Equals(confirmPassword))
        //     {
        //         Console.WriteLine("Passwords do not match. Please try again.");
        //     }
           
            
          
           
        //  } 
        //   while  (!password.Equals(confirmPassword));
        //   {
        //     Console.Write("Password Matched");
        //   }
        

        //  int [] numbers = new int[10];
          // numbers[0] = 5;
          // numbers[1] = 13;
          // numbers[2] = 15;
          // for(int i = 0; i < numbers.Length; i++)
          // {
          //       Console.WriteLine("Please enter  number");
          //       numbers[i] =Convert.ToInt32(Console.ReadLine());
          // }
  
         
          // int sum = 0;
          // foreach (int number in numbers)
          // {
          //   sum += number;
          // }
          // Console.WriteLine($"{sum}");
          // for(int i = 0; i < numbers.Length; i++)
          // {
          //   Console.Write($"{numbers[i]} ");
          // }
          // const int angleCount = 3;
          // int angleSum = 0;
          // int[] angles = new int[angleCount];
          // for(int i = 0; i < angles.Length; i++)
          // {
          //      Console.Write($"Enter angle  {i + 1}: ");
          //      angles[i] = Convert.ToInt32(Console.ReadLine());
          // }
         
          // foreach (int number in angles)
          // {
          //     angleSum += number;
          // }

          // Console.WriteLine(angleSum);
          // Console.WriteLine(angleSum == 180 ? "Triangle is valid" : "Triangle is not valid");
          // int[] numbers = new int[]{0, 1, 2, 3, 4, 5, 6, 7, 8 , 9};
          // Array.Sort(numbers);
          // foreach(int number in numbers)
          // {
          //   Console.Write($"{number} ");
          // }
          // string test = "";
          // test.Replace(" ", "");
          
          // Console.WriteLine();
          // int[] sortedNumbers = new int[numbers.Length];
          // int x = 0;
          // for(int i = numbers.Length - 1; i >= 1; i-- )
          // {
          //   sortedNumbers[x] = numbers[i];
          //   x++;
          // }
          // foreach(int num in sortedNumbers)
          // {
          //   Console.Write($"{num} ");
          // }
          // // Array.Clear(numbers, 0, numbers.Length);
          // Array.Clear(numbers, 5, 5);

          // for (int i = 5; i < 8; i++)
          // {
          //   numbers[i] = default;
          // }
          // foreach(int num in numbers)
          // {
          //     Console.WriteLine($"{num} ");
          // }
       
          // Array.Reverse(numbers);
          // foreach(int number in numbers)
          // {
          //   Console.Write($"{number} ");
          // }
          // int[] numbers = new int[]
          // {
          //   90, 99, 22, 50, 30
          // };
          // Console.WriteLine("Please enter the number to search: ");
          // int search = Convert.ToInt32(Console.ReadLine());
          // int position = -1;
          // for (int i = 0; i < numbers.Length; i++){
          //   if (numbers[i] == search){
          //     position = i;
          //   }
          // }
          // // int position = Array.IndexOf(numbers, search);
          // if (position >= 0)
          // {
          //   Console.WriteLine($"numbers {search} has been found at {position}");
          // }
          // else{
          //   Console.WriteLine($"numbers {search} has not been found");
        //  }
          // Console.WriteLine($"number {search} is not in the array");

          //LIST

      //     List<int> listNumbers = new List<int>();
           
         
      //  for (int i = 0; i < 5; i++)
      //   {
      //       Console.WriteLine($"Enter a number {i}: ");  // Iterates over the list and prints each element to the console
      //       int num = Convert.ToInt32(Console.ReadLine());
      //       listNumbers.Add(num);
      //  }
     
      // for(int i = 0; i < listNumbers.Count; i++)
      // {
      //   Console.Write($"{listNumbers[i]}, ");
      // }
      // listNumbers.RemoveAt(0);
      // Console.WriteLine();

      //   foreach(int item in listNumbers ){
      //   Console.Write($"{item}, ");
      //  }
      //  Console.ReadLine();

      // DICTIONARY
      // Dictionary<int, string>names = new Dictionary<int, string>
      // {
      //   {1, "John"},
      //   {2, "Mary"},
      //   {3, "Jane"}
      // };
      // // foreach( name in names)
      // // {
      // //   Console.WriteLine($"Key: {name.Key}, Value: {name.Value}");
      // // }cls
      // for(int i = 0; i < names.Count; i++)
      // {
      //   Console.WriteLine($"Key: {names.Keys.ElementAt(i)} - Value: {names.Values.ElementAt(i)}");

      // }
      // Dictionary<string, string>teachers = new Dictionary<string, string>
      // {
      //   {"Math", "John"},
      //  {"English", "Mary"}
      // };
      // for(int i = 0; i < teachers.Count; i++)
      // {
      //   Console.WriteLine($"{teachers.Keys.ElementAt(i)} - {teachers.Values.ElementAt(i)}");

      // }
      // Console.WriteLine("Please enter a number");
      // int num = Convert.ToInt32(Console.ReadLine());
      
      // int length = 5;
      // int[] result = new int [length];
      // int counter = 0;
      // for(int i = 1; i < result.Length; i++, counter++ )
      // {
      //   result[counter] = num * i;
       
      // }
      // foreach(int item in result)
      // {
      //   Console.Write($"{item} ");
      // }
      // FUNCTIONS
     
    Console.Title = $"{ReturnName()}";
    
    PrintIntroduction();
    Console.WriteLine();
    int[] numbers = new int[3];
    for(int i =0; i < numbers.Length; i++)
    {
      numbers[i] = ReadNumberFromConsole();
    }
    foreach (int number in numbers)
    {
      Console.Write($"{number} ");

    }
    Console.WriteLine();
    int[] newNumbers = CreateRandomArray();
    foreach (int num in newNumbers)
    {
      Console.Write($"{num} ");
    }

     
      

    }
    // static   void CreateAndPrintArray()
    // {
    //   int[] numbers = new int[5]{
    //     0, 1, 3, 4, 5
    //   };
    //   foreach (int  item in numbers)
    //   {
    //     Console.Write($"{item}, ");
    //   }
    //}
    static void Something()
    {

    }
    static void conversion()
    {

    }
    static void calculation()
    {

    }
    static void Add()
    {

    }
    static int[] CreateRandomArray()
    {
      int[] numbers = new int[5]{
        0, 1, 3, 4, 5
      };
      return numbers;
    }
    static int ReadNumberFromConsole()
    {
      Console.Write("Enter a number: ");
      return Convert.ToInt32(Console.ReadLine());
    }
    static string ReturnName()
    {
      return "Aba";
    }
    static int ReturnAge(){
      return 34;
    }
    static void PrintIntroduction()
    {
      // string name = ReturnName();
      // int age = ReturnAge();
      string output = $"Hello my name is {ReturnName()} and I am {ReturnAge()}years old";
      Console.WriteLine(output);
    }
    
  
  }
}