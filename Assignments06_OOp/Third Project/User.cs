using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments06_OOp.Third_Project
{
    abstract public class User
    {
        public string Name { get; set; }
        public abstract Discount GetDiscount();

    }
    class RegularUser : User
    {
        public RegularUser()
        {
            Name = "Regular";
        }
        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }
    class PerimumUser : User
    {
        public PerimumUser()
        {
            Name = " Perimum";
        }
        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }
    class Guestuser : User
    {
        public Guestuser()
        {
            Name = "Guest";
        }
        public override Discount GetDiscount()
        {
            return null;
        }
    }
}
