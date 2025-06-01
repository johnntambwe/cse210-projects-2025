
public class Assignment
{
    //Attributes
    protected string _studentName;
    protected string _topic;

    //Constructors 
    public Assignment ()
    {
        _studentName = "No Name";
        _topic = " Zero Topic";
    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    //Getters and Setters 
    public string GetStudentName()
    {
        return _studentName;
    }
    //public void SetStudentName(string studentName)
    //{
    //    _studentName = studentName;
    //}
    public string GetTopic()
    {
        return _topic;
    }
    //public void SetTopic(string topic)
    //{
    //    _topic = topic;
    //}

    //Method
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}