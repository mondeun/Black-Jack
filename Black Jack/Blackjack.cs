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
        Bank bank = new Bank();
        Dealer dealer = new Dealer();
        List<IPlayer> players = new List<IPlayer>();
        Deck deck;

        public void AddPlayer(IPlayer newPlayer)
        {
            players.Add(newPlayer);
        }
        public void InitialCashDistribution(int initialMoney)
        {
            foreach(IPlayer playr in players)
            {
                bank.AddMoneyToPlayer(playr.Id, initialMoney);
            }
            bank.AddMoneyToPlayer(dealer.Id, initialMoney);
        }
        public void Initialize()
        {
            deck = new Deck();//initializes deck for every new round
            deck.Shuffle();
            bank.ExcludeBankruptPlayers(dealer,players);//removes any broke player for every new round 
        }
        public void InitialDeal()
        {
            //TODO: check if method works properly
            for (int i = 0; i < 2; i++)
            {
                foreach (IPlayer playr in players)
                {
                    GiveCardTo(playr, deck);
                }
                GiveCardTo(dealer, deck);
            }
        }
        public void PlayerTurns()
        {
            //TODO: implement so that players can hit more than once

            //Player: hits or stays
            foreach (IPlayer playr in players)
            {
                PlayerDecision playerDecision = playr.ProcessDecision(playr.Hand);
                if (playerDecision == PlayerDecision.Hit)
                    GiveCardTo(playr, deck);
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
            foreach (IPlayer playr in players)
            {
                bank.AddPlayerBet(playr.Id, playr.MakeBet());
            }
            bank.AddPlayerBet(dealer.Id, dealer.MakeBet());
        }
    }
}
