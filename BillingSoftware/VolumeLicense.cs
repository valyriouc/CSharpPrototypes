using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSoftware
{
    internal class VolumeLicense : Article
    {
        private int count;

        public VolumeLicense(int count, int number, string designation, double price)
            : base(number, designation, price)
        {
            if (count < 10)
            {
                this.count = 10;
            }
            else
            {
                this.count = count;
            }
        }

        public override double GetPreis()
        {
            return price * count - (price * count * 0.10);
        }
    }
}
