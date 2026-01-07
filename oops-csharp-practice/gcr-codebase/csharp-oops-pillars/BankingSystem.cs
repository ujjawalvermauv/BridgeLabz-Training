using System;
interface ILoanable
{
    void ApplyForLoan(); // Method to apply for a loan
    double CalculateLoanEligibility(); // Method to calculate loan eligibility

}
abstract class BankAccount
{
    private int accountNumber;
    private string holderName;
    protected double balance;
    public int AccountNumber
    {
        get { return accountNumber; }
        set { accountNumber = value; }
    }
    public string HolderName
    {
        get { return holderName; }
        set { holderName = value; }
    }
    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Deposited: " + amount);
    }
    public void Withdraw(double amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            Console.WriteLine("Withdrawn: " + amount);
        }
        else
        {
            Console.WriteLine("Insufficient balance");
        }

    }
    public abstract void CalculateInterest();

}
class SavingsAccount : BankAccount, ILoanable
{
    private double interestRate;
    public SavingsAccount(int accNum, string name, double rate)
    {
        AccountNumber = accNum;
        HolderName = name;
        interestRate = rate;
        balance = 0;
    }
    public override void CalculateInterest()
    {
        double interest = balance * interestRate / 100;
        Console.WriteLine("Interest for Savings Account: " + interest);
    }
    public void ApplyForLoan()
    {
        Console.WriteLine("Applying for loan from Savings Account: " + AccountNumber);
    }
    public double CalculateLoanEligibility()
    {
        return balance * 0.5; // 50% of balance as loan eligibility
    }

}
class CurrentAccount : BankAccount, ILoanable
{
    private double interestRate;
    public CurrentAccount(int accNum, string name, double rate)
    {
        AccountNumber = accNum;
        HolderName = name;
        interestRate = rate;
        balance = 0;
    }
    public override void CalculateInterest()
    {
        double interest = balance * interestRate / 100;
        Console.WriteLine("Interest for Current Account: " + interest);
    }
    public void ApplyForLoan()
    {
        Console.WriteLine("Applying for loan from Current Account: " + AccountNumber);
    }
    public double CalculateLoanEligibility()
    {
        return balance * 0.7; // 70% of balance as loan eligibility
    }


}
class BankingSystem
{
    static void Main()
    {
        // Polymorphism: parent reference → child object
        BankAccount acc1 = new SavingsAccount(101, "Amit", 4);
        BankAccount acc2 = new CurrentAccount(102, "Rohit", 3);

        acc1.Deposit(10000);
        acc1.CalculateInterest();

        acc2.Deposit(20000);
        acc2.CalculateInterest();

        // Interface usage
        ILoanable loanAcc = (ILoanable)acc1;
        loanAcc.ApplyForLoan();
        Console.WriteLine("Loan Eligibility: " + loanAcc.CalculateLoanEligibility());
    }
}