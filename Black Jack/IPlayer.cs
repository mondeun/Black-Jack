using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    interface IPlayer
    {
        void MakeMove();

        bool MakeBet(int bet);

        void TakeNewCard(Card card);

        string GetHandString();

        void TakePot(int money);
    }
}
