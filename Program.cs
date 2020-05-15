using System;

namespace RPSS
{
    class Program
    {
        static void Main(string[] args)

        {
            // As a user, I should see a welcome message.
            Console.WriteLine("Welcome to rock, paper, scissors, Shoot!");
            Console.WriteLine("What is your name?");

            var user = Console.ReadLine();
            bool repeatGame = true;
            while (repeatGame)
            {
                Difficulty.DifficultySettings(user);

                bool playAgainErrorCheck = true;
                while (playAgainErrorCheck)
                {
                    Console.WriteLine("Play again? 'yes' or 'no'");
                    // string playAgain = null;
                    string playAgain = Console.ReadLine().ToLower();
                    if (playAgain == "yes" || playAgain == "no")
                    {
                        playAgainErrorCheck = false;
                        if (playAgain == "no")
                        {
                            repeatGame = false;
                        }
                        if (playAgain == "yes")
                        {
                            repeatGame = true;
                        }
                    }
                    if (playAgain != "no" && playAgain != "yes")
                    {
                        Console.WriteLine("Please try again, wrong answer");
                        playAgainErrorCheck = true;

                    }
                }
            }
        }
    }

}
