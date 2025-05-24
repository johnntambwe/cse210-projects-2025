using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        Reference reference = new Reference("1Nephi", 4, 6);       
        Scripture scripture = new Scripture(reference, "And I was led by the Spirit not knowing beforehand the things which I should do.");
        
        while (true)
        {
            Console.Clear();
            scripture.GetDisplayText();
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine();
                Console.WriteLine("Great job! You've memorized the scripture!");
                Console.ReadLine();
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit  to exit.");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "quit")
                break;
            scripture.HideRandomWords(2);
        }
        

    }
}