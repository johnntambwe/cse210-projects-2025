using System;
using System.Collections.Generic;


public class Resume 
{
    //This class has the attribute _name and a list of Jobs and the method
    //That displays the resume with both the name and jobs.

    public string _name;
    public List<Job> jobs = new List<Job>();

    public Resume(string name, List<Job> jobsList)
    {
        this._name = name;
        this.jobs = jobsList;
    }

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");
        foreach (Job job in jobs)
        {
            Console.WriteLine($"{job._jobTitle} ({job._company}) {job._startYear} - {job._endYear}");
        }



    }
}