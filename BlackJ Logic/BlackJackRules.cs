﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Players
{
    /// <summary>
    /// Who got the winning hand
    /// </summary>
    public enum Winninghand
    {
        Dealer,
        Player,
        Draw
    }

    /// <summary>
    /// Apply Rules to a Black Jack game
    /// </summary>
    public class BlackJackRules
    {
        /// <summary>
        /// Decide if the dealer or player win
        /// </summary>
        /// <param name="dealer">A dealers hand</param>
        /// <param name="player">A players hand</param>
        /// <returns>Who got the winning hand</returns>
        public static Winninghand EvaluateWinner(Hand dealer, Hand player)
        {
            var dealerHandValue = GethandValue(dealer);
            var playerHandValue = GethandValue(player);
            
            if (dealerHandValue == playerHandValue)
                return Winninghand.Draw;

            return playerHandValue > dealerHandValue ? Winninghand.Player : Winninghand.Dealer;
        }
        
        /// <summary>
        /// Get a hands value in Black Jack
        /// </summary>
        /// <param name="hand">A player hand</param>
        /// <returns>Value of the given hand</returns>
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
