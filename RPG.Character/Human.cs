using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.Character
{
    public class Human : AbstractCharacter
    {
        public Human()
        {
            this.Race = RaceEnum.Human;            
        }

        public Human(ClassEnum classType, AlignmentEnum alignment, int age)
        {
            this.Race = RaceEnum.Human;
            this.Class = classType;
            this.Alignment = alignment;
            this.Age = age;
        }
    }
}
