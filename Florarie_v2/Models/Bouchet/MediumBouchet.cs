namespace Florarie.Models
{
    public class MediumBouchet : Bouchet
    {
        public MediumBouchet()
        {
            Rose = new Rose(10, 6);
            Gladioli = new Gladioli(15, 3);
        }

        public override int GetPriceBouchet()
        {
            return ((Rose.Price * Rose.Quantity) + (Gladioli.Price * Gladioli.Quantity) + Fees) * Quantity;
        }
    }
}
