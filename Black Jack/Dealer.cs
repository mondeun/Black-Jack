using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class Dealer : Player
    {
        int Money { get; set; }
        public void MakeMove()
        {

        }
        public int CheckHandValue(Card [] hand)
        {
            int total = 0;
            for (int i = 0; i < hand.Length; i++)
            {
                /*need to have the card value property
                as a INTEGER type to be able to calculate 
                hand value and return it!!*/
                if (hand[i].Value != 0)
                    total += hand[i].Value;
            }
            return total;
        }
    }
}
