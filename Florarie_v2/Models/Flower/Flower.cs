using System.Linq;

namespace Florarie.Models
{
    public class Flower
    {
        public int Price { get; set; }
        public int Quantity { get; set; } = 1;

        public Flower() { }

        public Flower(int price, int quantity)
        {
            Price = price;
            Quantity = quantity;
        }

        public int GetPriceByPiece()
        {
            return Quantity * Price;
        }
    }
}
