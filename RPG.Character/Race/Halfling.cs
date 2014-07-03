using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.Character.Class;
using RPG.General;

namespace RPG.Character.Race
{
    public class Halfling : AbstractCharacter
    {
        protected List<LanguageEnum> _Languages = new List<LanguageEnum>() { LanguageEnum.Common, LanguageEnum.Halfling };
        protected Dictionary<string, int> _StatModifierDict = new Dictionary<string, int>() { { "Dexterity", 2 }, { "Strength", -2 } };

        public Halfling()
        {
            this._Race = RaceEnum.Halfling;
        }

        public SizeEnum Size()
        {
            return SizeEnum.Small;
        }

        public int Speed()
        {
            return 20;
        }
    }
}
