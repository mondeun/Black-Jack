using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class Card
    {

        public string Suit { get; private set; }

        public string Value { get; private set; }
        
        public Card(string _suit, string _value)
        {
            this.Suit = _suit;
            this.Value = _value;
        }
        public override string ToString()
        {
            return string.Format($"{Suit} {Value}");
        }
    }
}
