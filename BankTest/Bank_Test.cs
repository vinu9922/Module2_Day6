using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Bank;
namespace BankTest
{
    [TestFixture]
    public class Bank_Test
    {
        BankApp obj_bank_app;
        [SetUp]
        public void Setup()
        {
            obj_bank_app = new BankApp();
        }
        [TearDown]
        public void clean()
        {
            obj_bank_app = null;
        }
        [Test]
        public void DepositTest()
        {
            double Expected = 11000;
            double Actual = obj_bank_app.Deposit(3000,8000);

            Assert.AreEqual(Expected, Actual);
        }
        [Test]
        public void WithDrawTest()
        {
            double Expected = 5000;
            double Actual = obj_bank_app.Withdraw(3000, 8000);

            Assert.AreEqual(Expected, Actual);
        }
    }
}
