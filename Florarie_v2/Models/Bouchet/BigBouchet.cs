namespace Florarie.Models
{
    public class BigBouchet : Bouchet
    {
        public BigBouchet()
        {
            Rose = new Rose(10, 20);
            Orchid = new Orchid(30, 10);
            Gladioli = new Gladioli(15, 5);
        }

        public override int GetPriceBouchet()
        {
            return ((Rose.Price * Rose.Quantity) + (Orchid.Price * Orchid.Quantity) + (Gladioli.Price * Gladioli.Quantity) + Fees) * Quantity;
        }
    }
}
