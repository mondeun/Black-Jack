using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    public class BlackJack
    {
        private Dealer _dealer;
        private List<IPlayer> _players;
        private int pot;

        public BlackJack()
        {
            _dealer = new Dealer();
            _players = new List<IPlayer>();
            pot = 0;
        }

        public void Initialize() { }

        public void NewRound() { }

        public void Play() { }
    }
}
