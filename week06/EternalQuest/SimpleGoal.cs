
public class SimpleGoal : Goal
{
    private bool _isComplete;
    //Constructor 
    public SimpleGoal(string name, string description, int points, bool isComplete=false) : base(name, description, points)
    { 
        _isComplete = isComplete;
    }
    //Getter
    public bool GetIsComplete()
    { 
        return _isComplete;
    }

    //Override Methods
    public override void RecordEvent()
    {
        if (IsComplete())
        {
            _isComplete = true;
            Console.WriteLine($"Congratulations! You've earned {GetPoints()} points");
        }
        else
            Console.WriteLine("This goal has already been completed.");
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal : {GetShortName()}|{GetDescription()}|{GetPoints()}|{IsComplete()}";
    }
    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[x] {GetShortName()} ({GetDescription()})";
        }
        else
            return $"[ ] {GetShortName()} ({GetDescription()})";
    }
    //This method helps to load the file
    public static Goal newString(string stringRepresentation)
    {
        string[] parts = stringRepresentation.Split("|");
        return new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]), bool.Parse(parts[3]));
    }




}