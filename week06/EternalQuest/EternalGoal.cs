
public class EternalGoal : Goal
{
    //Constructor 
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    //Override Methods
    public override void RecordEvent()
    {
        if (!IsComplete())
        {
           
            Console.WriteLine($"Congratulations! You've earned {GetPoints()} points");
        }
        else
            Console.WriteLine("This goal has already been completed.");
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal : {GetShortName()}|{GetDescription()}|{GetPoints()}";
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
        return new EternalGoal(parts[0], parts[1], int.Parse(parts[2]));
    }
}