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
            _bets.Add(id, bet);
            _balance[id] -= bet;
        }

        public void AddMoneyToPlayer(Guid id, int money)
        {
            _balance[id] += money;
        }

        public void RemovePlayer(Guid id)
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
