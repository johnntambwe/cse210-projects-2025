
public class MathAssignment : Assignment
{
    //Attributes
    private string _textBookSection;
    private string _problems;

    //Constructors
    public MathAssignment() : base()
    {
        _textBookSection = " ";
        _problems = " ";
    }
    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    { 
         _textBookSection = textBookSection;
        _problems = problems;
    }

    // Getters and Setters 
    public string GetTextBookSection()
    { 
        return _textBookSection;
    }
    public void SetTextBookSection(string textBookSection)
    {
        _textBookSection = textBookSection;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    //Methods
    public string GetHomeWorkList()
    {
        return $"Section {_textBookSection} Problems {_problems} ";
    }


}