using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.RollDice;

namespace RPG.Equipment.Weapons
{
    public abstract class AbstractWeapon : IWeapon
    {
        private Random randomSeed = new Random();
        private Dice dice;

        public abstract string Damage();
        public abstract WeaponTypeEnum WeaponType();
        public abstract int Weight();

        public int Attack()
        {
            return DiceParser.Roll(this.Damage(), randomSeed);
        }

        public int Value()
        {
            return 0;
        }

        public string Critical()
        {
            return "*1";
        }

        public int CriticalMinimumRoll()
        {
            return 20;
        }
    }
}
