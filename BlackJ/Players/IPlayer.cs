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

        string Name { get; }

        int Balance { get; }

        int MakeBet(int bet = 0);

        PlayerDecision ProcessDecision(int bet);
    }
}
