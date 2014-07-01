using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.RollDice;

namespace RPG.Weapons
{
    public abstract class AbstractWeapon : IWeapon
    {
        private Dice dice;

        public string DamageDescription()
        {
            return string.Format("{0}d{2}", this.NumDice(), this.MaxDamage());
        }
 
        public int NumDice()
        {
            return 1;
        }

        public abstract int MaxDamage();

        public int Attack()
        {
            dice = new Dice(this.NumDice(), this.MaxDamage());
            return dice.Roll();
        }

        public int Value()
        {
            return 0;
        }
    }
}
