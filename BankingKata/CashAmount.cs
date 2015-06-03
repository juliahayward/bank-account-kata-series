using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingKata
{
    public class CashAmount
    {
        private readonly decimal _amount;

        public CashAmount(decimal amount)
        {
            _amount = amount;
        }

        public CashAmount(CashAmount amount)
        {
            _amount = amount._amount;
        }

        public CashAmount Add(CashAmount amount)
        {
            return new CashAmount(_amount + amount._amount);
        }

        public CashAmount Subtract(CashAmount amount)
        {
            return new CashAmount(_amount - amount._amount);
        }

        public override bool Equals(object obj)
        {
            var otherAmount = obj as CashAmount;
            if (otherAmount == null)
                return false;
            return otherAmount._amount == _amount;
        }

        public override int GetHashCode()
        {
            return _amount.GetHashCode();
        }

        public override string ToString()
        {
            return _amount.ToString();
        }
    }
}
