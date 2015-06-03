using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BankingKata
{
    public class Accounts : Dictionary<AccountCode, Account>
    {
        public void Add(AccountCode code, CashAmount amount)
        {
            Add(code, new Account(code, amount));
        }

        public void MakeDeposit(AccountCode accountCode, CashAmount amount)
        {
            var account = this[accountCode];
            account.Deposit(amount);
        }

        public void MakeWithdrawl(AccountCode accountCode, CashAmount amount)
        {
            var account = this[accountCode];
            account.Withdraw(amount);
        }

        public CashAmount RetrieveBalance(AccountCode accountCode)
        {
            var account = this[accountCode];
            var balance = account.RetrieveBalance();
            return balance;
        }
    }
}