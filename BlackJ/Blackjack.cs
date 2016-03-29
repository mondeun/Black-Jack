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

    public enum BetValidity
    {
        NotEnoughMoney,
        BetTooHigh,
        InvalidBet,
        Ok
    }

    /// <summary>
    /// external API to handle a game of blackjack
    /// </summary>
    public class Blackjack
    {
        private Deck _deck;

        private Dictionary<Guid, int> _bets;

        public Dealer Dealer { get; private set; }

        public List<IPlayer> Players { get; private set; }

        public Blackjack()
        {
            Dealer = new Dealer();
            Players = new List<IPlayer>();
            _deck = new Deck();
            _bets = new Dictionary<Guid, int>();
        }

        public void NewRound()
        {
            _bets.Clear();
            InitializeDeck();
        }

        public void AddPlayer(IPlayer newPlayer)
        {
            Players.Add(newPlayer);
        }

        public bool RemovePlayer(IPlayer player)
        {
            if (Players.Remove(player))
            {
                _bets.Remove(player.Id);
                return true;
            }
            return false;
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
        /*
        public PlayerDecision PlayerTurn(IPlayer player)
        {
            // TODO Add players turn handling
            return player.ProcessDecision();
        }
        */
        public void GiveCardTo(IPlayer player)
        {
            player.Hand.AddCard(_deck.HandOutCard());
        }

        public BetValidity PlaceBet(IPlayer player, int bet)
        {
            // We only add new bets and won't allow changes to existing bets
            if (_bets.ContainsKey(player.Id))
                return BetValidity.InvalidBet;

            if (player.Balance <= 0)
                return BetValidity.NotEnoughMoney;

            if (player.Balance < bet)
                return BetValidity.BetTooHigh;

            _bets.Add(player.Id, bet);

            return BetValidity.Ok;
        }

        public string[] GetCardStrings() => _deck.GetCardStrings();

        private void InitializeDeck()
        {
            _deck.Shuffle();
        }
    }
}
