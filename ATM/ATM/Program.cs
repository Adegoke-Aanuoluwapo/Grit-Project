// See https://aka.ms/new-console-template for more information
using System; 

namespace MyProject;
class cardHolder
{
 
  //Console.WriteLine("Hello, World!");
  string cardNum;
  int pin;
  string firstName;
  string lastName;
  double balance;

  public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
  {
   this.cardNum = cardNum;
   this.pin = pin;
   this.firstName = firstName;
   this.lastName = lastName;
   this.balance = balance;
  }

  public string getNum()
  {
   return cardNum;
  }

  public int getPin()
  {
   return pin;
  }
  public string getfirstName()
  {
   return firstName;
  }
  public string getlastName()
  {
   return lastName;
  }
  public double getBalance()
  {
   return balance; 
  }

  public void setNum(string newCardNum)
  {
   cardNum = newCardNum;
  }
  public void setPin(int newPin)
  {
   pin = newPin;
  }
  public void setFirstName(string newFirstName)
  {
   firstName = newFirstName;
  }
  public void setLastName(string newLastName)
  {
   lastName = newLastName;
  }
  public void setBalance(double newBalance)
  {
   balance = newBalance;
  }
 static void Main(string[] args)
 {
  void printOptions()
  {
   Console.WriteLine("Please choose an option......");
   Console.WriteLine("1. Deposit");
   Console.WriteLine("2. Withdraw");
   Console.WriteLine("3. Show Balance");
   Console.WriteLine("4. Exit");

  }

  printOptions();
 }
}
