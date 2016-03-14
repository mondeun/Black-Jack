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

            var game = new Blackjack(500);
            game.InitializeDeck();

            HumanConsolePlayer player1 = new HumanConsolePlayer();
            ComputerPlayer player2 = new ComputerPlayer();

            //test of game flow:
            game.AddPlayer(player1);
            game.AddPlayer(player2);
            game.AddMoney(player1, 100);
            game.AddMoney(player2, 100);
            game.PlaceBets();
            game.InitialDeal();
            game.PlayerTurns();
        }
    }
}
