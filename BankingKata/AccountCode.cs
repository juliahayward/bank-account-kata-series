using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingKata
{
    public class AccountCode
    {
        private readonly string _code;

        public AccountCode(string code)
        {
            _code = code;
        }

        public override bool Equals(object obj)
        {
            var otherCode = obj as AccountCode;
            if (otherCode == null) 
                return false;
            return otherCode._code == _code;
        }

        public override int GetHashCode()
        {
            return _code.GetHashCode();
        }

        public override string ToString()
        {
            return _code.ToString();
        }
    }
}
