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
    /// Contains standard procedures (during a
    /// game of blackjack) such as which players 
    /// are joining a game, cards being dealt, 
    /// bets being placed, players deciding 
    /// on hitting or staying etc. 
    /// </summary>
    public class Blackjack
    {
        Bank bank;
        Dealer dealer = new Dealer();
        List<IPlayer> players = new List<IPlayer>();
        Deck deck;

        public Blackjack()
        {
            bank = new Bank();
        }
        public void AddPlayer(IPlayer newPlayer, int startMoney)
        {
            players.Add(newPlayer);
            bank.AddMoneyToPlayer(newPlayer.Id, startMoney);
        }
        public void Initialize()
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
