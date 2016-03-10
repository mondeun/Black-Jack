using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public interface IPlayer
    {
        Guid Id { get; }

        Hand Hand { get; }

        PlayerDecision ProcessDecision(Hand hand);
    }
}
