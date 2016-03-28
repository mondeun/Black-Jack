﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackJack;

namespace WinBlack_Jack
{
    public class CardGraphicsMapper
    {
        private readonly Dictionary<string, Bitmap> _cardDictionary;

        public CardGraphicsMapper()
        {
            _cardDictionary = new Dictionary<string, Bitmap>();
        }

        private void Map(string[] cardStrings)
        {
            for (int i = 0; i < cardStrings.Length; i++)
            {
                _cardDictionary.Add(cardStrings[i], new Bitmap(@"Cards/" + (i + 1)));
            }
        }

        public Bitmap GetBitmap(string card)
        {
            return _cardDictionary.ContainsKey(card) ? _cardDictionary[card] : null;
        }
    }
}
