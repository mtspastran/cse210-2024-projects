using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture("John", 3, 16, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");
        Console.Clear();
        Console.WriteLine("Welcome to the Scripture Memorizer Program! Your scripture today is:");
        scripture.Display(); 
        Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            if (!scripture.HideRandomWord())
            {
                Console.WriteLine("Congratulations!You memorized the scripture!!");
                break;
            }

            Console.Clear();
            scripture.Display();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
        }
    }
}