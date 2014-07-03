using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.Character.Class;

namespace RPG.Character.Race
{
    public class Elf : AbstractCharacter
    {
        protected List<LanguageEnum> _Languages = new List<LanguageEnum>() { LanguageEnum.Common, LanguageEnum.Elven };
        protected Dictionary<string, int> _StatModifierDict = new Dictionary<string, int>() { { "Dexterity", 2 }, { "Constitution", -2 } };

        public Elf()
        {
            this._Race = RaceEnum.Elf;            
        }
    }
}
