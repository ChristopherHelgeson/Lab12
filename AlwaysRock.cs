using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12___classes
{
    class AlwaysRock : Player
    {
        public override string OpponentName()
        {
            string opponentName = "Mr. Predictable";
            return opponentName;
        }

        public override string GenerateRoshambo()
        {
            string opponentThrow = "Rock";
            return opponentThrow;
        }
    }
}