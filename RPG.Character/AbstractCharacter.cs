using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.Character.Class;

namespace RPG.Character
{
    public abstract class AbstractCharacter : ICharacter
    {
        protected int _Strength = 8;
        protected int _Dexterity = 8;
        protected int _Constitution = 8;
        protected int _Intelligence = 8;
        protected int _Wisdom = 8;
        protected int _Charisma = 8;
        protected RaceEnum _Race;
        protected ClassEnum _Class;
        protected AlignmentEnum _Alignment;
        protected int _Age;
        protected int _Height;
        protected int _Weight;
        protected List<LanguageEnum> _Languages = new List<LanguageEnum>(){LanguageEnum.Common};
        protected Dictionary<string, int> _StatModifierDict = new Dictionary<string, int>();
        protected GenderEnum _Gender;

        public SizeEnum Size()
        {
            return SizeEnum.Medium;
        }

        public int Speed()
        {
            return 30;
        }

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

        public int Height
        {
            get
            {
                return this._Height;
            }
            set
            {
                this._Height = value;
            }
        }

        public int Weight
        {
            get
            {
                return this._Weight;
            }
            set
            {
                this._Weight = value;
            }
        }

        public List<LanguageEnum> Languages
        {
            get
            {
                return this._Languages;
            }
            set
            {
                this._Languages = value;
            }
        }

        public bool SpeaksLanguage(LanguageEnum language)
        {
            return this._Languages.Any(l => l == language);
        }

        private int IntelligenceModifier()
        {
            return (int)Math.Floor((this.Intelligence - 10.0) / 2.0);
        }

        public Dictionary<string, int> StatModifierDict
        {
            get
            {
                return this._StatModifierDict;
            }
        }

        public GenderEnum Gender
        {
            get
            {
                return this._Gender;
            }
            set
            {
                this._Gender = value;
            }
        }
    }
}