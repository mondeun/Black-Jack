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
            var sum = 0;
            foreach (var card in hand.Cards)
            {
                if (card.Value >= 2 && card.Value <= 10)
                    sum += card.Value;
                // Faces (J, Q, K) have value 10
                else if (card.Value > 10)
                    sum += 10;

                // Decide if an Ace is worth 1 or 11
                if (card.Value == 1)
                {
                    // This gives Black Jack (sum = 21) 
                    // and counts towards highest possible value
                    if (sum <= 10)
                        sum += 11;
                    else
                        sum += 1;
                }
            }
            return sum;
        }
    }
}
