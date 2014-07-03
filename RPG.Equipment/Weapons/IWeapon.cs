using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.Equipment;

namespace RPG.Equipment.Weapons
{
    public interface IWeapon : IHandCombatItem
    {
        string Critical();
        int CriticalMinimumRoll();
        string Damage();
        int Attack();
        WeaponTypeEnum WeaponType();
    }
}
