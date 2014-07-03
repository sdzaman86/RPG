using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.Character.Class;

namespace RPG.Character.Race
{
    public class HalfOrc : AbstractCharacter
    {
        public HalfOrc()
        {
            this._Race = RaceEnum.HalfOrc;    
            this._Languages = new List<LanguageEnum>() { LanguageEnum.Common, LanguageEnum.Orc };
            this._StatModifierDict = new Dictionary<string, int>() { { "Strength", 2 }, { "Intelligence", -2 }, { "Charisma", -2 } };
        }
    }
}
