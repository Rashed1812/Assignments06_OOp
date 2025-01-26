using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments06_OOp.Third_Project
{
    abstract public class Discount
    {
        public string Name { get; set; }
        public abstract decimal CalculateDiscount(decimal price, int quantity);
    }
    class PercentageDiscount : Discount
    {
        private readonly decimal Percentage;
        public PercentageDiscount(int _percentage)
        {
            Percentage = _percentage;
            Name = "Percentage";

        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (Percentage/100);
        }
    }
    class FlatDiscount : Discount
    {
        private readonly decimal flatamount;
        public FlatDiscount(int _flatamount)
        {
            flatamount = _flatamount;
            Name = "Flatamount";
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return flatamount * (quantity > 0 ? 1 : 0);
        }
    }
    class Buyonegetone : Discount
    {
        public Buyonegetone()
        {
            Name = "Buy One Get One";
        }
        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity > 1)
            {
                return (price / 2) * (quantity / 2);
            }
            return 0;
        }
    }
}
