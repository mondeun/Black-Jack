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
    }
}
