using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.Character.Class;

namespace RPG.Character.Race
{
    public class Human : AbstractCharacter
    {
        public Human()
        {
            this._Race = RaceEnum.Human;
        }
    }
}
