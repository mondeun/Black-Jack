using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    interface IPlayer
    {
        Card[] hand { get; set; }
        
        int Money { get; set; }

        void MakeMove();

        int MakeBet(int bet);

        void TakeNewCard(Card card);

        string GetHandString();

        void TakePot(int money);
    }
}
