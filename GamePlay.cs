using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12___classes
{
    class GamePlay
    {
        Player opponent = null;

        public GamePlay()
        {
            string playerName = GetUserName();
            SelectOpponent(playerName);

            string sameOpponent = "Y";
            while (sameOpponent == "Y" || sameOpponent == "y")
            {
                string playerThrow = PlayerThrow();
                string opponentThrow = OpponentThrow(opponent);
                ThrowDisplay(playerName, playerThrow, opponent, opponentThrow);
                Status.WinCount(playerThrow, opponentThrow);
                Status.PrintScore();

                Console.Write("\nPlay again? (Y/N): ");
                sameOpponent = Console.ReadLine();
            }
        }

        public static string GetUserName()
        {
            Console.Write("\nPlease enter your name: ");
            string playerName = Console.ReadLine();
            Console.WriteLine("\nWelcome, " + playerName + ". Have fun playing!");
            return playerName;
        }

        public Player SelectOpponent(string playerName)
        {
            Console.WriteLine("\nPlease select an opponent:");
            Console.WriteLine("\n\t1) Mr. Predictable");
            Console.WriteLine("\t2) DJ MixR");
            Console.Write("\nYour selection?: ");
            int opponentNum = int.Parse(Console.ReadLine());

            while (opponentNum < 1 || opponentNum > 2)
            {
                Console.Write("Not a valid selection. Please try again: ");
                opponentNum = int.Parse(Console.ReadLine());
            }
            switch (opponentNum)
            {
                case 1:
                    Console.WriteLine("\nYou have chosen wisely, " + playerName + ".");
                    opponent = new AlwaysRock();
                    break;
                case 2:
                    Console.WriteLine("\nNot so smart, are you? Prepare to lose,  " + playerName + ".");
                    opponent = new RandomDude();
                    break;
            }
            return opponent;
        }

        public static string PlayerThrow()
        {
            string playerThrow = string.Empty;
            while (playerThrow != "r" && playerThrow != "p" && playerThrow != "s")
            {
                Console.Write("\nRock, Paper, or Scissors? (R/P/S): ");
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
            return playerThrow;
        }

        public static string OpponentThrow(Player opponent)
        {
            string opponentThrow = opponent.GenerateRoshambo();
            return opponentThrow;
        }

        public static void ThrowDisplay(string playerName, string playerThrow, Player opponent, string opponentThrow)
        {
            Console.WriteLine("\n" + playerName + ": " + playerThrow);
            Console.WriteLine(opponent.OpponentName() + ": " + opponentThrow);
            Console.WriteLine();
        }
    }
}
