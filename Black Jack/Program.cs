using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.Players;


namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Blackjack(100);

            //test of game flow:
            game.AddPlayer(new HumanConsolePlayer(), 100);
            game.AddPlayer(new ComputerPlayer(), 100);
            game.PlaceBets();
            game.InitialDeal();
            game.PlayerTurns();
        }
    }
}
