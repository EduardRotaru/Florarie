namespace Florarie.Models
{
    // As fi putut sa fac cu method overloading dar mi se pare inflexibil daca tipul de buchet se schimba.
    // Am ales o clasa abstracta pentru ca buchetul e ceva geneal si nu are nevoie de implementatare.

    public abstract class Bouchet
    {
        public Flower Rose { get; set; }
        public Flower Orchid { get; set; }
        public Flower Gladioli { get; set; }

        public int Fees { get; set; } = 2;
        public int Quantity { get; set; } = 1;

        public abstract int GetPriceBouchet();
    }
}
