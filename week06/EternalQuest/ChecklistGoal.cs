
public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    //Constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    { 
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    //Getters and Setters
    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public void SetAmountComplete(int amountComplete)
    {
        _amountCompleted = amountComplete;
    }
    public int GetTarget()
    {
        return _target;
    }
    public void SetTarget(int target)
    {
        _target = target;
    }
    public int GetBonus()
    {
        return _bonus;
    }
    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
    //Override Methods
    public override void RecordEvent()
    {
        if (!IsComplete())
        {
            _amountCompleted++;
            Console.WriteLine($"Congratulations! You've earned {GetPoints()} points");
        }
        else if (IsComplete())
        {
            Console.WriteLine($"Bonus! You've earned {GetPoints()} as a bonus");
        }
        else
            Console.WriteLine("This goal has already been completed.");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        if (IsComplete())
        {
            return $"[x] {GetShortName()} ({GetDescription()}) -- Currently completed: {GetAmountCompleted()}/{GetTarget()}";
        }
        else
            return $"[ ] {GetShortName()} ({GetDescription()}) -- Currently completed: {GetAmountCompleted()}/{GetTarget()}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal: {GetShortName()}|{GetDescription()}|{GetPoints()}|{GetTarget()}|{GetBonus()}|{GetAmountCompleted()}";
    }
    //This method helps to load the file
    public static Goal newString(string stringRepresentation)
    {
        string[] parts = stringRepresentation.Split("|");
        return new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]));
    }

}
