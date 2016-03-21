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
        private readonly Bank _bank;
        private Deck _deck;

        public Dealer Dealer { get; private set; }

        public List<IPlayer> Players { get; private set; }

        public Blackjack(int dealerStartMoney = 100)
        {
            _bank = new Bank();
            Dealer = new Dealer();
            _bank.AddMoneyToPlayer(Dealer.Id, dealerStartMoney);
            Players = new List<IPlayer>();
        }

        public void NewRound()
        {
            _bank.ClearBets();
            InitializeDeck();
        }

        public void NewGame()
        {
            NewRound();

            foreach (IPlayer player in Players)
            {
                _bank.RemovePlayer(player.Id);
            }
            _bank.RemovePlayer(Dealer.Id);
        }

        public void AddPlayer(IPlayer newPlayer, int startBalance=0)
        {
            Players.Add(newPlayer);
            _bank.AddMoneyToPlayer(newPlayer.Id, startBalance);
        }

        public void AddMoney(IPlayer player,int playerMoney)
        {
            _bank.AddMoneyToPlayer(player.Id, playerMoney);
        }

        public void InitializeDeck()
        {
            _deck = new Deck();//initializes deck for every new round
            _deck.Shuffle();
        }

        public void InitialDeal()
        {
            for (int i = 0; i < 2; i++)
            {
                foreach (var player in Players)
                {
                    GiveCardTo(player, _deck);
                }
                GiveCardTo(Dealer, _deck);
            }
        }

        public PlayerDecision PlayerTurn(IPlayer player)
        {
            // TODO Add players turn handling
            return player.ProcessDecision(player.Hand);
        }

        public void GiveCardTo(IPlayer player, Deck deck)
        {
            player.Hand.AddCard(deck.HandOutCard());
        }

        public BetValidity PlaceBet(IPlayer player)
        {
            return _bank.AddPlayerBet(player.Id, player.MakeBet());
        }
    }
}
