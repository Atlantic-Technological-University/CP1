// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsDemo
{
    public class Account
    {
        public List<Transaction> AccountTransactions
        {
            get;
        }
        public decimal Balance
        {
            get
            {
                decimal currentBalance = OpeningBalance;
                foreach (var transaction in AccountTransactions)
                {
                    if (transaction.TransactionType == AccountTransactionType.Deposit)
                    {
                        currentBalance += transaction.Amount;
                    }
                    else
                    {
                        currentBalance -= transaction.Amount;
                    }
                }
                return currentBalance;
            }
        }
        public decimal OpeningBalance { get; init; }

        public Account()
        {
            OpeningBalance = 0.0m;
            AccountTransactions = new List<Transaction>();
        }

        public Account(decimal initialDeposit)
        {
            OpeningBalance = initialDeposit;
            AccountTransactions = new List<Transaction>();
        }

        public decimal AddTransaction(Transaction transaction)
        {
            AccountTransactions.Add(transaction);
            return Balance;
        }


    }
}
