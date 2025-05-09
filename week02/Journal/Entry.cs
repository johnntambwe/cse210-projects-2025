
public class Entry 
{

    public DateTime _date = DateTime.Now;
    public string _promptText;
    public string _entryText;

    public Entry(string prompt, string entryText)
    {
        this._promptText = prompt;
        this._entryText = entryText;
    }


    public void DisplayEntry()
    {
        Console.WriteLine($"{_promptText} | {_entryText} - {_date}.");
    }

}