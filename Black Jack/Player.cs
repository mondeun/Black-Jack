using System;
using System.Collections.Generic;

namespace Black_Jack
{
    abstract class Player : IPlayer
    {
        protected List<Card> _hand;
        protected int _money;

        public Player(int startMoney)
        {
            _hand = new List<Card>();
            _money = startMoney;
        }

        public void MakeMove()
        {
            throw new NotImplementedException();
        }

        public void ResetHand()
        {
            _hand.Clear();
        }

        public bool MakeBet(int bet)
        {
            return true;
        }

        public void TakeNewCard(Card card)
        {
            throw new NotImplementedException();
        }

        public string GetHandString()
        {
            throw new NotImplementedException();
        }

        public void TakePot(int money) => _money += money;
    }
}
