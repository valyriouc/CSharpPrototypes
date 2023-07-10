using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSoftware
{
    internal abstract class Article
    {
        private int number;
        private string designation;

        protected double price;

        public Article(int number, string designation, double price)
        {
            this.number = number;
            this.designation = designation;
            this.price = price;
        }

        public int GetNumber()
        {
            return number;
        }

        public string GetDesignation()
        {
            return designation;
        }

        public abstract double GetPreis();
    }
}
