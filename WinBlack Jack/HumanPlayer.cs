using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack;
using BlackJack.Players;

namespace WinBlack_Jack
{
    public class HumanPlayer : IPlayer
    {
        public Guid Id { get; }
        public Hand Hand { get; }
        public string Name { get; }

        public int Balance { get; }

        public HumanPlayer(string name, int money)
        {
            Id = Guid.NewGuid();
            Hand = new Hand();
            Name = name;
            Balance = money;
        }

        public int MakeBet(int bet)
        {
            return bet;
        }

        public PlayerDecision ProcessDecision(int bet)
        {
            return PlayerDecision.Hit;
        }
    }
}
