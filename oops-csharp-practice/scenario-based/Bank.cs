using System;

class Bank //bank class
{
    //class variables
    private static string bankName = "SBI Bank"; //static variable because it is common for all
    private string bankAddress; //instance variable
    private string branch; //make this private we can use getter and setter
    private string ifsc;
    private double bankBalance = 0;

    public Bank(string bankAddress, string branch, string ifsc)
    //parameterized constructor it is accepting three arguments 
    //the other field bankName is static and bank balance in starting is 0.
    {
        this.bankAddress = bankAddress;
        this.branch = branch;
        this.ifsc = ifsc;
    }

    public void BankDetails() //method to show bank details
    {
        Console.WriteLine("Bank Details :- ");
        Console.WriteLine("Bank Name :" + bankName);
        Console.WriteLine("Bank Address :" + bankAddress);
        Console.WriteLine("Bank Branch :" + branch);
        Console.WriteLine("Bank IFSC :" + ifsc);
        Console.WriteLine("Bank Balance :" + bankBalance);
    }

    protected void UpdateBankDetails(string bankAddress, string branch, string ifsc)
    //method to update bank details
    {
        this.bankAddress = bankAddress;
        this.branch = branch;
        this.ifsc = ifsc;
    }

    protected void UpdateBankBalance(double amount) //method to update bank balance
    {
        this.bankBalance += amount;
    }
}

class BankManager //bank manager class
{
    private string managerName; //instance variable
    private int mobileNumber; //instance variable
    private Bank bank; //bank object
    private Account account; //account object

    public BankManager(Bank bank, string managerName, int mobileNumber)
    //parameterized constructor and we are accepting bank because 
    //if bank is not there we can not make bank manager
    {
        if (bank != null)
        {
            this.bank = bank;
            this.managerName = managerName;
            this.mobileNumber = mobileNumber;
        }
        else
        {
            Console.WriteLine("You cannot make bank manager because bank is not created");
        }
    }

    public void BankManagerDetails() //method to show bank manager details
    {
        Console.WriteLine("Bank Manager Details :- ");
        Console.WriteLine("Bank Manager Name :" + managerName);
        Console.WriteLine("Bank Manager Mobile Number :" + mobileNumber);
    }

    public void CreateAccount(User user) //here making account of user
    {
        account = new Account(user);
        Console.WriteLine("Account created successfully");
    }

    public void DeleteAccount()
    //here we are deleting account by making reference null
    //garbage collector will remove object automatically
    {
        account = null;
        Console.WriteLine("Account deleted successfully");
    }

    public void ReadAccount() //method to read account details
    {
        if (account != null)
        {
            account.DisplayDetails();
        }
        else
        {
            Console.WriteLine("No account found");
        }
    }

    public Account GetAccount() //method to return account reference
    {
        return account;
    }

    public void UpdateDetails(Account account, User user)
    //method to update account details and calling update account details method of account class
    {
        account.UpdateAccountDetails(user);
        Console.WriteLine("Account details updated successfully");
    }

    public void updateUserDetails(User user, string userName, string userAddress, int userMobileNumber)
    //method to update user details
    {
        user.UpdateUserDetails(userName, userAddress, userMobileNumber);
        Console.WriteLine("User details updated successfully");
    }

    public void ReadUser(User user) //method to read user details
    {
        user.DisplayUserDetails();
    }
}

class Account //account class
{
    //static variable
    private static int minimumBalance = 1000;
    private static int maximumTransaction = 100000;
    private static int accountId = 10000;

    public int accountNumber; //instance variable
    private int balance = 0; //instance variable
    private User user; //user object

    public Account(User user) //parameterized constructor for creating account
    {
        this.accountNumber = ++accountId;
        this.user = user;
    }

    public void DisplayDetails() //method to display account details
    {
        Console.WriteLine("Account Details :- ");
        Console.WriteLine("Account Number :" + accountNumber);
        Console.WriteLine("Account Holder Name :" + user.UserName);
        Console.WriteLine("Account Holder Address :" + user.UserAddress);
        Console.WriteLine("Account Holder Mobile Number :" + user.UserMobileNumber);
        Console.WriteLine("Account Balance :" + balance);
    }

    public void UpdateAccountDetails(User user) //method to update account details
    {
        this.user = user;
    }

    public void Deposit(int amount) //method to update balance
    {
        balance += amount;
    }

    public void Withdraw(int amount) //method to withdraw amount
    {
        if (amount > balance)
        {
            Console.WriteLine("Insufficient balance");
        }
        else
        {
            balance -= amount;
        }
    }
}

class User //user class
{
    private string userName; //instance variable
    private string userAddress; //instance variable
    private int userMobileNumber; //instance variable
    private DateTime dateOfBirth;
    private int age;

    public User(string userName, string userAddress, int userMobileNumber, DateTime dateOfBirth)
    //parameterized constructor
    {
        this.userName = userName;
        this.userAddress = userAddress;
        this.userMobileNumber = userMobileNumber;
        this.dateOfBirth = dateOfBirth;
        this.age = DateTime.Now.Year - dateOfBirth.Year;
    }

    //getter methods to access private variables
    public string UserName { get { return userName; } }
    public string UserAddress { get { return userAddress; } }
    public int UserMobileNumber { get { return userMobileNumber; } }

    public void DisplayUserDetails() //method to display user details
    {
        Console.WriteLine("User Details :- ");
        Console.WriteLine("User Name :" + userName);
        Console.WriteLine("User Address :" + userAddress);
        Console.WriteLine("User Mobile Number :" + userMobileNumber);
        Console.WriteLine("User Age :" + age);
    }

    public void UpdateUserDetails(string userName, string userAddress, int userMobileNumber)
    //method to update user details
    {
        this.userName = userName;
        this.userAddress = userAddress;
        this.userMobileNumber = userMobileNumber;
    }
}

class Cashier //cashier class
{
    private string cashierName; //instance variable
    private int mobileNumber; //instance variable

    public Cashier(string cashierName, int mobileNumber) //parameterized constructor
    {
        this.cashierName = cashierName;
        this.mobileNumber = mobileNumber;
    }

    public void CashierDetails() //method to display cashier details
    {
        Console.WriteLine("Cashier Details :- ");
        Console.WriteLine("Cashier Name :" + cashierName);
        Console.WriteLine("Cashier Mobile Number :" + mobileNumber);
    }

    public void Deposit(Account account, int amount) //method to deposit amount in account
    {
        account.Deposit(amount);
    }

    public void Withdraw(Account account, int amount) //method to withdraw amount from account
    {
        account.Withdraw(amount);
    }
}

class Program //main class
{
    //entry point
    static void Main()
    {
        Console.WriteLine("Bank Management System");

        Bank bank = new Bank("Mathura", "Mathura Branch", "UTIB0001");
        //creating bank object

        BankManager bankManager = new BankManager(bank, "Ujjwal", 1234567890);
        //creating bank manager object

        Cashier cashier = new Cashier("Shivam", 1234567890);
        //creating cashier object

        User user = new User("Ujjwal", "Bank Address", 1234567890, new DateTime(2000, 1, 1));
        //creating user object

        bank.BankDetails(); //calling bank details method of bank class
        cashier.CashierDetails(); //calling cashier details method of cashier class
        bankManager.BankManagerDetails(); //calling bank manager details method

        bankManager.CreateAccount(user); //calling create account method
        bankManager.ReadUser(user); //calling read user method
        bankManager.ReadAccount(); //calling read account method

        Account account = bankManager.GetAccount(); //getting account reference

        cashier.Deposit(account, 1000); //calling deposit method
        cashier.Withdraw(account, 500); //calling withdraw method

        bankManager.ReadAccount(); //reading account again
    }
}