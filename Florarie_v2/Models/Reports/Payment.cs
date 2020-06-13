using System.Collections.Generic;

namespace Florarie.Models
{
    public class Payment
    {
        public List<Transaction> Transactions { get; set; }
        protected ITransactionReports _transactionReports;

        public Payment(ITransactionReports transactionReports)
        {
            _transactionReports = transactionReports;
            Transactions = new List<Transaction>();
        }

        public virtual void CheckOut(Flower flower) { }
        public virtual void CheckOut(List<Flower> flowers) { }

        public virtual void CheckOut(Bouchet bouchet) { }
        public virtual void CheckOut(List<Bouchet> Bouchets) { }
    }
}
