using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSoftware
{
    internal class SingleLicense : Article
    {

        public SingleLicense(int number, string designation, double price)
            : base(number, designation, price)
        {

        }

        public override double GetPreis()
        {
            return price + price * 0.10;
        }
    }
}
