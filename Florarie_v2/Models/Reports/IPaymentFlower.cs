using System.Collections.Generic;

namespace Florarie.Models
{
    public interface IPaymentFlower
    {
        void CheckOut(Flower flower);
        void CheckOut(List<Flower> flowers);
    }
}