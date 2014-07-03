using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.Character.Class;

namespace RPG.Character.Race
{
    public class HalfElf : AbstractCharacter
    {        
        public HalfElf()
        {
            this._Race = RaceEnum.HalfElf;            
            this._Languages = new List<LanguageEnum>() { LanguageEnum.Common, LanguageEnum.Elven };
        }
    }
}
