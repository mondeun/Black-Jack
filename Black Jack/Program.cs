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
            var game = new Blackjack();

            //test of game flow:
            game.Initialize();
            game.AddPlayer(new HumanConsolePlayer());
            game.AddPlayer(new ComputerPlayer());
            game.PlaceBets();
            game.InitialDeal();
            game.PlayerTurns();
        }
    }
}
