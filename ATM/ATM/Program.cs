// See https://aka.ms/new-console-template for more information
using System; 

namespace MyProject;
class cardHolder
{
 static void Main(string[] args)
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
  public string firstName()
  {
   return firstName;
  }
  public string lastName()
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

 }
}
