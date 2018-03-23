using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowDemo
{
    public interface ITransactionAuditor
    {
        void AuditTransaction(CreditTransaction transaction);
    }
    
}
