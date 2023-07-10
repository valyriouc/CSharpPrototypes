using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidirectional_Relation
{
    internal class Car
    {
        public string Brand { get; }

        public string Color { get; }

        public Person? Owner { get; set; }

        public Car(string brand, string color, Person? owner)
        {
            Brand = brand;
            Color = color;
            Owner = owner;
        }

        public void showOwner()
        {
            Console.WriteLine(Owner is not null ? Owner!.ToString() : "None");
        }

        public override string ToString()
        {
            return $"Brand: {Brand}\nColor: {Color}";
        }
    }
}
