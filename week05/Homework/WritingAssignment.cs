
public class WritingAssignment : Assignment 
{
    //Attributes
    private string _title;
    //Constructor 
    public WritingAssignment() : base()
    {
        _title = " ";
    }
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    { 
        _title = title;
    }
    //Getters and Setters 
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    //Method
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}