using System;
using System.Security.Cryptography.X509Certificates;

public class BankAccountManagement
{
    public int accountNumber; // Instance Variable
    protected string accountHolderName; // Instance Variable
    private double balance; // Instance Variable
    public BankAccountManagement(int accountNumber, string accountHolderName, double balance)
    {
        this.accountNumber = accountNumber; // Using 'this' keyword to resolve ambiguity
        this.accountHolderName = accountHolderName;
        this.balance = balance;
    }
    public void SetBalance(double balance) //method to modify private variable
    {
        this.balance = balance;
    }
    public double GetBalance() //method to access private variable
    {
        return balance;
    }
    class SavingsAccount : BankAccountManagement
    {
        public SavingsAccount(int accountNumber, string accountHolderName, double balance) : base(accountNumber, accountHolderName, balance)
        {

        }
        public void ShowAccountHolderName()
        {
            Console.WriteLine("Savings Account Holder Name: " + accountHolderName);
        }
        public void ShowAccountNumber()
        {
            Console.WriteLine("Savings Account Number: " + accountNumber);
        }


    }
    public void showAccountDetails()
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder Name: " + accountHolderName);
        Console.WriteLine("Balance: " + balance);
    }
    public static void Main()
    {
        BankAccountManagement account = new BankAccountManagement(123456, "Ujjawal Verma", 15000.50);
        account.showAccountDetails();
        account.SetBalance(20000.75); //modifying private variable using method
        SavingsAccount savingsAccount = new SavingsAccount(654321, "Harsh Kumar", 25000.00);
        savingsAccount.ShowAccountHolderName();
        savingsAccount.ShowAccountNumber();

    }





}