public class BankAccount
{
    double balance = 0;

    public void Deposit(double amount) => balance += amount;

    public void Withdraw(double amount)
    {
        if (amount > balance)
            throw new InvalidOperationException();
        balance -= amount;
    }

    public double GetBalance() => balance;
}
