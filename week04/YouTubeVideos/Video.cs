using System;
using System.Collections.Generic;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    //Constructors 
    public Video()
    {
        _title = " ";
        _author = " ";
        _length = 0;
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        //_comments.Add(comment);
    }

    //Methods
    public int CommentNumber()
    { 
        return _comments.Count;
    }
    public void DisplayVideo()
    {
        Console.WriteLine("___________________________________________________________________________________");
        Console.WriteLine($"Video Title: {_title} |By: {_author} | Time: {_length} seconds. ");
        Console.WriteLine("___________________________________________________________________________________");
        Console.WriteLine($"Comment Section({ CommentNumber()}): \n");
        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }


}