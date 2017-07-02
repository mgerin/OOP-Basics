using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.BankAccountTest
{
    class BankAccount
    {
        private int id;
        private double balance;

        public int ID { get; set; }

        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (this.Balance - amount < 0)
            {
                Console.WriteLine("Insufficient balance");
            }
            else
            {
                this.Balance -= amount;
            }
        }

        public override string ToString()
        {
            return $"Account ID{this.ID}, balance {this.Balance:F2}";
        }
    }
}
