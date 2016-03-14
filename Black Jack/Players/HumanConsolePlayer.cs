using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Players
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
            bool isInvalid = true;
            int bet = 0;

            while (isInvalid)
            {
                Console.Write("Enter Bet (1-10): ");
                bet = int.Parse(Console.ReadLine());

                if (bet < 1 || bet > 10)
                    Console.WriteLine("Invalid bet");
                else
                    isInvalid = false;
            }
            Console.WriteLine("Bet valid");
            return bet;
        }
    }
}
