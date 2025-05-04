using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());
        int magicNumber = new Random().Next(1, 100);

        int guessNumber = 0;
        int trackNumber = 0;
        string continueGame = "yes";
        do 
        {
            while (magicNumber != guessNumber)
            {
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
                trackNumber++;
                if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"Congratulations you've made {trackNumber} guess(es).");
                    Console.WriteLine("Type yes to play again and no to quit the game.");
                    continueGame = Console.ReadLine().ToLower();
                }

            }
        }while(continueGame == "yes");

       



    }
}