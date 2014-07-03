using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.Character
{
    public abstract class AbstractMonster : AbstractCharacter
    {
        protected List<LanguageEnum> _Languages = new List<LanguageEnum>();

        public List<LanguageEnum> Languages
        {
            get
            {
                return this._Languages;
            }         
        } 
    }
}