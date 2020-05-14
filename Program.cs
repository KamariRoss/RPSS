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
            bool flag = true;
            while (flag)
            {
                // User selecting difficulty
                Console.WriteLine(user + "select difficulty: easy, normal, impossible");
                var difficulty = Console.ReadLine().ToLower();
                Difficulty.DifficultySetting(difficulty, user);
                Console.WriteLine("Play again? 'y' or 'n'");
                string playAgain = null;
                playAgain = Console.ReadLine().ToLower();
                if (playAgain == "n")
                {
                    flag = false;
                }
            }
        }
    }

}
