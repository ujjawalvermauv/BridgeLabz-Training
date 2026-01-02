using System;

class BankAccount
{
    // static variable (shared by all accounts)
    public static string bankName = "State Bank of India";
    private static int totalAccounts = 0;

    // readonly variable (cannot be changed once assigned)
    public readonly int AccountNumber;

    // instance variable
    public string AccountHolderName;

    // constructor
    public BankAccount(string AccountHolderName, int AccountNumber)
    {
        // using 'this' to resolve ambiguity
        this.AccountHolderName = AccountHolderName;
        this.AccountNumber = AccountNumber;

        totalAccounts++; // increase total account count
    }

    // static method
    public static void GetTotalAccounts()
    {
        Console.WriteLine("Total Accounts: " + totalAccounts);
    }

    // method to display account details
    public void DisplayDetails()
    {
        Console.WriteLine("Bank Name: " + bankName);
        Console.WriteLine("Account Holder: " + AccountHolderName);
        Console.WriteLine("Account Number: " + AccountNumber);
    }
}

class Program
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount("Ujjawal Verma", 1001);
        BankAccount acc2 = new BankAccount("Amit Kumar", 1002);

        // using static method
        BankAccount.GetTotalAccounts();

        // using 'is' operator before displaying details
        if (acc1 is BankAccount)
        {
            Console.WriteLine("\nAccount 1 Details:");
            acc1.DisplayDetails();
        }

        if (acc2 is BankAccount)
        {
            Console.WriteLine("\nAccount 2 Details:");
            acc2.DisplayDetails();
        }
    }
}
