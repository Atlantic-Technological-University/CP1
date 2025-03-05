// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Net.Http.Headers;
using RecordsDemo;

Console.WriteLine("Welcome to ATU Banking Services");

Account account = new Account(500.0m);
Console.WriteLine("Thank you for opening an account with us.");


Transaction transaction1 = new Transaction();
transaction1.Amount = 200.0m;
transaction1.TransactionType = AccountTransactionType.Deposit;
account.AddTransaction(transaction1);

Console.WriteLine($"The current value of your account is €{account.Balance}");

Transaction transaction2 = new Transaction();
transaction2.Amount = 100.0m;
transaction2.TransactionType = AccountTransactionType.Withdrawal;
account.AddTransaction(transaction2);
Console.WriteLine($"The current value of your account is €{account.Balance}");

