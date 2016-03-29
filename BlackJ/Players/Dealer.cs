using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Players
{
    public class Dealer : IPlayer
    {
        public Guid Id { get; }

        public Hand Hand { get; }

        public string Name { get; }

        public int Balance { get; }

        public Dealer()
        {
            Id = Guid.NewGuid();
            Hand = new Hand();
            Name = "Dealer";
            Balance = 1000;
        }

        public PlayerDecision ProcessDecision(int bet)
        {
            if(BlackJackRules.GethandValue(Hand) >= 17)
                return PlayerDecision.Stay;
            return PlayerDecision.Hit;
        }

        public int MakeBet(int bet)
        {
            if (Balance <= 50)
                return 2;
            if (Balance <= 100)
                return 5;
            if (Balance <= 200)
                return 10;
            return 1;
        }
    }
}
