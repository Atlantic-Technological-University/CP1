﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordsDemo
{
    public record Transaction
    {
        public decimal Amount { get; set; }
        public AccountTransactionType TransactionType { get; set; }
    }
    public enum AccountTransactionType
    {
    Deposit,
    Withdrawal

    }

}
