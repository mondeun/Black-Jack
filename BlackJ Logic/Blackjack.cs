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
        private Dealer dealer;
        private List<IPlayer> players;
        public Dealer Dealer
        {
            get { return dealer; }
        }
        public List<IPlayer>Players
        {
            get { return players; }
        }

        Bank bank;
        Deck deck;

        public Blackjack(int dealerStartMoney)
        {
            bank = new Bank();
            dealer = new Dealer();
            bank.AddMoneyToPlayer(dealer.Id, dealerStartMoney);
            players = new List<IPlayer>();
        }
        public void NewRound()
        {
            // only clearing bets and refreshing deck
            bank.ClearBets();
            InitializeDeck();
        }
        public void NewGame()
        {
            // complete initialize plus removal of players 
            NewRound();

            foreach (IPlayer player in players)
            {
                bank.RemovePlayer(player.Id);
            }
            bank.RemovePlayer(dealer.Id);
        }
        public void AddPlayer(IPlayer newPlayer, int startBalance=0)
        {
            players.Add(newPlayer);
            bank.AddMoneyToPlayer(newPlayer.Id, startBalance);
        }
        public void AddMoney(IPlayer player,int playerMoney)
        {
            bank.AddMoneyToPlayer(player.Id, playerMoney);
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
