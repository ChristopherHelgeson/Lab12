using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12___classes
{
    class RandomDude : Player
    {
        public override string opponentName()
        {
            string opponentName = "DJ MixR";
            return opponentName;
        }

        public override string generateRoshambo()
        {
            Random rnd = new Random();
            string opponentThrow = string.Empty;
            int oppThrow = rnd.Next(1, 4);
            switch (oppThrow)
            {
                case 1:
                    opponentThrow = "Rock";
                    break;
                case 2:
                    opponentThrow = "Paper";
                    break;
                case 3:
                    opponentThrow = "Scissors";
                    break;
            }
            return opponentThrow;
        }
    }


}
