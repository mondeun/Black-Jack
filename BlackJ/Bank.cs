using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{/*
    public class Bank
    {
        private static Dictionary<Guid, int> _bets;
        private static Dictionary<Guid, int> _balance; 

        public Bank()
        {
            _bets = new Dictionary<Guid, int>();
            _balance= new Dictionary<Guid, int>();
        }

        public BetValidity AddPlayerBet(Guid id, int bet)
        {
            // We only add new bets and won't allow changes to existing bets
            if (_bets.ContainsKey(id))
                return BetValidity.InvalidBet;

            if (_balance[id] <= 0)
                return BetValidity.NotEnoughMoney;

            if (_balance[id] < bet)
                return BetValidity.BetTooHigh;

            _bets.Add(id, bet);
            _balance[id] -= bet;

            return BetValidity.Ok;
        }

        public void AddMoneyToPlayer(Guid id, int money)
        {
            if (!_balance.ContainsKey(id))
                _balance.Add(id, money);
            else
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

        public int GetPMoney(Guid id) => _balance[id];

        public static int GetPlayerBet(Guid id) => _bets[id];

        public static int GetPlayerMoney(Guid id)
        {
            return _balance.Count;
        }
    }*/
}
