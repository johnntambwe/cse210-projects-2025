using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal Program!");
        Journal1 myJournal = new Journal1();
        string response = " ";
        while (response != "5") 
        {
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine(" 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
            Console.Write("What would you like to do?  ");
            response = Console.ReadLine().ToLower();

            switch (response)
            {
                case "1":
                    string prompt = new Prompts().GetPrompt();
                    Console.WriteLine(prompt);
                    string entryText = Console.ReadLine();
                    Entry myEntry = new Entry(prompt, entryText);

                    myJournal.AddEntry(myEntry);

                    //string name = myJournal._name;
                    //Console.WriteLine(name);
                    break;
                case "2":
                    myJournal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Enter the file: ");
                    string fileName = Console.ReadLine();
                    myJournal.LoadFromFile(fileName);
                    break;
                case "4":
                    Console.Write("Enter the file: ");
                    fileName = Console.ReadLine();
                   myJournal.SaveToFile(fileName);
                    break;
                case "5":
                    Console.WriteLine("Thank you for using the Journal see you soon!");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Choose between 1 - 4 to use the application.");
                    break;

            }
            
        }
        
        

    }
}