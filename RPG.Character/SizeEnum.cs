using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace RPG.Character
{
    public enum SizeEnum
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
        public static int SizeModifier(SizeEnum size)
        {
            Dictionary<SizeEnum, int> d = new Dictionary<SizeEnum, int>() 
            { 
                { SizeEnum.Colossal, -8 }, 
                { SizeEnum.Gargantuan, -4 }, 
                { SizeEnum.Huge, -2 }, 
                { SizeEnum.Large, -1 }, 
                { SizeEnum.Medium, 0 }, 
                { SizeEnum.Small, 1 }, 
                { SizeEnum.Tiny, 2 }, 
                { SizeEnum.Dimunitive, 4 }, 
                { SizeEnum.Fine, 8 } 
            };

            return d[size];
        }
    }
    
}
