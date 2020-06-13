using System;
using System.Collections.Generic;

namespace Florarie.Models
{
    public class PaymentBouchet : Payment, IPaymentBouchet
    {
        public PaymentBouchet(ITransactionReports transactionReports)
            : base(transactionReports) { }

        public override void CheckOut(Bouchet bouchet)
        {
            GetPaymentBouchet(bouchet);
        }

        public override void CheckOut(List<Bouchet> Bouchets)
        {
            foreach (var bouchet in Bouchets)
            {
                GetPaymentBouchet(bouchet);
            }
        }

        private void GetPaymentBouchet(Bouchet bouchet)
        {
            var cost = bouchet.GetPriceBouchet();
            _transactionReports.StoreStatisticsBouchet(bouchet, cost);
            SaveTransactionBouchet(bouchet, cost);
        }

        private void SaveTransactionBouchet(Bouchet bouchet, int cost)
        {
            Transactions.Add(new Transaction
            {
                Name = bouchet.GetType().Name,
                Quantity = bouchet.Quantity,
                Cost = cost,
                CurrentDate = DateTime.Now.ToShortDateString()
            });
        }
    }
}
