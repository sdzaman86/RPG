using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.Character
{
    public interface ICharacter
    {
        StatEnum Size();
        int Speed();
        bool SpeaksLanguage(LanguageEnum language);
        int ArmorClass();
        int Attack(AbstractCharacter c);
    }
}
