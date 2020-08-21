﻿using System.Collections.Generic;

namespace Nebula._79Nebula.Models
{
    /// <summary>
    /// EffectList is an extended List<Effect> object.
    /// </summary>
    public class EffectList : List<Effect>
    {
        public int CountActive { get { return this.FindAll(o => o.IsActive).Count; } }

        /// <summary>
        /// Executes OnRoundStart() for each effect.
        /// </summary>
        public void OnRoundStart(Player player)
        {
            this.ForEach(o => {
                if (o.IsActive)
                {
                    o.OnRoundStart(player);
                }
            });
        }

        /// <summary>
        /// Executes OnRoundEnd() for each effect.
        /// </summary>
        public void OnRoundEnd(Player player)
        {
            this.ForEach(o => {
                if (o.IsActive)
                {
                    o.OnRoundEnd(player);
                }
            });
        }

        /// <summary>
        /// Executes OnCrit() for each effect.
        /// </summary>
        public void OnCrit(Player player, ref int valueOut)
        {
            foreach (Effect effect in this)
            {
                if (effect.IsActive)
                {
                    effect.OnCrit(player, ref valueOut);
                }
            }
        }

        /// <summary>
        /// Executes OnCritAttack() for each effect.
        /// </summary>
        public void OnCritAttack(Player player, ref int damageOut, ref bool isUnblockable)
        {
            foreach (Effect effect in this)
            {
                if (effect.IsActive)
                {
                    effect.OnCritAttack(player, ref damageOut, ref isUnblockable);
                }
            }
        }

        /// <summary>
        /// Executes OnCritHeal() for each effect.
        /// </summary>
        public void OnCritHeal(Player player, ref int healingOut)
        {
            foreach (Effect effect in this)
            {
                if (effect.IsActive)
                {
                    effect.OnCritHeal(player, ref healingOut);
                }
            }
        }

        /// <summary>
        /// Executes OnIncomingCritAttack() for each effect.
        /// </summary>
        public void OnIncomingCritAttack(Player player, ref int damageIn)
        {
            foreach (Effect effect in this)
            {
                if (effect.IsActive)
                {
                    effect.OnIncomingCritAttack(player, ref damageIn);
                }
            }
        }

        /// <summary>
        /// Executes OnBarrerGain() for each effect.
        /// </summary>
        public void OnBarrerGain(Player player, ref int barrierIn)
        {
            foreach (Effect effect in this)
            {
                if (effect.IsActive)
                {
                    effect.OnBarrerGain(player, ref barrierIn);
                }
            }
        }

        /// <summary>
        /// Executes OnBarrierChange() for each effect.
        /// </summary>
        public void OnBarrierChange(Player player, ref int value)
        {
            foreach (Effect effect in this)
            {
                if (effect.IsActive)
                {
                    effect.OnBarrierChange(player, ref value);
                }
            }
        }

        /// <summary>
        /// Executes OnInitiation() for each effect.
        /// </summary>
        public void OnInitiation(Player player)
        {
            this.ForEach(o => {
                if (o.IsActive)
                {
                    o.OnInitiation(player);
                }
            });
        }

    }
}
