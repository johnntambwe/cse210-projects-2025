using System;
using System.Collections.Generic;
using System.IO;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random(); 
    //Constructors

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        //string _texts = text;
        //foreach (string word in _texts.Split(' '))
        //{
        //    Word newWord = new Word(word);
        //    _words.Add(newWord);
        //}
        foreach (string word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }

    }

    //Getters and Setters
    public Reference GetReference()
    { 
        return _reference;
    }
    public void SetReference(Reference reference)
    {
        _reference = reference;
    }

    public List<Word> GetWords()
    {
        return _words;
    }
    public void SetWords(Word word)
    {
        _words.Add(word);
    }

    //Methods

    public bool HideRandomWords( int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            //List<Word> visibleWords = _words.FindAll(word => ! word.GetIsHidden()); 
            List<Word> visibleWords = new List<Word>();
            foreach (Word word in _words)
            {
                if (!word.GetIsHidden())
                { 
                    visibleWords.Add(word);
                }
            }
            if (visibleWords.Count == 0)
            {
                return false;
            }
            else
            {
                int index = _random.Next(visibleWords.Count);
                visibleWords[index].Hide();
            }
        }
        return true;
    }

    public void  GetDisplayText()
    {
        Console.WriteLine(_reference.GetDisplayText());
        foreach (Word word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
    }

    public bool IsCompletelyHidden()
    {
        return _words.TrueForAll(words => words.IsHidden());
    }

    //Exceeding the requirement
    //To be continued the program will load the scripture from scriptures.text file and 
    //And retrieve the reference and the string to be passed as parameters when creating a new Scripture object.
    //public void LoadFromFile(string fileName)
    //{
    //    try
    //    {
    //        string[] readText = File.ReadAllLines(fileName);
    //        foreach (string line in readText)
    //        {
    //            Console.WriteLine(line);
    //            Console.ReadLine();
    //        }
    //    }
    //    catch (System.IO.FileNotFoundException e)
    //    {
    //        Console.WriteLine(" Check that you've typed the correct file and \n Make sure to save the file first before loading it.");
    //    }

    //}

}