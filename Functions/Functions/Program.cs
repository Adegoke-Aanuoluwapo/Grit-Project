using System.Reflection;
using System.Reflection.Metadata.Ecma335;
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
    //     List<string> shoppingList =new List<string>
    //     {
    //             "Coffee", "Milk"
    //     };
    //     Console.WriteLine(shoppingList.IndexOf("Coffee"));

    //    Console.WriteLine("Enter an item to search");
    //    string search = Console.ReadLine();
        
    //     Console.WriteLine(FindInList(search, shoppingList, out int index));
    //     if(FindInList(search,shoppingList, out index))
    //     {
    //         Console.WriteLine($"Found {search} at index {index}");

    //     }
    //     else{
    //         Console.WriteLine("Not found");
    //     }
    //     }
    //     static bool FindInList(string s, List<string> list, out int index)
    //     {
    //           index = -1;
    //     for (int i = 0; i <list.Count; i++)
    //     {
    //         if(list (10)

    //     }
        // int num = 10;
        // num =Assign();
        // Console.WriteLine(num);
        // Console.ReadLine();
        // string name = "joe";
        // Console.WriteLine(name);
        // Console.Write("Enter your new name: ");
        // string newName =Console.ReadLine();
        // if(ChangeName(ref name, newName))
        // {
        //      Console.WriteLine($"Your new name is: {newName}");
        // }
        // else
        // {
        //     Console.WriteLine("New name cannnot be null");
        // }
         
       
        // }
        // static  int Assign()
        // {
        //     return 20;
        // }
        // static bool ChangeName(ref string name, string newName)
        // {
        //     if(!string.IsNullOrEmpty(newName))
        //     {

        //              name = newName;
        //              return true;
        //     }
        //     return false;
        
         int width =  ReadInt("Enter width");

        
          int height =   ReadInt("Enter height");
        //   double area = (width*height)*1/2;
           int AreaT = Area(width, height);
          Console.WriteLine($"The area of the triangle is :{AreaT}");
          

        }
        static int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        static int Area(int a, int b)
        {
            return a * b/2;
        }

    }
}