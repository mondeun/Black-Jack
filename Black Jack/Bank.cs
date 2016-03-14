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
