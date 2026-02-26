
using System.ComponentModel.DataAnnotations;

class Account
{
    public float balance;
    public string owner { get; set; }

    public float Balance
    {
        get { return balance; }
        set
        {
            if (value >= 0)
            {
                balance += value;
            }
        }
    }

    public Account(string owner, float initialBalance)
    {
        this.owner = owner;
        balance = initialBalance;
    }

    public void Show()
    {
        Console.WriteLine($"Owner: {owner}, Balance: {balance}");
    }

    public void Deposit(float amount)
    {
        if (amount > 0)
        {
            balance += amount;
        }
    }

    public float GetBalance()
    {
        return balance;
    }

    public bool Withdraw(float amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            return true;
        }
        return false;
    }

    public bool Transfer(Account other, float amount)
    {
        if (amount <= balance)
        {
            balance -= amount;
            other.Deposit(amount);
            return true;
        }
        return false;
    }

    public static void Value(int? a)
    {
        if (a.HasValue)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine("Parameter has no value");
        }
    }




}

