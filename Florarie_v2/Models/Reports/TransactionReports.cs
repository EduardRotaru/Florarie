using System.Collections.Generic;
using System.Linq;

namespace Florarie.Models
{
    public class TransactionReports : ITransactionReports
    {
        public List<Transaction> FlowersSales { get; set; }
        public List<Transaction> BouchetSales { get; set; }

        public TransactionReports()
        {
            FlowersSales = new List<Transaction>();
            BouchetSales = new List<Transaction>();
        }

        public void StoreStatisticsFlower(Flower flower, int cost)
        {
            var tran = new Transaction();

            var flowerName = flower.GetType().Name;
            var fs = FlowersSales.FirstOrDefault(f => f.Name == flowerName);

            if (fs == null)
            {
                tran.Name = flowerName;
                tran.Quantity = flower.Quantity;
                tran.TotalEarnings = cost;

                FlowersSales.Add(tran);
            }
            else
            {
                fs.Quantity += flower.Quantity;
                fs.TotalEarnings += cost;
            }
        }

        public void StoreStatisticsBouchet(Bouchet bouchet, int cost)
        {
            var tran = new Transaction();

            var bouchetName = bouchet.GetType().Name;
            var bh = BouchetSales.FirstOrDefault(b => b.Name == bouchetName);

            if (bh == null)
            {
                tran.Name = bouchetName;
                tran.Quantity = bouchet.Quantity;
                tran.TotalEarnings = cost;

                BouchetSales.Add(tran);
            }
            else
            {
                bh.Quantity += bouchet.Quantity;
                bh.TotalEarnings += cost;
            }
        }
    }
}
