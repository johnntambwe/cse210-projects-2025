using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Console.WriteLine(" ");

        List<Activity> _activities = new List<Activity>();

        Running running = new Running(30, 2000, 50, 25);
        Cycling cycling = new Cycling(25, 1000, 10, 15);
        Swimming swimming = new Swimming(10, 200, 20, 35);

        _activities.Add(running);
        _activities.Add(cycling);
        _activities.Add(swimming);

        foreach (Activity activity in _activities)
        {
            
            Console.WriteLine($"{activity.GetDate()}{activity.ToString()}{activity.GetSummary()}");
        }

        Console.ReadLine();
    }
}