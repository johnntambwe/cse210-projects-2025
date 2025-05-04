using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        
        List<int> numbers = new List<int>();
        int endNumber = 0;
        int response = -1;
        double sum = 0;
        double  average = 0;
        int maxNumber = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        while (response != endNumber)

        {
            Console.Write("Enter number: ");
            response = int.Parse(Console.ReadLine());
            numbers.Add(response);

           

        }
        //Sum 
        foreach (int number in numbers)
        {
            sum += number;
        }

        //Avarage
        average = sum / (numbers.Count - 1);

        //Max
        foreach (int number in numbers)
        {
            if (maxNumber < number)
            {
                maxNumber = number;
            }

        }


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");  // or 
        //Console.WriteLine($"The average is: {sum / (numbers.Count - 1)}");
        Console.WriteLine($"The largest number is: {maxNumber}");

        Console.ReadLine();

    }
}