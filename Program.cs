using System;
public class cardHolder
{
    string cardNum;
    int pin;
    string firstName;
    string lastName;
    double balance;
    public cardHolder(string cardNum,
    int pin,
    string firstName,
    string lastName,
    double balance ) {
    this.cardNum = cardNum;
        this.pin = pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance = balance;

    
    
    }
    public string getNum() {  return cardNum; }
    public int getPin() { return pin; }

    public string getFirstName() { return firstName; }
    public string getLastName() { return lastName; }
    public double getBalance() { return balance; }

    public void setPin(int newPin)
    {
        pin= newPin;
    }
    public void setFirstName(string newFirstName) {  firstName = newFirstName; }
    public void setLastName(string newLastName) {  lastName = newLastName; }
    public void setBalance(double newBalance) {  balance = newBalance; }

    public static void Main(string[] args)
    {
        void printOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("1. Withdraw");
            Console.WriteLine("1. Show Balance");
            Console.WriteLine("1. Exit");
        }
    }





}