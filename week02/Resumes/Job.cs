public class Job
{
    public string _company = " ";
    public string _jobTitle = " ";
    public int _startYear = 0;
    public int _endYear  = 0;

    public Job (string company, string jobTitle, int startYear, int endYear) 
    {
        this._company = company;
        this._jobTitle = jobTitle;
        this._startYear = startYear;
        this._endYear = endYear;
    }

    public void DisplayInfo ()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} - {_endYear}");
    }

}