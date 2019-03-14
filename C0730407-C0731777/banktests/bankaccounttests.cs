using System;
using C0730407_C0731777;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace banktests
{
    [TestClass]

    public class bankaccounttests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdatesBalance()
        {
            //Arrange
            double beginningBalance = 11.49;
            double debitAmount = 4.55;
            double expected = 7.44;
            BankAccount account = new BankAccount("Mr. bryan walton", beginningBalance);
            //Act
            account.Debit(debitAmount);
            //Assert
            double actual = account.Balance;
            Assert.AreEqual(expected, actual, 0.001, "Account not debited correctly");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WithAmountIsLessThanZero_ShouldThrowArguementOutOfRange()
        {
            //Arrange
            double beginningBalance = 11.99;
            double debitAmount = -100.00;
            BankAccount account = new BankAccount("Mr. bryan walton", beginningBalance);
            //Act
            account.Debit(debitAmount);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Debit_WhenAmountIsMoreThanBalanceThanZero_ShouldThrowArguementOutOfRange()
        {
            //Arrange
            double beginningBalance = 11.99;
            double debitAmount = 100.00;
            BankAccount account = new BankAccount("Mr. bryan walton", beginningBalance);
            //Act
            account.Debit(debitAmount);

        }
    }
}
