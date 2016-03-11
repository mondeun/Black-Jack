using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack.Players;

namespace BlackJack
{
    public enum PlayerDecision
    {
        Hit,
        Stay
    }

    public class Blackjack
    {
        Bank bank = new Bank();
        Dealer dealer = new Dealer();
        IPlayer player = new HumanConsolePlayer();
        Deck deck;
        bool NoBankrupcy = true;//false when someone is bankrupt
        
        public void Run()
        {
            while(NoBankrupcy)//for as long as theres no bankrupt player, do the loop
            {
                Initialize();
                PlaceBets();
                InitialDeal();

                PlayerTurn(player);
                PlayerTurn(dealer);
            }
        }
        private void Initialize()
        {
            deck = new Deck();//initializes deck for every new round
            deck.Shuffle();
        }
        private void InitialDeal()
        {
            for (int i = 0; i < 2; i++)
            {
                GiveCardTo(player, deck);
                GiveCardTo(dealer, deck);
            }
        }

        public void PlayerTurn(IPlayer player)
        {

        }

        public void GiveCardTo(IPlayer player, Deck deck)
        {
            player.Hand.AddCard(deck.HandOutCard());
        }

        public void PlaceBets()
        {
            bank.AddPlayerBet(player.Id,player.MakeBet());
            bank.AddPlayerBet(dealer.Id, dealer.MakeBet());
        }
    }
}
