
public class BreathingActivity : Activity
{
    public BreathingActivity() : base() { }
    public BreathingActivity(string name, string description) : base(name, description) { }

    // Method
    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = Convert.ToInt32(Console.ReadLine());
        _duration = duration;
        Console.Clear();
        Console.WriteLine("Getting ready...");
        ShowSpinner();

        DateTime now = DateTime.Now;
        DateTime end = now.AddSeconds(_duration);
        do
        {
            int rand = new Random().Next(1, 5);
            Console.Write("Breath in...");
            ShowCountDown(rand);
            Console.Write("\nBreath out ...");
            ShowCountDown(rand);
            Console.WriteLine("\n");
        } while (DateTime.Now < end);

        DisplayEndingMessage();

    }


}
