using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12___classes
{
    class Status
    {
        private static int loseCount;
        private static int winCount;
        private static int drawCount;

        public static int LoseCount()
        {
            loseCount++;
            return loseCount;
        }

        public static int WinCount()
        {
            winCount++;
            return winCount;
        }

        public static int DrawCount()
        {
            drawCount++;
            return drawCount;
        }

        public static void WinCount(string playerThrow, string opponentThrow)
        {
            if (playerThrow == "Rock" && opponentThrow == "Paper")
            {
                Console.WriteLine("You lose.");
                LoseCount();
            }
            else if (playerThrow == "Rock" && opponentThrow == "Scissors")
            {
                Console.WriteLine("You win!");
                WinCount();
            }
            else if (playerThrow == "Paper" && opponentThrow == "Rock")
            {
                Console.WriteLine("You win!");
                WinCount();
            }
            else if (playerThrow == "Paper" && opponentThrow == "Scissors")
            {
                Console.WriteLine("You lose.");
                LoseCount();
            }
            else if (playerThrow == "Scissors" && opponentThrow == "Rock")
            {
                Console.WriteLine("You lose.");
                LoseCount();
            }
            else if (playerThrow == "Scissors" && opponentThrow == "Paper")
            {
                Console.WriteLine("You win!");
                WinCount();
            }
            else
            {
                Console.WriteLine("A draw!");
                DrawCount();
            }
        }

        public static void PrintScore()
        {
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
        }
    }
}

