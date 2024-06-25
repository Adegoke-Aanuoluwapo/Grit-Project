using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> odd = new List<int>();
        List<int> even = new List<int>();
        Console.WriteLine("Please enter a number");
        int Count = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i <= Count; i++){
            if(i % 2 == 0){
                even.Add(i);
            }
            else
            {
                odd.Add(i);
            }
        };
        foreach(int od in odd)
        {
            Console.Write($"{od} ");
        }
        Console.WriteLine();
         foreach(int ev in even)
        {
            Console.Write($"{ev} ");
        }
       
       
    }
}