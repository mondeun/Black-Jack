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

    /// <summary>
    /// external API to handle a game of blackjack
    /// </summary>
    public class Blackjack
    {
        Bank bank;
        Dealer dealer = new Dealer();
        List<IPlayer> players = new List<IPlayer>();
        Deck deck;

        public Blackjack(int dealerMoney)
        {
            bank = new Bank();
            InitializeDeck();
            bank.AddMoneyToPlayer(dealer.Id, dealerMoney);
        }
        public void AddPlayer(IPlayer newPlayer, int startMoney)
        {
            players.Add(newPlayer);
            bank.AddMoneyToPlayer(newPlayer.Id, startMoney);
        }
        public void InitializeDeck()
        {
            deck = new Deck();//initializes deck for every new round
            deck.Shuffle();
        }
        public void InitialDeal()
        {
            // TODO check if method works properly
            for (int i = 0; i < 2; i++)
            {
                foreach (IPlayer player in players)
                {
                    GiveCardTo(player, deck);
                }
                GiveCardTo(dealer, deck);
            }
        }
        public void PlayerTurns()
        {
            // TODO: implement so that players can hit more than once

            //Player: hits or stays
            foreach (IPlayer player in players)
            {
                PlayerDecision playerDecision = player.ProcessDecision(player.Hand);
                if (playerDecision == PlayerDecision.Hit)
                    GiveCardTo(player, deck);
            }
            //Dealer: hits or stays
            PlayerDecision dealerDecision = dealer.ProcessDecision(dealer.Hand);
            if (dealerDecision == PlayerDecision.Hit)
                GiveCardTo(dealer, deck);
        }
        public void GiveCardTo(IPlayer player, Deck deck)
        {
            player.Hand.AddCard(deck.HandOutCard());
        }
        public void PlaceBets()
        {
            foreach (IPlayer player in players)
            {
                bank.AddPlayerBet(player.Id, player.MakeBet());
            }
            bank.AddPlayerBet(dealer.Id, dealer.MakeBet());
        }
    }
}
