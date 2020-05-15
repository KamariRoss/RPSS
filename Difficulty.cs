using System;
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
                        Console.WriteLine(playerOne + " Pick rock, paper or scissors?");
                        Console.WriteLine("Your answer");

                        var answer = Console.ReadLine().ToLower();
                        if (answer == "rock" || answer == "paper" || answer == "scissor")
                        {
                            easyErrorCheck = false;

                            if (answer == "rock")
                            {
                                Console.WriteLine("PC selected scissors, you win!");
                            }
                            if (answer == "paper")
                            {
                                Console.WriteLine("PC selected paper, you win!");
                            }
                            if (answer == "scissors")
                            {
                                Console.WriteLine("PC selected paper, you win!");
                            }
                        }
                        if (answer != "rock" && answer != "paper" && answer != "scissor")
                        {
                            Console.WriteLine("Please try again");
                            easyErrorCheck = true;
                        }

                    }
                }
                if (difficulty == "normal")
                {

                    incorrectAnswer = false;
                    Console.WriteLine(playerOne + " Prepare to be defeated!");
                    bool normalErrorCheck = true;
                    while (normalErrorCheck)
                    {
                        // As a playerOne, I should see the options I can pick (i.e., "rock", "paper", "scissor")
                        Console.WriteLine(playerOne + " Pick rock, paper or scissors?");
                        Console.WriteLine("Your answer");

                        var answer = Console.ReadLine().ToLower();
                        if (answer != "rock" && answer != "paper" && answer != "scissor")
                        {
                            normalErrorCheck = true;
                            Console.WriteLine("Invalid answer, please try again");
                        }
                        if (answer == "rock" || answer == "paper" || answer == "scissor")
                        {
                            normalErrorCheck = false;
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
                                // what do we do if the playerOne picked rock
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
                                // playerOne wins
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
                                // playerOne wins
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
                                // playerOne wins
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
                            // The playerOne should then see the randomly selected option, as well as a win or lose message.
                            Console.WriteLine("Player 2 answered " + gameOptions[gindex] + " " + result);
                            // add some validation around playerOne input.

                        }
                        if (answer != "rock" && answer != "paper" && answer != "scissor")
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
                        Console.WriteLine(playerOne + " " + "Pick rock, paper or scissors");
                        Console.WriteLine("Your answer");

                        var answer = Console.ReadLine().ToLower();
                        if (answer == "rock" || answer == "paper" || answer == "scissor")
                        {
                            impossibleErrorCheck = false;

                            if (answer == "rock")
                            {
                                Console.WriteLine("PC selected scissors you lose");
                            }
                            if (answer == "paper")
                            {
                                Console.WriteLine("PC selected scissors, you lose");
                            }
                            if (answer == "scissors")
                            {
                                Console.WriteLine("PC selected rock, you lose");
                            }
                        }
                        if (answer != "rock" && answer != "paper" && answer != "scissor")
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