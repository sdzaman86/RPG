using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.Equipment.Weapons.Unarmed
{
    public class Hands : AbstractWeapon
    {
        public override string Damage()
        {
            return "1d2";
        }

        public override WeaponTypeEnum WeaponType()
        {
            return WeaponTypeEnum.Bludgeoning;
        }

        public override int Weight()
        {
            return 0;
        }

        public string Critical()
        {
            return "*2";
        }
    }
}
