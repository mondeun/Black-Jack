using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Players
{
    public class ComputerPlayer : IPlayer
    {
        public Guid Id { get; }

        public Hand Hand { get; }

        public string Name { get; }

        public int Balance { get; private set; }

        public ComputerPlayer(string name, int money)
        {
            Id = Guid.NewGuid();
            Hand = new Hand();
            Name = name;
            Balance = money;
        }

        public PlayerDecision ProcessDecision(int bet)
        {
            var handValue = BlackJackRules.GethandValue(Hand);

            if (bet > 7)
            {
                return handValue > 16 ? PlayerDecision.Stay : PlayerDecision.Hit;
            }

            return handValue > 18 ? PlayerDecision.Stay : PlayerDecision.Hit;
        }

        public int MakeBet(int bet = 0)
        {
            if (Balance <= 20)
                bet = 2;
            else if (Balance <= 50)
                bet =  7;
            else if (Balance <= 100)
                bet = 10;

            Balance -= bet;
            return bet;
        }
    }
}
