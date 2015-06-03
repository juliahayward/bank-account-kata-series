using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankingKata;
using NUnit.Framework;

namespace BankingKataTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void MakeDeposit()
        {
            var foo = new AccountCode("foo");
            var bar = new AccountCode("bar");
            var zero = new CashAmount(0m);
            var accounts = new Accounts();
            accounts.Add(foo, zero);
            accounts.Add(bar, zero);

            var amount = new CashAmount(12.5m);

            accounts.MakeDeposit(foo, amount);

            var fooBalance = accounts.RetrieveBalance(foo);
            Assert.AreEqual(fooBalance, amount);
            var barBalance = accounts.RetrieveBalance(bar);
            Assert.AreEqual(barBalance, zero);
        }

        [Test]
        public void MakeDeposit_ToUnknownAccount_Throws()
        {
            var accounts = new Accounts();
            var amount = new CashAmount(12.5m);
            var foo = new AccountCode("foo");

            Assert.Throws<KeyNotFoundException>(() => accounts.MakeDeposit(foo, amount));
        }

        [Test]
        public void MakeWithdrawl()
        {
            var foo = new AccountCode("foo");
            var bar = new AccountCode("bar");
            var accounts = new Accounts();
            accounts.Add(foo, new CashAmount(25m));
            accounts.Add(bar, new CashAmount(110m));

            var amount = new CashAmount(10m);

            accounts.MakeWithdrawl(foo, amount);

            var fooBalance = accounts.RetrieveBalance(foo);
            Assert.AreEqual(fooBalance, new CashAmount(15m));
            var barBalance = accounts.RetrieveBalance(bar);
            Assert.AreEqual(barBalance, new CashAmount(110m));
        }

        [Test]
        public void MakeWithdrawl_FromUnknownAccount_Throws()
        {
            var accounts = new Accounts();
            var amount = new CashAmount(12.5m);
            var foo = new AccountCode("foo");

            Assert.Throws<KeyNotFoundException>(() => accounts.MakeWithdrawl(foo, amount));
        }
    }
}
