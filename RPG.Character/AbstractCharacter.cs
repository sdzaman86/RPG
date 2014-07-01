using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.Character
{
    public abstract class AbstractCharacter : ICharacter
    {
        private int _Strength = 10;
        private int _Dexterity = 10;
        private int _Constitution = 10;
        private int _Intelligence = 10;
        private int _Wisdom = 10;
        private int _Charisma = 10;
        private RaceEnum _Race;
        private ClassEnum _Class;
        private AlignmentEnum _Alignment;
        private int _Age;

        public int Strength
        {
            get
            {
                return this._Strength;
            }
            set
            {
                this._Strength = value;
            }
        }

        public int Dexterity
        {
            get
            {
                return this._Dexterity;
            }
            set
            {
                this._Dexterity = value;
            }
        }

        public int Constitution
        {
            get
            {
                return this._Constitution;
            }
            set
            {
                this._Constitution = value;
            }
        }

        public int Intelligence
        {
            get
            {
                return this._Intelligence;
            }
            set
            {
                this._Intelligence = value;
            }
        }

        public int Wisdom
        {
            get
            {
                return this._Wisdom;
            }
            set
            {
                this._Wisdom = value;
            }
        }

        public int Charisma
        {
            get
            {
                return this._Charisma;
            }
            set
            {
                this._Charisma = value;
            }
        }

        public RaceEnum Race
        {
            get
            {
                return this._Race;
            }
            set
            {
                this._Race = value;
            }
        }

        public ClassEnum Class
        {
            get
            {
                return this._Class;
            }
            set
            {
                this._Class = value;
            }
        }

        public AlignmentEnum Alignment
        {
            get
            {
                return this._Alignment;
            }
            set
            {
                this._Alignment = value;
            }
        }

        public int Age
        {
            get
            {
                return this._Age;
            }
            set
            {
                this._Age = value;
            }
        }
    }
}