namespace Florarie.Models
{
    public class SmallBouchet : Bouchet
    {
        public SmallBouchet()
        {
            Rose = new Rose(10, 5);
        }

        public override int GetPriceBouchet()
        {
            return ((Rose.Price * Rose.Quantity) + Fees) * Quantity;
        }
    }
}
