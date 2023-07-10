using System;

using Has_Relation;

internal class Program
{
    public static void Main(string[] args)
    {
        Person person1 = new Person("Tom Maier", 39, new Car("VW", "Black"), null);
        Console.WriteLine(person1.ToString());

    }
}