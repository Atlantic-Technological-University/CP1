﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingTDD.Models;
public enum TransactionType
{
    Deposit,
    Withdrawal,
    Transfer
}
/// <summary>
/// The Transaction class represents a transaction of type <see cref="TransactionType"/> on a Bank
/// account. Transactions can be applied to an <see cref="BankAccount"/>account to determine the 
/// current balance of the account. Each BankAccount contains a list of transactions. 
/// </summary>
public class Transaction
{
    // Properties
    public string AccountNumber { get; }
    public decimal Amount { get; }
    public DateTime Date { get; }
    public TransactionType TransType { get; }
    public string Notes { get; }


    /// <summary>
    /// Transaction objects represent transactions that occur on an account such as withrdrawals, deposits, and transfers.
    /// </summary>
    /// <param name="amount">The transaction amount.</param>
    /// <param name="date">The date and time of the transaction.</param>
    /// <param name="transactionType">The type of transaction made.</param>
    /// <param name="note">Additional notes on the transaction</param>
    public Transaction(string accountNumber, decimal amount, DateTime date, TransactionType transactionType, string note)
    {
        AccountNumber = accountNumber;
        Amount = amount;
        Date = date;
        TransType = transactionType;
        Notes = note;
    }
}

