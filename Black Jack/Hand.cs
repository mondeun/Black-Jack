using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Hand
    {
        public List<Card> Cards { get; private set; }

        public Hand()
        {
            Cards = new List<Card>();
        }

        public int GetStraighthandValue()
        {
            var sum = 0;
            foreach (var card in Cards)
            {
                sum += card.Value;
            }
            return sum;
        }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }
    }
}
