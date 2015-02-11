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
        public Halfling()
        {
            this._Race = RaceEnum.Halfling;
            this._Languages = new List<LanguageEnum>() { LanguageEnum.Common, LanguageEnum.Halfling };
            this._StatModifierDict = new Dictionary<string, int>() { { "Dexterity", 2 }, { "Strength", -2 } };
        }

        public StatEnum Size()
        {
            return StatEnum.Small;
        }

        public int Speed()
        {
            return 20;
        }
    }
}
