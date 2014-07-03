using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.Character.Class;

namespace RPG.Character.Race
{
    public class Dwarf : AbstractCharacter
    {
        public Dwarf()
        {
            this._Race = RaceEnum.Dwarf;            
            this._Languages = new List<LanguageEnum>() { LanguageEnum.Common, LanguageEnum.Dwarven };
            this._StatModifierDict = new Dictionary<string, int>() { { "Constitution", 2 }, { "Charisma", -2 } };
        }

        public int Speed()
        {
            return 20;
        }
    }
}
