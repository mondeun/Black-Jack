using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Deck
    {
        private Card[] _cards;
        private int _index;

        public Deck()
        {
            _cards = new Card[52];
            _index = 0;
            Initialize();
        }

        private void Initialize()
        {
            var cardValue = 1;

            for (int i = 0; i < _cards.Length; i++)
            {
                if (cardValue%13 == 0)
                    cardValue = 0;
                switch (i)
                {
                    case 0:
                        _cards[i] = new Card("♣", cardValue);
                        break;
                    case 1:
                        _cards[i] = new Card("♦", cardValue);
                        break;
                    case 2:
                        _cards[i] = new Card("♥", cardValue);
                        break;
                    case 3:
                        _cards[i] = new Card("♠", cardValue);
                        break;
                }

                cardValue++;
            }
        }

        public void Shuffle()
        {
            _index = 0;
            var rnd = new Random();

            for (int i = 0; i < _cards.Length; i++)
            {
                SwapCards(i, rnd.Next(_cards.Length));
            }
        }

        private void SwapCards(int card1, int card2)
        {
            var tmpCard = _cards[card1];
            _cards[card1] = _cards[card2];
            _cards[card2] = tmpCard;
        }
        
        public Card HandOutCard()
        {
                return _cards[_index++ % 52];
        }
    }
}
