using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.Players;

namespace BlackJack
{
    public class HumanConsolePlayer : IPlayer
    {
        public Guid Id { get; }

        public Hand Hand { get; }

        public HumanConsolePlayer()
        {
            Id = Guid.NewGuid();
            Hand = new Hand();
        }

        public PlayerDecision ProcessDecision(Hand hand)
        {
            if (BlackJackRules.GethandValue(Hand) >= 21)
                return PlayerDecision.Stay;

            Console.Write("Hit or Stay (h/s)? >> ");
            var choice = Console.ReadLine();

            return choice == "h" ? PlayerDecision.Hit : PlayerDecision.Stay;
        }

        public int MakeBet()
        {
            //Betting process for human players:
            var invalidBet = true;
            var bet = 0;

            do
            {
                Console.Write("Enter Bet (1-10): ");

                while (!int.TryParse(Console.ReadLine(), out bet))
                    Console.WriteLine("Please enter a bet between 1-10: ");
                if (bet < 1 || bet > 10)
                {
                    Console.WriteLine("Bet not accepted. Place a bet between 1-10: ");
                    invalidBet = true;
                }
                else
                    invalidBet = false;
            } while (invalidBet);

            Console.WriteLine("Placed a bet of {0}", bet);
            return bet;
        }
    }
}
