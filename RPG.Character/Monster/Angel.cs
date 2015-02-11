using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.Character;

namespace RPG.Character.Monster
{
    public class Angel : AbstractMonster
    {
        protected int _Strength = 22;
        protected int _Dexterity = 18;
        protected int _Constitution = 18;
        protected int _Intelligence = 18;
        protected int _Wisdom = 18;
        protected int _Charisma = 20;
        protected int _Health = 102;

        public override int Speed()
        {
            return 50;
        }
    }
}
