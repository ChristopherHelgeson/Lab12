using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12___classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int winCount = 0;
            int loseCount = 0;
            int drawCount = 0;

            Console.Clear();
            Console.WriteLine("Let's play ROCK, PAPER, SCISSORS!! (aka Roshambo)");
            Console.Write("\nPlease enter your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("\nWelcome, " + playerName + ". Have fun playing!");
            Console.WriteLine("\nPlease select an opponent:");
            Console.WriteLine("\n\t1) Mr. Predictable");
            Console.WriteLine("\t2) DJ MixR");
            Console.Write("\nYour selection?: ");
            int opponentNum = int.Parse(Console.ReadLine());

            Player opponent = null;

            while (opponentNum < 1 || opponentNum > 2)
            {
                Console.Write("Not a valid selection. Please try again: ");
                opponentNum = int.Parse(Console.ReadLine());
            }
            switch (opponentNum)
            {
                case 1:
                    Console.WriteLine("\nYou have chosen wisely, " + playerName + ".\n");
                    opponent = new AlwaysRock();
                    break;
                case 2:
                    Console.WriteLine("\nNot so smart, are you? Prepare to lose,  " + playerName + ".\n");
                    opponent = new RandomDude();
                    break;
            }

            string sameOpponent = "Y";
            while (sameOpponent == "Y" || sameOpponent == "y")
            {
                string playerThrow = string.Empty;
                while (playerThrow != "r" && playerThrow != "p" && playerThrow != "s")
                {
                    Console.Write("Rock, Paper, or Scissors? (R/P/S): ");
                    playerThrow = Console.ReadLine();
                    playerThrow = playerThrow.ToLower();
                }
                if (playerThrow == "r")
                {
                    playerThrow = "Rock";
                }
                else if (playerThrow == "p")
                {
                    playerThrow = "Paper";
                }
                else if (playerThrow == "s")
                {
                    playerThrow = "Scissors";
                }

                string opponentThrow = opponent.generateRoshambo();
                Console.WriteLine("\n" + playerName + ": " + playerThrow);
                Console.WriteLine(opponent.opponentName() + ": " + opponentThrow);
                Console.WriteLine();

                string result = string.Empty;

                if (playerThrow == "Rock" && opponentThrow == "Paper")
                {
                    Console.WriteLine("You lose.");
                    loseCount++;
                }
                else if (playerThrow == "Rock" && opponentThrow == "Scissors")
                {
                    Console.WriteLine("You win!");
                    winCount++;
                }
                else if (playerThrow == "Paper" && opponentThrow == "Rock")
                {
                    Console.WriteLine("You win!");
                    winCount++;
                }
                else if (playerThrow == "Paper" && opponentThrow == "Scissors")
                {
                    Console.WriteLine("You lose.");
                    loseCount++;
                }
                else if (playerThrow == "Scissors" && opponentThrow == "Rock")
                {
                    Console.WriteLine("You lose.");
                    loseCount++;
                }
                else if (playerThrow == "Scissors" && opponentThrow == "Paper")
                {
                    Console.WriteLine("You win!");
                    winCount++;
                }
                else
                {
                    Console.WriteLine("A draw!");
                    drawCount++;
                }

                if (winCount > loseCount)
                {
                    Console.WriteLine("\nYou are currently ahead " + winCount + " to " + loseCount + " with " + drawCount + " draws.");
                }
                else if (winCount < loseCount)
                {
                    Console.WriteLine("\nYou are currently behind " + loseCount + " to " + winCount + " with " + drawCount + " draws.");
                }
                else if (winCount == loseCount)
                {
                    Console.WriteLine("\nYou are currently tied overall with " + winCount + " wins each and " + drawCount + " draws.");
                }

                Console.Write("\nPlay again? (Y/N): ");
                sameOpponent = Console.ReadLine();
            }
        }
    }
}
