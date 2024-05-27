using System;

namespace GuessGame
{
 class Program
 {
  static void Main(string[] args)
  {
   bool isCorrectGuess = false;
   Random random = new Random();
   int randomNum = random.Next(1, 11);

   Console.WriteLine("Welcome to the number guessing game");
   Console.WriteLine("A number between 1 and 10 will be generated");
   Console.WriteLine("If you guess the number correct you will win");

   Console.WriteLine(randomNum);
   while(!isCorrectGuess){

   }
   Console.ReadKey();

  }
 }
}