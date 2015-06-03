namespace BankingKata
{
    public class Account
    {
        private AccountCode _code;
        private CashAmount _balance;

        public Account(AccountCode code, CashAmount initialBalance)
        {
            _code = code;
            _balance = initialBalance;
        }

        public void Deposit(CashAmount amount)
        {
            _balance = _balance.Add(amount);
        }

        public void Withdraw(CashAmount amount)
        {

            // This is a super bank, I can take out as much as I Like :)
            _balance = _balance.Subtract(amount);
        }

        public CashAmount RetrieveBalance()
        {
            return new CashAmount(_balance);
        }
    }
}