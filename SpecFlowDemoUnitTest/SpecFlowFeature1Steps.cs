using Moq;
using SpecFlowDemo;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowDemoUnitTest
{
    /// <summary>
    /// Givens - Our preconditions
    /// Whens - Mutation of our test scenario
    /// Thens - Assertion of our post conditions
    /// </summary>
    [Binding]   
    public class SpecFlowFeature1Steps
    {
        BankAccount account;
        CreditTransaction creditTransaction; // could be stored in ScenarioContext.Current as well.  
        Mock<ITransactionAuditor> auditorMock;

        public SpecFlowFeature1Steps()
        {
            auditorMock = new Mock<ITransactionAuditor>();
            creditTransaction = new CreditTransaction();
            account = new BankAccount(auditorMock.Object);
        }

        [Given(@"I have a bank account")]
        public void GivenIHaveABankAccount()
        {
            /*
            Nothing to do in this example.  Givens are preconditions, 
            our test is already initialized and the standard context 
            serves our purposes in this case.
            */
        }
        
        [When(@"I attempt to deposit over (.*) dollars")]
        public void WhenIAttemptToDepositOverDollars(Decimal p0)
        {
            creditTransaction.Amount = p0;
        }
        
        [When(@"I attempt to deposit a reasonable amount of money")]
        public void WhenIAttemptToDepositAReasonableAmountOfMoney()
        {
            creditTransaction.Amount = 10.0m;
        }
        
        [Then(@"the deposit should be flagged for review")]
        public void ThenTheDepositShouldBeFlaggedForReview()
        {
            auditorMock.Verify(m => m.AuditTransaction(creditTransaction), Times.Once);
        }
        
        [Then(@"the deposit should be made")]
        public void ThenTheDepositShouldBeMade()
        {
            auditorMock.Verify(m => m.AuditTransaction(creditTransaction), Times.Never);
        }
    }
}
