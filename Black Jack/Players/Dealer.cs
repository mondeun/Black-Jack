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

        public Dealer()
        {
            Id = Guid.NewGuid();
            Hand = new Hand();
        }

        public PlayerDecision ProcessDecision(Hand hand)
        {
            if(BlackJackRules.GethandValue(Hand) >= 17)
                return PlayerDecision.Stay;
            return PlayerDecision.Hit;
        }

        public int MakeBet()
        {
            //TODO: betting process for computer player
            //use banks static method to check his money
            //and decide how much to bet
            var cash = Bank.GetPlayerMoney(Id);

            if (cash <= 50)
                return 2;
            else if (cash <= 100)
                return 5;
            else if (cash <= 200)
                return 10;
            else
                return 1;
        }
    }
}
