using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Has_Relation
{
    internal class Person
    {
        public string Name { get; }

        public int Age { get; }

        public Car firstCar { get; }

        public Car? secondCar { get; }

        public Person(string name, int age, Car firstCar, Car? secondCar)
        {
            Name = name;
            Age = age;
            this.firstCar = firstCar;
            this.secondCar = secondCar;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nCar1:\n{firstCar.ToString()}\nCar2:\n{(secondCar is not null ? secondCar!.ToString() : "None")}";
        }
    }
}
