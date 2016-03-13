using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Bank
    {
        private static Dictionary<Guid, int> _bets;
        private static Dictionary<Guid, int> _balance; 

        public Bank()
        {
            _bets = new Dictionary<Guid, int>();
            _balance= new Dictionary<Guid, int>();
        }

        public void AddPlayerBet(Guid id, int bet)
        {
            if (_balance[id] < bet)
                return;

            if (!_bets.ContainsKey(id))
            {
                _bets.Add(id, bet);
                _balance[id] -= bet;
            }
        }

        public void AddMoneyToPlayer(Guid id, int money)
        {
            if (!_balance.ContainsKey(id))
                _balance.Add(id, money);
            else
                _balance[id] += money;
        }
        public void CheckBalances(Players.Dealer dealer,List<Players.IPlayer> players)
        {
            //checks whether anyone is out of cash (incl. dealer)
            //and if so, sets "isBankrupt" to true
            foreach(Players.IPlayer playr in players)
            {
                if (GetPlayerMoney(playr.Id) == 0)
                    playr.isBankrupt = true;
            }
            if (GetPlayerMoney(dealer.Id) == 0)
                dealer.isBankrupt = true;
        }
        public void ExcludeBankruptPlayers(Players.Dealer dealer,List<Players.IPlayer>players)
        {
            //checks whether anyone is "bankrupt (incl. dealer)
            //and if so, removes everything associated with the player
            foreach (Players.IPlayer playr in players)
            {
                //TODO: also remove broke player from list<IPlayer>
                if (playr.isBankrupt)
                    RemovePlayer(playr.Id);
            }
            if (dealer.isBankrupt)
                RemovePlayer(dealer.Id);
        }
        private void RemovePlayer(Guid id)
        {
            _bets.Remove(id);
            _balance.Remove(id);
        }
        
        public void ClearBets()
        {
            _bets.Clear();
        }

        public static int GetPlayerBet(Guid id) => _bets[id];

        public static int GetPlayerMoney(Guid id) => _balance[id];
    }
}
