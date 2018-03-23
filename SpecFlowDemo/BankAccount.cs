using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDemo
{
    public class BankAccount
    {
        private readonly ITransactionAuditor auditor;

        public BankAccount(ITransactionAuditor auditor)
        {
            this.auditor = auditor;
        }

        public void Deposit(CreditTransaction creditTransaction)
        {
            // one test should fail, we're not calling the auditor
        }
    }
}
