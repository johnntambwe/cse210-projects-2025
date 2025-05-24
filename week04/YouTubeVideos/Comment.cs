using System;
using System.Collections.Generic;

public class Comment
{
    public string _name;
    public string _comment;
    //Constructors
    public Comment()
    {
        _name = " ";
        _comment = " ";
    }
    public Comment(string name, string comment)
    { 
        _name= name;
        _comment = comment;
    }
    //Methods
    public void DisplayComment()
    {
        Console.WriteLine($" {_name}: {_comment}");
    }

}