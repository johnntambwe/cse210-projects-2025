
public class Activity
{ 
    //Attributes
    protected string _name;
    protected string _description;
    protected int _duration;

    //Constructors
    public Activity()
    { 
        _name = " ";
        _description = " ";
        _duration = 0;
    }
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    //Getters and Setters
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    //Methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine($"{_description}");
    }

    public void DisplayEndingMessage(int seconds =2)
    {
        Console.WriteLine($"\nWell done.");
        ShowSpinner();
        Console.WriteLine($"You have completed another {_duration} seconds of {_name}.");
        ShowSpinner();
        Console.WriteLine(" ");

    }
    public void ShowSpinner(int seconds = 2)
    {
        List<string> characters = new List<string>();
        characters.Add("|");
        characters.Add("/");
        characters.Add("-");
        characters.Add("\\");
        characters.Add("|");
        characters.Add("/");
        characters.Add("-");
        characters.Add("\\");


        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);

        int j = 0;
        while (DateTime.Now < end)
        {
            string character = characters[j];
            Console.Write(character);

            Thread.Sleep(280);
            Console.Write("\b \b");
            j++;

            if (j >= characters.Count)
            {
                j = 0;
            }
        }
    }
    public void ShowCountDown(int seconds = 3)
    {
        for (int i = seconds; i >0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }









}