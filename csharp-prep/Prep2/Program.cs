using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string gradePercentage = Console.ReadLine();
        int percentage = int.Parse(gradePercentage);

        string letter = "";

        if (percentage < 60)
        {
            letter = "F";
        }

        else if (percentage >= 60)
        {
            letter = "D";
        }

        else if (percentage >= 70)
        {
            letter = "C";
        }

        else if (percentage >= 80)
        {
            letter = "B";
        }

        else if (percentage >= 90)
        {
           letter = "A";
        }

        Console.WriteLine($"Your grade is {letter}.");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! you passed the course!");

        }

        else 
        {
            Console.WriteLine("Try harder!");
        }
    }
}