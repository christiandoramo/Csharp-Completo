using System.Globalization;
using System;

namespace _11ex01.src.Entities
{
    class Account
    {
        private int Number { get; set; }
        private string Holder { get; set; }
        private double Balance { get; set; }
        private double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {

            if (balance < 0)
                throw new DomainExceptions("Account Construct error: Balance must be bigger than 0");
            if (withdrawLimit <= 0)
                throw new DomainExceptions("Account Construct error: WithdrawLimit must be bigger than 0");
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0) throw new DomainExceptions("Deposit error: Balance must be bigger than 0");
            Balance += amount;
            Console.WriteLine(this);
        }

        public void Withdraw(double amount)
        {
            if (amount >= Balance)
                throw new DomainExceptions("Withdraw error: Not enough balance");

            if (amount > WithdrawLimit)
                throw new DomainExceptions("Withdraw error: The amount exceeds withdraw limit");


            Balance -= amount;
            Console.WriteLine(this);
        }

        public override string ToString()
        {
            return $"{Number}\n{Holder}\nNew Balance: {Balance.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
