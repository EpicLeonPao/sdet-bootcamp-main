using NUnit.Framework;
using SdetBootcampDay1.TestObjects;

namespace SdetBootcampDay1.Exercises
{
    [TestFixture]
    public class Exercises02
    {
        /**
         * TODO: rewrite these three tests into a single, parameterized test.
         * You decide if you want to use [TestCase] or [TestCaseSource], but
         * I would like to know why you chose the option you chose afterwards.
         */
        /*[Test]
        public void CreateNewSavingsAccount_Deposit100Withdraw50_BalanceShouldBe50()
        {
            var account = new Account(AccountType.Savings);

            account.Deposit(100);
            account.Withdraw(50);

            Assert.That(account.Balance, Is.EqualTo(50));
        }

        [Test]
        public void CreateNewSavingsAccount_Deposit1000Withdraw1000_BalanceShouldBe0()
        {
            var account = new Account(AccountType.Savings);

            account.Deposit(1000);
            account.Withdraw(1000);

            Assert.That(account.Balance, Is.EqualTo(0));
        }

        [Test]
        public void CreateNewSavingsAccount_Deposit250Withdraw1_BalanceShouldBe249()
        {
            var account = new Account(AccountType.Savings);

            account.Deposit(250);
            account.Withdraw(1);

            Assert.That(account.Balance, Is.EqualTo(249));
        }*/
        [Test, TestCaseSource("DepositWithdrawalTestData")]
        public void DepositWithdrawalTestCaseSource (int dep, int wd, int bal){
            var account = new Account(AccountType.Savings);
            account.Deposit(dep);
            account.Withdraw(wd);
            Assert.That(account.Balance, Is.EqualTo(bal));
        }

        private static IEnumerable<TestCaseData> DepositWithdrawalTestData()
        {
            yield return new TestCaseData(100,50,50).SetName("Deposit 100 Withdraw 50 Balance 50");
            yield return new TestCaseData(1000,1000,0).SetName("Deposit 1000 Withdraw 1000 Balance 0");
            yield return new TestCaseData(250,1,249).SetName("Deposit 250 Withdraw 1 Balance 249");
        }
    }
}
