using System;
using System.Linq;
namespace RPSS
{
    class Difficulty
    {
        public static void DifficultySettings(string playerOne)
        {
            bool incorrectAnswer = true;
            while (incorrectAnswer)
            {
                Console.WriteLine(playerOne + " " + "select difficulty: easy, normal, impossible");
                var difficulty = Console.ReadLine().ToLower();
                // The computer should randomly decide one of the options.
                Random rnd = new Random();
                // create random options sting for the game

                // select random option

                // You program should then decide who the winner is;

                if (difficulty != "normal" && difficulty != "easy" && difficulty != "impossible")
                {
                    incorrectAnswer = true;
                    Console.WriteLine("please try again");
                }
                if (difficulty == "easy")

                // make every input a victory
                {
                    incorrectAnswer = false;
                    Console.WriteLine("You selected easy");
                    Console.WriteLine(playerOne + " Prepare to be defeated!");
                    bool easyErrorCheck = true;
                    while (easyErrorCheck)
                    {
                        // As a playerOne, I should see the options I can pick (i.e., "rock", "paper", "scissor")
                        Console.WriteLine(playerOne + " Pick rock, paper, scissors, spock, lizard?");
                        Console.WriteLine("Your answer");

                        var answer = Console.ReadLine().ToLower();
                        if (answer == "rock" || answer == "paper" || answer == "scissor" || answer == "spock" || answer == "lizard")

                        {
                            easyErrorCheck = false;

                            if (answer == "rock")
                            {
                                string[] rockWinOptions = { "lizard", "scissors" };
                                var rockEasyGindex = rnd.Next(rockWinOptions.Length);
                                Console.WriteLine($"You win! Your opponent answered {rockWinOptions[rockEasyGindex]}");
                            }
                            if (answer == "paper")
                            {
                                string[] paperWinOptions = { "rock", "spock" };
                                var paperEasyGindex = rnd.Next(paperWinOptions.Length);
                                Console.WriteLine($"You win! Your opponent answered {paperWinOptions[paperEasyGindex]}");
                            }
                            if (answer == "scissors")
                            {
                                string[] sciccorsWinOptions = { "lizard", "paper" };
                                var sciccorsEasyGindex = rnd.Next(sciccorsWinOptions.Length);
                                Console.WriteLine($"You win! Your opponent answered {sciccorsWinOptions[sciccorsEasyGindex]}");
                            }
                            if (answer == "spock")
                            {
                                string[] lizzardWinOptions = { "spock", "paper" };
                                var lizzardEasyGindex = rnd.Next(lizzardWinOptions.Length);
                                Console.WriteLine($"You win! Your opponent answered {lizzardWinOptions[lizzardEasyGindex]}");
                            }
                            if (answer == "lizard")
                            {
                                string[] spockWinOptions = { "rock", "paper" };
                                var spockEasyGindex = rnd.Next(spockWinOptions.Length);
                                Console.WriteLine($"You win! Your opponent answered {spockWinOptions[spockEasyGindex]}");
                            }
                        }
                        if (answer != "rock" && answer != "paper" && answer != "scissor" && answer == "spock" && answer == "lizard")
                        {
                            Console.WriteLine("Please try again");
                            easyErrorCheck = true;
                        }

                    }
                }
                if (difficulty == "normal")
                {
                    var win = "you win";
                    var lost = "you lose";
                    var draw = "it is a draw";

                    incorrectAnswer = false;
                    Console.WriteLine(playerOne + " Prepare to be defeated!");
                    bool normalErrorCheck = true;
                    while (normalErrorCheck)
                    {
                        // As a playerOne, I should see the options I can pick (i.e., "rock", "paper", "scissor")
                        Console.WriteLine(playerOne + " Pick rock, paper, scissors, lizard or spock?");
                        Console.WriteLine("Your answer");

                        var answer = Console.ReadLine().ToLower();
                        string[] gameOptions = { "rock", "paper", "scissors", "lizard", "spock" };
                        var normalGindex = rnd.Next(gameOptions.Length);
                        Console.WriteLine($"Your opponent answered {gameOptions[normalGindex]}");
                        if (answer != "rock" && answer != "paper" && answer != "scissor" && answer != "spock" && answer != "lizard")
                        {
                            normalErrorCheck = true;
                            Console.WriteLine("Invalid answer, please try again");
                        }
                        if (answer == "rock" || answer == "paper" || answer == "scissor" || answer == "spock" || answer == "lizard")
                        {
                            normalErrorCheck = false;


                            if (answer == "rock")
                            {
                                // what do we do if the playerOne picked rock
                                // See what the computer picked and compare, see who wins
                                if (gameOptions[normalGindex] == "rock")
                                {
                                    Console.WriteLine(draw);
                                }
                                // scratch
                                if (gameOptions[normalGindex] == "paper")
                                {
                                    Console.WriteLine(lost);
                                }
                                // pc wins
                                if (gameOptions[normalGindex] == "scissors")
                                // playerOne wins
                                {
                                    Console.WriteLine(win);
                                }
                                if (gameOptions[normalGindex] == "spock") { Console.WriteLine(lost); }

                                if (gameOptions[normalGindex] == "lizard") { Console.WriteLine(win); }


                            }
                            if (answer == "paper")
                            {
                                if (gameOptions[normalGindex] == "paper")
                                // scratch
                                {
                                    Console.WriteLine(draw);
                                }
                                if (gameOptions[normalGindex] == "rock")
                                // playerOne wins
                                {
                                    Console.WriteLine(win);
                                }
                                if (gameOptions[normalGindex] == "scissors")
                                // pc wins
                                {
                                    Console.WriteLine(lost);
                                }
                                if (gameOptions[normalGindex] == "spock") { Console.WriteLine(win); }

                                if (gameOptions[normalGindex] == "lizard") { Console.WriteLine(lost); }

                            }

                            if (answer == "scissors")
                            {
                                if (gameOptions[normalGindex] == "paper")
                                // playerOne wins
                                {
                                    Console.WriteLine(lost);
                                }
                                if (gameOptions[normalGindex] == "rock")
                                // pc wins
                                {
                                    Console.WriteLine(win);
                                }
                                if (gameOptions[normalGindex] == "scissors")
                                //  scratch
                                {
                                    Console.WriteLine(draw);
                                }
                                if (gameOptions[normalGindex] == "spock") { Console.WriteLine(lost); }

                                if (gameOptions[normalGindex] == "lizard") { Console.WriteLine(win); }
                            }
                            if (answer == "spock")
                            {
                                if (gameOptions[normalGindex] == "paper")
                                // playerOne wins
                                {
                                    Console.WriteLine(lost);
                                }
                                if (gameOptions[normalGindex] == "rock")
                                // pc wins
                                {
                                    Console.WriteLine(win);
                                }
                                if (gameOptions[normalGindex] == "scissors")
                                //  scratch
                                {
                                    Console.WriteLine(win);
                                }
                                if (gameOptions[normalGindex] == "spock") { Console.WriteLine(draw); }

                                if (gameOptions[normalGindex] == "lizard") { Console.WriteLine(lost); ; }
                            }
                            if (answer == "lizard")
                            {
                                if (gameOptions[normalGindex] == "paper")
                                // playerOne wins
                                {
                                    Console.WriteLine(win);
                                }
                                if (gameOptions[normalGindex] == "rock")
                                // pc wins
                                {
                                    Console.WriteLine(lost);
                                }
                                if (gameOptions[normalGindex] == "scissors")
                                //  scratch
                                {
                                    Console.WriteLine(lost);
                                }
                                if (gameOptions[normalGindex] == "spock") { Console.WriteLine(win); }

                                if (gameOptions[normalGindex] == "lizard") { Console.WriteLine(draw); }
                            }
                            // The playerOne should then see the randomly selected option, as well as a win or lose message.

                            // add some validation around playerOne input.

                        }
                        if (answer != "rock" && answer != "paper" && answer != "scissor" && answer == "spock" && answer == "lizard")
                        {
                            Console.WriteLine("Please try again");
                        }
                    }
                }
                if (difficulty == "impossible")

                {
                    incorrectAnswer = false;
                    Console.WriteLine("You selected impossible");
                    Console.WriteLine(playerOne + " " + "Prepare to be defeated!");
                    bool impossibleErrorCheck = true;
                    while (impossibleErrorCheck)
                    {
                        Console.WriteLine(playerOne + " " + "Pick rock, paper, scissors, lizard or spock");
                        Console.WriteLine("Your answer");

                        var answer = Console.ReadLine().ToLower();
                        if (answer == "rock" || answer == "paper" || answer == "scissor" || answer == "spock" || answer == "lizard")
                        {
                            impossibleErrorCheck = false;

                            if (answer == "rock")
                            {
                                string[] rockloseOptions = { "paper", "spock" };
                                var rockHardGindex = rnd.Next(rockloseOptions.Length);
                                Console.WriteLine($"You lose! Your opponent answered {rockloseOptions[rockHardGindex]}");
                            }
                            if (answer == "paper")
                            {
                                string[] paperLoseOptions = { "scissors", "lizard" };
                                var paperHardGindex = rnd.Next(paperLoseOptions.Length);
                                Console.WriteLine($"You lose! Your opponent answered {paperLoseOptions[paperHardGindex]}");
                            }
                            if (answer == "scissors")
                            {
                                string[] sciccorsLoseOptions = { "spock", "rock" };
                                var sciccorsHardGindex = rnd.Next(sciccorsLoseOptions.Length);
                                Console.WriteLine($"You lose! Your opponent answered {sciccorsLoseOptions[sciccorsHardGindex]}");
                            }
                            if (answer == "lizard")
                            {
                                string[] lizzardLoseOptions = { "rock", "scissors" };
                                var lizzardHardGindex = rnd.Next(lizzardLoseOptions.Length);
                                Console.WriteLine($"You lose! Your opponent answered {lizzardLoseOptions[lizzardHardGindex]}");
                            }
                            if (answer == "spock")
                            {
                                string[] spockLoseOptions = { "paper", "lizard" };
                                var spockHardGindex = rnd.Next(spockLoseOptions.Length);
                                Console.WriteLine($"You lose! Your opponent answered {spockLoseOptions[spockHardGindex]}");
                            }
                        }
                        if (answer != "rock" && answer != "paper" && answer != "scissor" && answer == "spock" && answer == "lizard")
                        {
                            Console.WriteLine("Please try again");

                            impossibleErrorCheck = true;
                        }
                    }
                }
            }
        }
    }
}
