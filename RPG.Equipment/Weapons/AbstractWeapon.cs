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

        public AttackStruct Attack()
        {
            AttackStruct result = new AttackStruct();

            result.Roll = DiceParser.Roll("1d20", randomSeed);
            result.Damage = DiceParser.Roll(this.Damage(), randomSeed);

            if (result.Roll >= this.CriticalMinimumRoll())
                result.Damage = DiceParser.Roll(result.Damage + this.Critical(), randomSeed);

            return result;
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
