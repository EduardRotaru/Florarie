using System;

namespace Florarie.Models
{
    public class Transaction
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Cost { get; set; }
        public int TotalEarnings { get; set; }
        public string CurrentDate { get; set; } = DateTime.Now.ToShortDateString();
    }
}
