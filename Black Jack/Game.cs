using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Game
    {
        private Blackjack blackjack;

        public Game()
        {
            blackjack = new Blackjack(100);
        }

        /// <summary>
        /// Play a game of Black Jack
        /// </summary>
        public void Run() { }
    }
}
