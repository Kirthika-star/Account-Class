using System.Runtime.CompilerServices;

namespace Capstone;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Testing Account1");
        Account account1 = new Account("Bob", 100);
        account1.Show();

        Console.WriteLine("About to withdraw 150 from Account1");
        bool result = account1.Withdraw(150);
        if (!result)
        {
            Console.WriteLine("Insufficient funds, current account info:");
            account1.Show();
        }

        Console.WriteLine("Depositing 200 into Account1, new status:");
        account1.Deposit(200);
        account1.Show();

        Console.WriteLine("About to withdraw 150 from Account1");
        result = account1.Withdraw(150);
        if (result)
        {
            Console.WriteLine("Success, new status:");
            account1.Show();
        }

        Console.WriteLine("Creating Account2");
        Account account2 = new Account("Mary", 100);
        account2.Show();

        Console.WriteLine("Transferring 50 from Bob to Mary");
        result = account1.Transfer(account2, 50);
        if (result)
        {
            Console.WriteLine("Success, new status:");
            account1.Show();
            account2.Show();
        }
        else
        {
            Console.WriteLine("Insufficient funds, current account info:");
            account1.Show();
            account2.Show();
        }

        account1.Balance = -200;
        Console.WriteLine($"Account owner: {account1.owner}");
        account1.Show();

        int? x1;
        int? x2;

        x1 = 20;
        x2 = null;

        Console.WriteLine(x1);
        Console.WriteLine(x2);
        Console.WriteLine("It works!!");

        string? s = null;

        Account? a = null;

        /*Account a1 = new Account("bob", 100);
        Account a2 = new Account("fred", 200);
        a1 = a2;
        a1.Show();
        a2.Show();
        a1.Withdraw(10);
        a2.Withdraw(20);
        a1.Show();
        a2.Show();
        int x = 5, y = 10;
        x = y;
        x++;
        Console.WriteLine(x);
        Console.WriteLine(y);*/

        Account a1 = new Account("bob", 100);
        int totalAssets = 1000;
        doIt(a1, totalAssets);
        Console.WriteLine("after doIt:");
        a1.Show();
        Console.WriteLine($"total assets is now {totalAssets}"); }
        public static void doIt(Account a, int total)
        {
            a.Withdraw(50);
            total--;
        }



    }

