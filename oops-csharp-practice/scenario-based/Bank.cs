using System;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Security.Principal;
class Bank
{

    public static string BankName = "Dhani Bank";
    public string Adress;
    public string Branch;
    public int IFSC;
    public double Balance = 0;
    public Bank(string Adress, string Branch, int IFSC, double Balance) // parameterized constructor
    {
        this.Adress = Adress;
        this.Branch = Branch;
        this.IFSC = IFSC;
    }
    public void BankDetails() // method to show bank details
    {
        Console.WriteLine("Bank Name: " + BankName);
        Console.WriteLine("Adress: " + Adress);
        Console.WriteLine("Branch: " + Branch);
        Console.WriteLine("IFSC: " + IFSC);
        Console.WriteLine("Balance: " + Balance);
    }
    protected UpdateBankDetails(string bankAdress,string Branch,string IFSC) // method to update bank details
    {
        this.bankAdress = bankAdress;
        this.Branch = Branch;
        this.IFSC = IFSC;
    }
    protected void updateBankBalance(double amount) // method to update bank balance
    {
        this.Balance += amount;
    }
    class BankManager : Bank //inherotence of bank class
    {
        private string ManagerName; //instance variable
        private int mobilreNumber; //instance variable
        Bank bank;
        public BankManager(Bank bank, string ManagerName, int mobilreNumber)// parameterized constructor and we are accepting bank balance as object
        {
            if (bank != null)
            {
                this.bank = bank;
                this.ManagerName = ManagerName;
                this.mobilreNumber = mobilreNumber;
            }
            else
            {
                Console.WriteLine("Bank is not valid");

            }
        public void BankManagerDetails() // method to show bank manager details
        {
            Console.WriteLine("Bank Manager Name: " + ManagerName);
            Console.WriteLine("Mobile Number: " + mobilreNumber);

        }
        public void createAccount(User user)
        {
            Account account = new Account(user);
        }
        public void deleteAccount(Account account)
        {
            account = null;
        }
        public void ReadAccount(Account account)
        {
            account.DisplayDetails();
        }
        public void UpdateAccount(Account account, User user)
        {
            // updating user details
            user.Name = user.Name;
            user.Age = user.Age;
            user.Address = user.Address;
        }

    }

}
class Account // account class
{
    private static int minimumBalance = 1000; // static variable
    public static int accountNumber = 10000; // static variable
    private static int accountId = 10000;
    private int Balance = 0;
    private User user; // instance variable
    public Account(User user) // parameterized constructor
    {
        this.user = user;
        this.accountNumber = ++accountId;
    }
    public void DisplayDetails() // method to display account details
    {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("User Name: " + user.Name);
        Console.WriteLine("User Age: " + user.Age);
        Console.WriteLine("User Address: " + user.Address);
    }
    public void UpdateAccountDetails(User user) // method to update account details
    {
        this.user = user;
    }
    public void deposit(int amount)
    {
        this.Balance += amount;
    }
    public void withdraw(int amount)
    {
        if (this.Balance - amount >= minimumBalance)
        {
            this.Balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient Balance");
        }
    }



}
class User
{
    private string username; // instance variable
    private string userAddress; // instance variable
    private int userAge; // instance variable
    private DateTime userDOB; // instance variable
    private User(string username, string userAddress, int userAge, DateTime userDOB) // parameterized constructor
    {
        this.username = username;
        this.userAddress = userAddress;
        this.userAge = userAge;
        this.userDOB = userDOB;
    }

}
}