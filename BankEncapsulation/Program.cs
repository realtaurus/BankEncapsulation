using System;

public class BankAccount
{
    private double balance = 0;

    public void Deposit(double amount)
    {
        if (amount < 0)
        {
            Console.WriteLine("No negatives please.");
            return;
        }

        balance += amount;
        Console.WriteLine($"{amount} deposit made.");
    }

    public double GetBalance()
    {
        return balance;
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount();

        while (true)
        {
            Console.WriteLine("Enter a number");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Get Balance");
            Console.WriteLine("3. Exit");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Enter the amount to deposit:");
                    if (double.TryParse(Console.ReadLine(), out double depositAmount))
                    {
                        account.Deposit(depositAmount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;
                case "2":
                    Console.WriteLine($"Your balance is: {account.GetBalance()}");
                    break;
                case "3":
                    Console.WriteLine("Exiting application.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option (1, 2, or 3).");
                    break;
            }

            Console.WriteLine();
        }
    }
}
