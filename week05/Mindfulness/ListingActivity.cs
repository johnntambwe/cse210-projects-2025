using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    //Attributes
    private int _count;
    private List<string> _prompts = new List<string>();

    //Constructors
    public ListingActivity() : base()
    { 
        _count = 0;
        _prompts = new List<string>();
    }
    public ListingActivity(string name, string description, int count, string prompts) : base(name, description)
    { 
        _count = count;
        foreach(string prompt in prompts.Split("|"))
            _prompts.Add(prompt);
    }

    //Getters and Setters
    public int GetCount()
    { 
        return _count;
    }
    public List<string> GetPrompts()
    {
        return _prompts;
    }

    //Methods
    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = Convert.ToInt32(Console.ReadLine());
        _duration = duration;
        Console.Clear();
        Console.WriteLine("Getting ready...");
        ShowSpinner();

        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown();
        Console.WriteLine("\n");
        DateTime now = DateTime.Now;
        DateTime end = now.AddSeconds(_duration);

        List<string> userList = new List<string>();
        
        do
        {
            Console.Write("> ");
            string userInput =  Console.ReadLine();
            userList.Add(userInput);
            _count++;

        } while (DateTime.Now < end);

        Console.WriteLine($"You listed {_count} items !");

        Console.WriteLine("\n");
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        int rand = new Random().Next(0, _prompts.Count);
        return _prompts[rand];
    }
    //public List<string> GetListFromUser()
    //{
    //    return userList;
    //}


}