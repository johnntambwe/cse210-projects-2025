
public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;

    //Constructor 
    public Goal(string name, string description, int points)
    { 
        _shortName = name;
        _description = description;
        _points = points;
    }

    //Getters and Setters
    public string GetShortName()
    { 
        return _shortName;
    }
    public void SetShortName(string name)
    {
        _shortName = name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
         _description = description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }

    //Abstract Methods
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();
    //Simple Method
    public virtual string GetDetailsString()
    {
        return "Get details string here";
    }
    
}