using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Players
{
    /// <summary>
    /// Apply Rules to a Black Jack game
    /// </summary>
    public class BlackJackRules
    {
        public static int EvaluateWinner(Dealer dealer, IPlayer player)
        {
            return 0;
        }

        public static int GethandValue(Hand hand)
        {
            // TODO apply BJ specific values to sum

            var sum = 0;
            foreach (var card in hand.Cards)
            {
                sum += card.Value;
            }
            return sum;
        }
    }
}
