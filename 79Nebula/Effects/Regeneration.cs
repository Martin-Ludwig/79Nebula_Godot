﻿using Nebula._79Nebula.Enums;
using Nebula._79Nebula.Interfaces;
using Nebula._79Nebula.Models;
using Nebula._79Nebula.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nebula._79Nebula.Effects
{
    public class Regeneration : Effect, IStackable
    {
        public override string Name => "Regeneration";
        public override string Description => $"{Name} heals you for {_base} + Healing * {_coefficient} at the end of every round.";
        public override List<EffectType> EffectTypes => new List<EffectType>(){
            EffectType.Buff,
            EffectType.Boon
        };

        private const int _base = PlayerBase.MajorMultiplier + PlayerBase.MinorMultiplier;
        private const double _coefficient = 0.125;

        public Regeneration(int stacks = 1)
        {
            AddStack(stacks);
        }


        public override void OnRoundEnd(Player player)
        {
            double healing = _base + player.Healing * _coefficient;
            player.GainHealth(healing * StackSize);
        }

    }
}
