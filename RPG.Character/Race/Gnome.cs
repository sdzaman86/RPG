using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.Character.Class;

namespace RPG.Character.Race
{
    public class Gnome : AbstractCharacter
    {
        protected List<LanguageEnum> _Languages = new List<LanguageEnum>() { LanguageEnum.Common, LanguageEnum.Gnome };
        protected Dictionary<string, int> _StatModifierDict = new Dictionary<string, int>() { { "Constitution", 2 }, { "Strength", -2 } };

        public Gnome()
        {
            this._Race = RaceEnum.Gnome;            
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
