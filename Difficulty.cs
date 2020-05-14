using System;
namespace RPSS
{
    class Difficulty
    {
        public static void DifficultySetting(string userDifficultySelection, string user)
        {
            if (userDifficultySelection != "normal" && userDifficultySelection != "easy" && userDifficultySelection != "impossible")
            {
                Console.WriteLine("please try again");
            }
            if (userDifficultySelection == "easy")
            // make every input a victory
            {
                Console.WriteLine("You selected easy");
                Console.WriteLine(user + " Prepare to be defeated!");
                Console.WriteLine("Round 1");

                // As a user, I should see the options I can pick (i.e., "rock", "paper", "scissor")
                Console.WriteLine(user + " Pick rock, paper or scissors?");
                Console.WriteLine("Your answer");

                var answer = Console.ReadLine().ToLower();
                if (answer == "rock")
                    Console.WriteLine("PC selected scissors, you win!");
                if (answer == "paper")
                    Console.WriteLine("PC selected paper, you win!");
                if (answer == "scissors")
                    Console.WriteLine("PC selected paper, you win!");
                if (answer != "rock" && answer != "paper" && answer != "scissor")
                {
                    Console.WriteLine("Please try again");
                }


            }
            if (userDifficultySelection == "normal")
            {

                Console.WriteLine(user + " Prepare to be defeated!");
                Console.WriteLine("Round 1");

                // As a user, I should see the options I can pick (i.e., "rock", "paper", "scissor")
                Console.WriteLine(user + " Pick rock, paper or scissors?");
                Console.WriteLine("Your answer");

                var answer = Console.ReadLine().ToLower();

                if (answer == "rock" || answer == "paper" || answer == "scissor")
                {
                    // The computer should randomly decide one of the options.
                    Random rnd = new Random();
                    string[] gameOptions = { "rock", "paper", "scissors" };
                    var gindex = rnd.Next(gameOptions.Length);
                    Console.WriteLine("Your oppenent answered  " + gameOptions[gindex]);
                    // You program should then decide who the winner is;

                    var result = "unkown";

                    // If the person picks rock and the computer picks rock then record the result of a scratch
                    // If the person picks rock and the computer picks rock then record the result of you lose
                    // ...
                    // ...
                    // ...

                    if (answer == "rock")
                    {
                        // what do we do if the user picked rock
                        // See what the computer picked and compare, see who wins
                        if (gameOptions[gindex] == "rock")
                        {
                            result = "it is a draw";
                        }
                        // scratch
                        if (gameOptions[gindex] == "paper")
                        {
                            result = "you lose";
                        }
                        // pc wins
                        if (gameOptions[gindex] == "scissors")
                        // user wins
                        {
                            result = "you win";
                        }

                    }
                    if (answer == "paper")
                    {
                        if (gameOptions[gindex] == "paper")
                        // scratch
                        {
                            result = "it is a draw";
                        }
                        if (gameOptions[gindex] == "rock")
                        // user wins
                        {
                            result = "you win";
                        }
                        if (gameOptions[gindex] == "scissors")
                        // pc wins
                        {
                            result = "you lose";
                        }
                    }

                    if (answer == "scissors")
                    {
                        if (gameOptions[gindex] == "paper")
                        // user wins
                        {
                            result = "you lose";
                        }
                        if (gameOptions[gindex] == "rock")
                        // pc wins
                        {
                            result = "you win";
                        }
                        if (gameOptions[gindex] == "scissors")
                        //  scratch
                        {
                            result = "it is a draw";
                        }

                    }
                    // The user should then see the randomly selected option, as well as a win or lose message.
                    Console.WriteLine("Player 2 answered " + gameOptions[gindex] + " " + result);
                    // add some validation around user input.


                }
                if (answer != "rock" && answer != "paper" && answer != "scissor")
                {
                    Console.WriteLine("Please try again");
                }

            }
            if (userDifficultySelection == "impossible")
            {
                Console.WriteLine("You selected impossible");
                Console.WriteLine(user + "Prepare to be defeated!");
                Console.WriteLine("Round 1");
                Console.WriteLine(user + "Pick rock, paper or scissors");
                Console.WriteLine("Your answer");

                var answer = Console.ReadLine().ToLower();
                if (answer == "rock")
                    Console.WriteLine("PC selected scissors you lose");
                if (answer == "paper")
                    Console.WriteLine("PC selected scissors, you lose");
                if (answer == "scissors")
                    Console.WriteLine("PC selected rock, you lose");
                if (answer != "rock" && answer != "paper" && answer != "scissor")
                {
                    Console.WriteLine("Please try again");
                }

            }
        }


    }
}