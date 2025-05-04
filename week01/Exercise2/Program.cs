using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());
        
        string letter;
        string sign;
        double remainder = grade % 10;

         //Assigning the grade a coresponding letter.
        if (grade < 60)
        {
            letter = "F";
        }
        else if (grade <= 60)
        {
            letter = "D";
        }
        else if (grade <= 70)
        {
            letter = "C";
        }
        else if (grade <= 80)
        {
            letter = "B";
        }
        else
        {
            letter = "A";
        }
        // Adding a sign + or - to the final grade 
        if (remainder >= 7)
        {
            sign = "+";
        }
        else if (remainder > 3)
        {
            sign = "-";
        }
        else 
        {
            sign = " ";
        }

        // Displaying all information
        Console.WriteLine($"Your grade letter is: {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulation you've passed this class.");
        }
        else
        {
            Console.WriteLine("Sorry you've faild try better next time.");
        }



            Console.ReadLine();
    }
}