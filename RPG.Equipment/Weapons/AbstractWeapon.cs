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

        public abstract string Damage();
        public abstract WeaponTypeEnum WeaponType();
        public abstract int Weight();

        public int AttackRoll()
        {
            return DiceParser.Roll("1d20", randomSeed);
        }

        public int Attack()
        {
            int damage =  DiceParser.Roll(this.Damage(), randomSeed);
            if (damage>=this.CriticalMinimumRoll())
                damage = DiceParser.Roll(damage+this.Critical(), randomSeed);
            return damage;
        }

        public virtual int Value()
        {
            return 0;
        }

        public virtual string Critical()
        {
            return "*1";
        }

        public virtual int CriticalMinimumRoll()
        {
            return 20;
        }

        public virtual bool IsTwoHanded()
        {
            return false;
        }
    }
}
