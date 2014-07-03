using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.Equipment.Weapons.Martial
{
    class ShortSword : AbstractWeapon
    {
        public override string Damage()
        {
            return "1d6";
        }

        public override WeaponTypeEnum WeaponType()
        {
            return WeaponTypeEnum.Piercing;
        }

        public override int Weight()
        {
            return 2;
        }

        public int Value()
        {
            return 10;
        }

        public string Critical()
        {
            return "*2";
        }

        public int CriticalMinimumRoll()
        {
            return 19;
        }
    }
}
