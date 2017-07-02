using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace _01.BankAccount
//{
    class StartUp
    {
        static void Main()
        {
            var acc = new BankAccount()
            {
                ID = 1,
                Balance = 15
            };

            Console.WriteLine($"Account {acc.ID}, balance {acc.Balance}");
        }
    }
//}
