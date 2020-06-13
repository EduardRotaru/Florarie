using System.Collections.Generic;

namespace Florarie.Models
{
    public interface IPaymentBouchet
    {
        void CheckOut(Bouchet bouchet);
        void CheckOut(List<Bouchet> Bouchets);
    }
}