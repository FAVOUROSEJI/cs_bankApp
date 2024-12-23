﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week12_Lab01_BankApp
{
    internal class TransactionEventArgs : LoginEventArgs
    {
        public decimal Amount {  get;  }

        public TransactionEventArgs(string name, decimal amount, bool success ) : base(name, success) { 
            this.Amount = amount;
        }
    }
}
