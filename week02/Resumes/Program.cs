using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job ("KCS Mining Ltd","Safety Officer", 2022, 2024);
        Job job2 = new Job("Golden Services", "CEO", 2024, 2025);
        List<Job> jobList = new List<Job>();
        jobList.Add(job1);
        jobList.Add(job2);

        //Without using the constructor
        //Resume resume1 = new Resume ();
        //resume1._name = "John Ntambwe";
        //resume1.jobs.Add(job1);
        //resume1.jobs.Add(job2);
        //resume1.DisplayResume();

        //Using the constructor
        Resume resume = new Resume("John Ntambwe", jobList);
        resume.DisplayResume();


        Console.ReadLine();
    }
}