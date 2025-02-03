using System;

namespace CSharpCrash.OOP
{
    // Encapsulation

    //! Example 1
    public class Rectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        private double CalculateArea()
        {
            return width * height;
        }

        public void DisplayArea()
        {
            var area = CalculateArea();
            Console.WriteLine("Area of the Rectangle: " + area);
        }


    }

    // Example 2 
    public class BankAccount
    {
        // Private field to store the account balance
        private double Balance = 0;

        // Constructor to initialize the bank account with an initial balance
        // Constructor with an optional parameter that defaults to 0.
        public BankAccount(double initialBalance = 0)
        {
            // Ensure that the initial balance is non-negative.
            if (initialBalance >= 0)
            {
                this.Balance = initialBalance;
            }
            else
            {
                // Optionally, you can handle negative values (e.g., throw an exception).
                Console.WriteLine("Initial balance cannot be negative. Setting to 0.");
                Balance = 0;
            }
        }

        // Getter for balance
        public double GetBalance()
        {
            return Balance;
        }

        // Method to deposit money; ensures that the deposit is positive
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine("Deposited: $" + amount);
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Method to withdraw money; ensures that there are sufficient funds
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine("Withdrew: $" + amount);
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }

        public void DisplayBalance () {
            Console.WriteLine($"My current balance now : {Balance}$");
        }
    }


    // Inheritance
    public class Shape
    {

    }

}