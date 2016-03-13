using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Players
{
    public interface IPlayer
    {
        Guid Id { get; }

        Hand Hand { get; }
        bool isBankrupt { get; set; }

        int MakeBet();

        PlayerDecision ProcessDecision(Hand hand);
    }
}
