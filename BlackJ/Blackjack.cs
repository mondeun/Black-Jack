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
        private Bank _bank;
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

        public void AddPlayer(IPlayer newPlayer)
        {
            Players.Add(newPlayer);
        }

        public bool RemovePlayer(IPlayer player)
        {
            if (Players.Remove(player))
            {
                _bank.RemovePlayer(player.Id);
                return true;
            }
            return false;
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

        public int GetPlayerMoney(int pos) => _bank.GetPMoney(Players[pos].Id);

        public int GetBet(Guid id) => Bank.GetPlayerBet(id);

        public string[] GetCardStrings() => _deck.GetCardStrings();

        private void InitializeDeck()
        {
            _deck.Shuffle();
        }
    }
}
