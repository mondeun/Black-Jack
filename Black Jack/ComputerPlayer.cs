﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBlackjack
{
    class ComputerPlayer : IPlayer
    {
        public Guid Id { get; }

        public Hand Hand { get; }

        public ComputerPlayer()
        {
            Id = Guid.NewGuid();
            Hand = new Hand();
        }
        public PlayerDecision ProcessDecision(Hand hand)
        {
            throw new NotImplementedException();
        }
    }
}
