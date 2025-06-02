using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        string userOption = " ";
        while (userOption != "4")
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine(" 1. Start Breathing Activity \n 2. Start Reflecting Activity \n 3. Start Listing Activity \n 4. Quit");
            Console.Write("Select a choice from the menu: ");
            userOption = Console.ReadLine().ToLower();
            switch (userOption) 
            {
                case "1":
                    Console.Clear();
                    BreathingActivity breathing1 = new BreathingActivity("Breathing Activity",
                   "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    breathing1.Run();
                    break;

                case "2":
                    Console.Clear();
                    //Readline question from Prompts.txt;
                    string prompts = " ";
                    try
                    {
                        string[] readText = File.ReadAllLines("C:\\Users\\John Ntambwe\\Documents\\Byu_2025\\term3_may_june" +
                            "\\programming_with_classes_cse210_002\\cse210-projects-2025\\week05\\Mindfulness\\Prompts.txt");
                        foreach (string line in readText)
                        {
                            prompts += line + " ";
                        }
                    }
                    catch (System.IO.FileNotFoundException e)
                    {
                        Console.WriteLine(" Check that you've typed the correct file and \n Make sure to save the file first before loading it.");
                    }

                    //Readline question from Question.txt.
                    string questions = " ";
                    try
                    {
                        string[] readText = File.ReadAllLines("C:\\Users\\John Ntambwe\\Documents\\Byu_2025\\term3_may_june" +
                            "\\programming_with_classes_cse210_002\\cse210-projects-2025\\week05\\Mindfulness\\Questions.txt");
                        foreach (string line in readText)
                        {
                            questions += line + " ";
                        }
                    }
                    catch (System.IO.FileNotFoundException e)
                    {
                        Console.WriteLine(" Check that you've typed the correct file and \n Make sure to save the file first before loading it.");
                    }

                    ReflectingActivity reflecting1 = new ReflectingActivity("Reflection Activity", 
                        "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
                        "This will help you recognize the power you have and how you can use it in other aspects of your life.",prompts, questions);
                   
                    reflecting1.Run();
                    break;

                case "3":
                    Console.Clear();
                    string prompts2 = "Who are people that you appreciate?|What are personal strengths of yours?|" +
                        "Who are people that you have helped this week?|When have you felt the Holy Ghost this month?|Who are some of your personal heroes? ";

                    ListingActivity listing1 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life " +
                        "by having you list as many things as you can in a certain area.",0,prompts2);
                    listing1.Run();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Choose between 1 - 3 to start a new activity or 4 to quit.");
                    Console.WriteLine(" ");
                    break;
            }
               

         }

        


       
        //Console.WriteLine("Well done.");

        //Console.Write("Download in progress");

      

    }
}