using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Card 
    {
        public string Suite { get; }

        public int Value { get; }

        public bool IsHidden { get; private set; }

        public Card(string suite, int value, bool isHidden = false)
        {
            Suite = suite;
            Value = value;
            IsHidden = isHidden;
        }

        public void ToggleHidden()
        {
            IsHidden = !IsHidden;
        }

        public override string ToString()
        {
            return Value + Suite;
        }
    }
}
