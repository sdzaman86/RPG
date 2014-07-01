using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.Weapons
{
    public interface IWeapon
    {
        int NumDice();
        int MaxDamage();
        int Attack();
    }
}
