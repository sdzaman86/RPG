using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.General;

namespace RPG.Character
{
    class CharacterFactory : AbstractReflectionFactory<AbstractCharacter,Human>
    {
        public AbstractCharacter CreateInstance(RaceEnum race, ClassEnum classType, AlignmentEnum alignment, int age)
        {
            AbstractCharacter c = this.CreateInstance(race.ToEnumString());
            c.Class = classType;
            c.Alignment = alignment;
            c.Age = age;
            
            return c;
        }
    }
}
