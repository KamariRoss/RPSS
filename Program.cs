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
      Console.WriteLine(user + " Prepare to be defeated!");
      Console.WriteLine("Round 1");
      // As a user, I should see the options I can pick (i.e., "rock", "paper", "scissor")
      Console.WriteLine(user + " Pick rock, paper or scissors?");
      Console.WriteLine("Your answer");
      var answer = Console.ReadLine();
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
          result = "It is a draw";
        }
        // scratch
        if (gameOptions[gindex] == "paper")
        {
          result = "You lose";
        }
        // pc wins
        if (gameOptions[gindex] == "scissors")
        // user wins
        {
          result = "You win";
        }

      }
      if (answer == "paper")
      {
        if (gameOptions[gindex] == "paper")
        // scratch
        {
          result = "It is a draw";
        }
        if (gameOptions[gindex] == "rock")
        // user wins
        {
          result = "You win";
        }
        if (gameOptions[gindex] == "scissors")
        // pc wins
        {
          result = "You lose";
        }
      }

      if (answer == "scissors")
      {
        if (gameOptions[gindex] == "paper")
        // user wins
        {
          result = "You lose";
        }
        if (gameOptions[gindex] == "rock")
        // pc wins
        {
          result = "You win";
        }
        if (gameOptions[gindex] == "scissors")
        //  scratch
        {
          result = "It is a draw";
        }

      }

      // The user should then see the randomly selected option, as well as a win or lose message.
      Console.WriteLine("Player 2 answered " + gameOptions[gindex] + " you " + result);
      // add some validation around user input.
    }
  }
}
