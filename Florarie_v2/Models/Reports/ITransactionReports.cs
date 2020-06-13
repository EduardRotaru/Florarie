using System.Collections.Generic;

namespace Florarie.Models
{
    public interface ITransactionReports
    {
        List<Transaction> BouchetSales { get; set; }
        List<Transaction> FlowersSales { get; set; }

        void StoreStatisticsBouchet(Bouchet bouchet, int cost);
        void StoreStatisticsFlower(Flower flower, int cost);
    }
}