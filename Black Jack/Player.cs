using System;

namespace Black_Jack
{
    abstract class Player : IPlayer
    {
        protected Card[] _hand;
        protected int money;

        public void MakeMove()
        {
            throw new NotImplementedException();
        }

        public int MakeBet(int bet)
        {
            throw new NotImplementedException();
        }

        public void TakeNewCard(Card card)
        {
            throw new NotImplementedException();
        }

        public string GetHandString()
        {
            throw new NotImplementedException();
        }

        public void TakePot(int money)
        {
            throw new NotImplementedException();
        }
    }
}
