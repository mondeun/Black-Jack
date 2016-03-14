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
            //TODO: finalize method, have a list<IPlayer> being
            //evaluated against dealer and deciding winners/losers
            //against the dealer (not amongst players themselves). 
            return 0;
        }

        public static int GethandValue(Hand hand)
        {
            //TODO: implement Ace values 1 and 11
            //Blackjack specific rules for counting handvalue:
            var sum = 0;
            foreach (var card in hand.Cards)
            {
                //Faces (J,Q,K) have value 10
                if (card.Value > 10)
                    sum += 10;
                else
                    sum += card.Value;
            }
            return sum;
        }
    }
}
