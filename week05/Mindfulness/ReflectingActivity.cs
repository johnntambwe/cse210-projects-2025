using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    //Attributes
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>(); 

    //Constructors
    public ReflectingActivity() : base()
    {
        _prompts = new List<string>();
        _questions = new List<string>();
    }
    public ReflectingActivity(string name, string description, string prompts, string questions) : base(name, description)
    {
        foreach(string prompt in prompts.Split(","))
            _prompts.Add(prompt);
        foreach(string question in questions.Split(","))
            _questions.Add(question);
    }
    //Getters and Setters
    public List<string> GetPrompts()
    { 
        return _prompts;
    }
    public List<string> GetQuestions()
    {
        return _questions;
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

        Console.WriteLine("Consider the following prompt :");
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown();
        Console.WriteLine("\n");
        DateTime now = DateTime.Now;
        DateTime end = now.AddSeconds(_duration);
        do
        {
            int rand = new Random().Next(1, _duration);
            DisplayQuestions();
            ShowSpinner(rand);
        } while (DateTime.Now < end);

        Console.WriteLine("\n");
        DisplayEndingMessage();

    }
    public string GetRandomPrompt()
    {
        int rand = new Random().Next(0, _prompts.Count);
        return _prompts[rand];

    }
    public string GetRandomQuestion()
    {
        int rand = new Random().Next(0, _prompts.Count);
        return _questions[rand];
    }
    public void DisplayPrompt()
    {
        Console.WriteLine($"---{GetRandomPrompt()}---");
    }
    public void DisplayQuestions()
    {
        Console.Write($"\n{GetRandomQuestion()} ");
    }







}