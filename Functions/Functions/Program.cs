using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //     Console.WriteLine(Add(10, 50));
          
        //     int num = ReadInt("Enter a number ");
            
        //     Console.WriteLine(num);

        //     int firstNum = ReadInt("Enter first number:");
        //     int secondNum = ReadInt("Enter second number:");
        //     int sum = Add(firstNum, secondNum);
        //     int product = Multiply(firstNum, secondNum);
            
        //     Console.WriteLine(sum);
        //     Console.WriteLine();
        //     Console.WriteLine(product);
          
           
        //     Console.WriteLine();
        // }
        // static string UserDetails(string name, int age)
        // {
        //     return $"Hello my name is: {name}, and I am {age}years old";
        // }
        // static int ReadInt(string message)
        // {
        //       Console.WriteLine($"{message}");
        //    int num1 = Convert.ToInt32(Console.ReadLine());
        //    return num1;
        // }
        // static int Add(int a, int b)
        // {
        //     return a + b;
        // }
        //  static int Multiply(int a, int b)
        // {
        //     return a * b;
        // }
        List<string> shoppingList =new List<string>
        {
                "Coffee", "Milk"
        };
        Console.WriteLine(shoppingList.IndexOf("Coffee"));

       
        
        Console.WriteLine(FindInList("Coffee", shoppingList, out int index));
        if(FindInList("Coffee",shoppingList, out index))
        {
            Console.WriteLine($"Found Coffee at index {index}");

        }
        else{
            Console.WriteLine("Not found");
        }
        }
        static bool FindInList(string s, List<string> list, out int index)
        {
              index = -1;
        for (int i = 0; i <list.Count; i++)
        {
            if(list[i].ToLower().Equals(s.ToLower()))
            {
                index =i;
            }
        }
        return index > -1;
        }
    }
}