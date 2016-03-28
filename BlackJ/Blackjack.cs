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
            Players = new List<IPlayer>();
            _deck = new Deck();

            _bank.AddMoneyToPlayer(Dealer.Id, dealerStartMoney);

        }

        public Blackjack(List<IPlayer> playerList, Bank bank, int dealerStartMoney = 100) : this(dealerStartMoney)
        {
            Players.AddRange(playerList);
            _bank = bank;
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

        public void InitialDeal()
        {
            for (int i = 0; i < 2; i++)
            {
                foreach (var player in Players)
                {
                    GiveCardTo(player);
                }
                GiveCardTo(Dealer);
            }
        }

        public PlayerDecision PlayerTurn(IPlayer player)
        {
            // TODO Add players turn handling
            return player.ProcessDecision(player.Hand);
        }

        public void GiveCardTo(IPlayer player)
        {
            player.Hand.AddCard(_deck.HandOutCard());
        }

        public BetValidity PlaceBet(IPlayer player)
        {
            return _bank.AddPlayerBet(player.Id, player.MakeBet());
        }

        public string[] GetCardStrings() => _deck.GetCardStrings();

        private void InitializeDeck()
        {
            _deck.Shuffle();
        }
    }
}
