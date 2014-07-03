using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.Character.Class;

namespace RPG.Character.Race
{
    public class Dwarf : AbstractCharacter
    {
        protected List<LanguageEnum> _Languages = new List<LanguageEnum>() { LanguageEnum.Common, LanguageEnum.Dwarven };
        protected Dictionary<string, int> _StatModifierDict = new Dictionary<string, int>() { { "Constitution", 2 }, { "Charisma", -2 } };

        public Dwarf()
        {
            this._Race = RaceEnum.Dwarf;            
        }

        public int Speed()
        {
            return 20;
        }
    }
}
