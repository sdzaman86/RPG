using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.Character.Class;

namespace RPG.Character.Race
{
    public class Gnome : AbstractCharacter
    {
        public Gnome()
        {
            this._Race = RaceEnum.Gnome;
            this._Languages = new List<LanguageEnum>() { LanguageEnum.Common, LanguageEnum.Gnome };
            this._StatModifierDict = new Dictionary<string, int>() { { "Constitution", 2 }, { "Strength", -2 } };
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
