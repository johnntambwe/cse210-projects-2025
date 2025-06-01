using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment assignment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(assignment1.GetSummary());
        Console.WriteLine();

        MathAssignment math1 = new MathAssignment("Roberto Rodriguez", " Fractions", "7.3", "8-19");
        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeWorkList());
        Console.WriteLine();

        WritingAssignment assig1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assig1.GetSummary());
        Console.WriteLine(assig1.GetWritingInformation());

        Console.ReadLine();
    }
}