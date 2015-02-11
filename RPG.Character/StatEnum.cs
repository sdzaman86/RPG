using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace RPG.Character
{
    public enum StatEnum
    {
        Fine,
        Dimunitive,
        Tiny,
        Small,
        Medium,
        Large,
        Huge,
        Gargantuan,
        Colossal
    }

    public static class SizeAttackModifier
    {
        public static int SizeModifier(StatEnum size)
        {
            Dictionary<StatEnum, int> d = new Dictionary<StatEnum, int>() 
            { 
                { StatEnum.Colossal, -8 }, 
                { StatEnum.Gargantuan, -4 }, 
                { StatEnum.Huge, -2 }, 
                { StatEnum.Large, -1 }, 
                { StatEnum.Medium, 0 }, 
                { StatEnum.Small, 1 }, 
                { StatEnum.Tiny, 2 }, 
                { StatEnum.Dimunitive, 4 }, 
                { StatEnum.Fine, 8 } 
            };

            return d[size];
        }
    }
    
}
