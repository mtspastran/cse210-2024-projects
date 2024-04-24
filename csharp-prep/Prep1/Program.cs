using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is yoru first name?");
        string first = Console.ReadLine();

        Console.Write("What is your last name?");
        string last = Console.ReadLine();

        Console.WriteLine($"Yor name is {last}, {first} {last}.");
    }
}