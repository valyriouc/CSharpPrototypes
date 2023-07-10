using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Has_Relation
{
    /// <summary>
    /// This class represents a simple car 
    /// </summary>
    internal class Car
    {
        private int instanceCounter = 0;

        public int Id { get; }

        public string Brand { get; }

        public string Color { get; }

        public Car(string brand, string color)
        {
            Id = ++instanceCounter;
            Brand = brand;
            Color = color;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nBrand: {Brand}\nColor: {Color}";
        }
    }
}
