﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.Equipment
{
    public interface IHandCombatItem : IItem
    {
        bool IsTwoHanded();
    }
}
