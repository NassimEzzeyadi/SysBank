using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Systeme_bancaire
{
    public class TransactionEventArgs : EventArgs
    {
        public int TransactionId { get; }

        public TransactionEventArgs(int transactionId)
        {
            TransactionId = transactionId;
        }
    }
}
