using System;
using System.Collections.Generic;

namespace Florarie.Models
{
    public class PaymentFlower : Payment, IPaymentFlower
    {
        public PaymentFlower(ITransactionReports transactionReports)
            : base(transactionReports) { }

        public override void CheckOut(Flower flower)
        {
            GetPaymentFlower(flower);
        }

        public override void CheckOut(List<Flower> flowers)
        {
            foreach (var flower in flowers)
            {
                GetPaymentFlower(flower);
            }
        }

        private void GetPaymentFlower(Flower flower)
        {
            var cost = flower.GetPriceByPiece();
            _transactionReports.StoreStatisticsFlower(flower, cost);
            SaveTransactionFlower(flower, cost);
        }

        private void SaveTransactionFlower(Flower flower, int cost)
        {
            Transactions.Add(new Transaction
            {
                Name = flower.GetType().Name,
                Quantity = flower.Quantity,
                Cost = cost,
                CurrentDate = DateTime.Now.ToShortDateString()
            });
        }
    }
}
