using System;

// Contract for loan processing
interface ILoanProcessor
{
    bool ProcessApproval();
    double GetMonthlyInstallment();
}

// Stores customer details
class CustomerProfile
{
    private string fullName;
    private int score;
    private double monthlyIncome;
    private double requestedAmount;

    public CustomerProfile(string fullName, int score, double monthlyIncome, double requestedAmount)
    {
        this.fullName = fullName;
        this.score = score;
        this.monthlyIncome = monthlyIncome;
        this.requestedAmount = requestedAmount;
    }

    public string GetFullName()
    {
        return fullName;
    }
    public int GetScore()
    {
        return score;
    }

    public double GetMonthlyIncome()
    {
        return monthlyIncome;
    }

    public double GetRequestedAmount()
    {
        return requestedAmount;
    }
}


// Abstract base for all loans
abstract class LoanBase : ILoanProcessor
{
    protected CustomerProfile customer;
    protected int duration;
    protected double rate;
    protected bool status;

    protected LoanBase(CustomerProfile customer, int duration, double rate)
    {
        this.customer = customer;
        this.duration = duration;
        this.rate = rate;
        this.status = false;
    }

    // Common eligibility logic
    protected bool IsEligible(double incomeMultiplier)
    {
        double minIncome = (customer.GetRequestedAmount() / duration) * incomeMultiplier;

        if (customer.GetScore() >= 650 && customer.GetMonthlyIncome() >= minIncome)
        {
            return true;
        }
        return false;
    }

    // EMI calculation logic
    protected double CalculateBaseEMI()
    {
        double principal = customer.GetRequestedAmount();
        double monthlyRate = rate / 12 / 100;
        int months = duration;

        double emi = (principal * monthlyRate * Math.Pow(1 + monthlyRate, months)) /
                     (Math.Pow(1 + monthlyRate, months) - 1);

        return emi;
    }

    public abstract bool ProcessApproval();
    public abstract double GetMonthlyInstallment();
}

// Personal Loan
class InstantLoan : LoanBase
{
    public InstantLoan(CustomerProfile customer, int duration, double rate)
        : base(customer, duration, rate)
    {
    }

    public override bool ProcessApproval()
    {
        if (IsEligible(2))
        {
            status = true;
        }
        return status;
    }

    public override double GetMonthlyInstallment()
    {
        if (status)
        {
            return CalculateBaseEMI();
        }
        return 0;
    }
}

// Home Loan
class PropertyLoan : LoanBase
{
    public PropertyLoan(CustomerProfile customer, int duration, double rate)
        : base(customer, duration, rate)
    {
    }

    public override bool ProcessApproval()
    {
        if (IsEligible(2.5) && customer.GetMonthlyIncome() >= 50000)
        {
            status = true;
        }
        return status;
    }

    public override double GetMonthlyInstallment()
    {
        if (status)
        {
            return CalculateBaseEMI() * 0.95;
        }
        return 0;
    }
}

// Vehicle Loan
class VehicleLoan : LoanBase
{
    public VehicleLoan(CustomerProfile customer, int duration, double rate)
        : base(customer, duration, rate)
    {
    }

    public override bool ProcessApproval()
    {
        if (IsEligible(2.2) && customer.GetMonthlyIncome() >= 30000)
        {
            status = true;
        }
        return status;
    }

    public override double GetMonthlyInstallment()
    {
        if (status)
        {
            return CalculateBaseEMI() * 1.03;
        }
        return 0;
    }
}

// Driver Program
class LoanSystem
{
    static void Main()
    {
        CustomerProfile c1 = new CustomerProfile("ujjawal verma", 765, 60700, 500900);
        CustomerProfile c2 = new CustomerProfile("harsh gupta", 690, 8800, 290000);

        LoanBase loan1 = new InstantLoan(c1, 24, 12);
        LoanBase loan2 = new PropertyLoan(c1, 120, 8);
        LoanBase loan3 = new VehicleLoan(c2, 36, 10);

        Console.WriteLine("Instant Loan Approved: " + loan1.ProcessApproval());
        Console.WriteLine("Instant Loan EMI: " + loan1.GetMonthlyInstallment());

        Console.WriteLine("Property Loan Approved: " + loan2.ProcessApproval());
        Console.WriteLine("Property Loan EMI: " + loan2.GetMonthlyInstallment());

        Console.WriteLine("Vehicle Loan Approved: " + loan3.ProcessApproval());
        Console.WriteLine("Vehicle Loan EMI: " + loan3.GetMonthlyInstallment());
    }
}
