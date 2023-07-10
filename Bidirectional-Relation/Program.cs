using System;

using Bidirectional_Relation;

internal class Program
{
    public static void Main(string[] args)
    {
        Car car1 = new Car("VW", "Black", null);

        Console.WriteLine(car1.ToString());
        car1.showOwner();

        Person person = new Person("Tom Maier", 39, car1);

        car1.Owner = person;

        car1.showOwner();
        Console.WriteLine(person.ToString());
    }
}