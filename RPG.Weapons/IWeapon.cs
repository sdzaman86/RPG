using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.Equipment;

namespace RPG.Weapons
{
    public interface IWeapon : IItem
    {
        int NumDice();
        int MaxDamage();
        int Attack();
    }
}
