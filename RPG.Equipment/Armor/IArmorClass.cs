using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.Equipment.Armor
{
    public interface IArmorClass : IItem
    {
        int ArmorClass();
    }
}
