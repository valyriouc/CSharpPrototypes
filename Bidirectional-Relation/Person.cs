using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bidirectional_Relation
{
    internal class Person
    {
        public string Name { get; }

        public int Age { get; }

        public Car Car { get; }

        public Person(string name, int age, Car car)
        {
            Name = name;
            Age = age;
            Car = car;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nCar: {Car.ToString()}";
        }
    }
}
