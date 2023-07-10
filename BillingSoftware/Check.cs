using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillingSoftware
{
    internal class Check
    {
        private Customer customer;
        private List<Article> articleList;

        public Check(Customer customer)
        {
            articleList = new List<Article>();
            this.customer = customer;
        }

        public double GetTotalAmount()
        {
            double total = 0;
            foreach (Article article in articleList)
            {
                total += article.GetPreis();
            }
            return total;
        }

        public void SetArticle(Article article)
        {
            articleList.Add(article);
        }

        public void Print()
        {
            Console.WriteLine("    Check:    ");
            Console.WriteLine("--------------");
            Console.WriteLine("Customer: ");
            Console.WriteLine($"{customer.GetName()}");
            Console.WriteLine($"{customer.GetCustomerNumber()}");
            Console.WriteLine($"{customer.GetStreet()}");
            Console.WriteLine($"{customer.GetZipCode()}");
            Console.WriteLine($"{customer.GetStreet()}");
            Console.WriteLine();
            foreach (Article article in articleList)
            {
                Console.WriteLine($"{article.GetDesignation()}: {article.GetPreis()}€");
            }
            Console.WriteLine($"Total: {this.GetTotalAmount()}");
        }
    }
}
