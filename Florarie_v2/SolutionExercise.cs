using Florarie.Models;
using System.Collections.Generic;
using System.Text;

namespace Florarie_v2
{
    // M-am gandit ca in felul asta se stie cate vanzari s-au facut pana in data curenta.
    // Adaugand vanzarile mereu se va stii cate au fost vandute si cati bani s-au castigat.

    // Am facut cu constructor pentru simplificare. Nu cred ca e necesar sa adaug din consola

    public class SolutionExercise
    {
        public TransactionReports _reports;
        private Payment _paymentBouchet;
        private Payment _paymentFlower;

        private const int _rosePrice = 10;
        private const int _orchidPrice = 30;
        private const int _gladioliPrice = 15;

        public SolutionExercise()
        {
            _reports = new TransactionReports();
            _paymentBouchet = new PaymentBouchet(_reports);
            _paymentFlower = new PaymentFlower(_reports);
        }

        public void CheckoutFunction_MultipleFlowersAtOnce()
        {
            var rose = new Rose(_rosePrice, 20);
            var orchid = new Orchid(_orchidPrice, 10);
            var gladioli = new Gladioli(_gladioliPrice, 5);
            var rose2 = new Rose(_rosePrice, 8);

            var flowers = new List<Flower> { rose, orchid, gladioli, rose2 };
            _paymentFlower.CheckOut(flowers);
        }

        public void CheckoutFunction_SingleFlower()
        {
            var rose = new Rose(_rosePrice, 1);
            _paymentFlower.CheckOut(rose);

            var orchid = new Orchid(_orchidPrice, 10);
            _paymentFlower.CheckOut(orchid);

            var orchid2 = new Orchid(_orchidPrice, 2);
            _paymentFlower.CheckOut(orchid2);
        }

        public void CheckoutFunction_MultipleBouchets()
        {
            var bigBouchet = new BigBouchet();
            var mediumBouchet = new MediumBouchet();
            var smallBouchet = new SmallBouchet();

            mediumBouchet.Rose.Price = 999;
            mediumBouchet.Quantity = 3;

            var bouchets = new List<Bouchet> { bigBouchet, mediumBouchet, smallBouchet };

            _paymentBouchet.CheckOut(bouchets);
        }

        public void CheckoutFunction_SingleBouchet()
        {
            var smallBouchet = new SmallBouchet();
            smallBouchet.Fees = 10;
            _paymentBouchet.CheckOut(smallBouchet);
        }

        public string DisplayStatistics(TransactionReports reports)
        {
            var str = new StringBuilder();

            str.Append("Sales this month flowers\n");
            str.Append("\nFlowerName\t\tQuantity \tEarnings \tDay of month\n");
            str.Append("----------------------------------------------------------------\n");
            foreach (var rep in reports.FlowersSales)
            {
                str.Append($"{rep.Name} \t\t\t{rep.Quantity} \t\t{rep.TotalEarnings} \t\t{rep.CurrentDate}").AppendLine();
            }

            if (reports.BouchetSales.Count > 0)
            {
                str.Append("----------------------------------------------------------------\n");
                str.AppendLine();
                str.Append("Sales this month bouchets\n");
                str.Append("\nBouchetType\t\tQuantity \tEarnings \tDay of month\n");
                str.Append("----------------------------------------------------------------\n");
                foreach (var rep in reports.BouchetSales)
                {
                    str.Append($"{rep.Name} \t\t{rep.Quantity} \t\t{rep.TotalEarnings} \t\t{rep.CurrentDate}").AppendLine();
                }
            }
            if (_paymentFlower.Transactions.Count > 0)
            {
                str.Append("----------------------------------------------------------------\n");
                str.AppendLine();
                str.Append("Individual transactions for flowers \n");
                str.Append("\nFlowerName\t\tQuantity \tCost     \tDay of month\n");
                str.Append("----------------------------------------------------------------\n");
                foreach (var flowerRep in _paymentFlower.Transactions)
                {
                    str.Append($"{flowerRep.Name} \t\t\t{flowerRep.Quantity} \t\t{flowerRep.Cost} \t\t{flowerRep.CurrentDate}").AppendLine();
                }
            }
            if (_paymentBouchet.Transactions.Count > 0)
            {
                str.Append("----------------------------------------------------------------\n");
                str.AppendLine();
                str.Append("Individual transactions for bouchets \n");
                str.Append("\nFlowerName\t\tQuantity \tCost     \tDay of month\n");
                str.Append("----------------------------------------------------------------\n");
                foreach (var bouchetRep in _paymentBouchet.Transactions)
                {
                    str.Append($"{bouchetRep.Name} \t\t{bouchetRep.Quantity} \t\t{bouchetRep.Cost} \t\t{bouchetRep.CurrentDate}").AppendLine();
                }
                str.Append("----------------------------------------------------------------\n");
            }

            return str.ToString();
        }
    }
}
