﻿using System;

//namespace _02.BankAccountMethods
//{
    class StartUp
    {
        static void Main()
        {
            var acc = new BankAccount()
                          {
                              ID = 1
                          };
            acc.Deposit(15);
            acc.Withdraw(5);

            Console.WriteLine(acc.ToString());
        }
    }
//}
