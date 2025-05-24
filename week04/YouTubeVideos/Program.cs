using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        //First Video and associated comments
        Video video1 = new Video("Come and Follow me", "Byu-Idaho", 300);
        string comments1 = " John Ntambwe : 'Good video.' | Ben : 'Bad video.' | Grace : 'Thank you for sharing.' ";
        foreach (string word in comments1.Split("|"))
        {
            Comment comment1 = new Comment(word.Split(":")[0], word.Split(":")[1]);
            video1._comments.Add(comment1);
        }

        //Second Video and associated comments
        Video video2 = new Video("I'm a child of God", "Tabernacle Choir", 180);
        string comments2 = " Joseph : And he has sent me here. | Isaac : Has given me an earthly home. | Benjamin : With parents kind and dear. " +
            "| John : Lead me, guide me, walk beside me...";
        foreach (string word in comments2.Split("|"))
        {
            Comment comment2 = new Comment(word.Split(":")[0], word.Split(":")[1]);
            video2._comments.Add(comment2);
        }
        ////Third Video and associated comments
        Video video3 = new Video("Think Celestial", "President Russell M. Nelson", 780);
        string comments3 = " Patrick : I'm not LDS member, but this video really touched my heart. | John : Think Celestial implies putting things into perspective. " +
            "| George : I've been inspired.";
        foreach (string word in comments3.Split("|"))
        {
            Comment comment3 = new Comment(word.Split(":")[0], word.Split(":")[1]);
            video3._comments.Add(comment3);
        }

        ////Fourth Video and associated comments
        Video video4 = new Video("Hakuna Matata", "Lion King", 120);
        string comments4 = " James : The Lion King is my favorite. | John : This video brings back memories. " +
            "| James : Who is watching this in 2025? | Johnson : Hakhuna matata means no worries. | Isaac: This is actually my 10th time that I watch this and still derives the same utility.";
        foreach (string word in comments4.Split("|"))
        {
            Comment comment4 = new Comment(word.Split(":")[0], word.Split(":")[1]);
            video4._comments.Add(comment4);
        }

        //Final Step.
        List<Video> videos = new List<Video>();
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);
        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }


        Console.ReadLine();
    }
}