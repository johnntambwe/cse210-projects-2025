using System.Collections.Generic;
using System.IO;

public class Journal1
{
    List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
        //Console.WriteLine("Added to the list");

    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine($"{entry._promptText} | {entry._entryText} - {entry._date}");
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
         
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._promptText} | {entry._entryText} - {entry._date}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        try
        {
            string[] readText = File.ReadAllLines(fileName);
            foreach (string line in readText)
            {
                Console.WriteLine(line);
            }
        }
        catch (System.IO.FileNotFoundException e)
        {
            Console.WriteLine(" Check that you've typed the correct file and \n Make sure to save the file first before loading it.");
        }

    }
}