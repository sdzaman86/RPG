using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.Character.Class;
using RPG.Equipment;
using RPG.General;
using RPG.Equipment.Weapons;
using RPG.Equipment.Weapons.Unarmed;

namespace RPG.Character
{
    public abstract class AbstractCharacter : ICharacter
    {
        #region Properties
        #region Stats&Attrs
        protected string _Name;
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
        #endregion
        #region Iventory
        protected IItem _Head;
        protected IItem _Body;
        protected IItem _RightArm;
        protected IHandCombatItem _RightHand = new Hands();
        protected IItem _LeftArm;
        protected IHandCombatItem _LeftHand = new Hands();
        protected IItem _Legs;
        protected IItem _Feet;
        #endregion
        #endregion

        #region Attributes
        public virtual SizeEnum Size()
        {
            return SizeEnum.Medium;
        }

        public virtual int Speed()
        {
            return 30;
        }

        public string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this._Name = value;
            }
        }

        #region Stats
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
        #endregion

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

        public virtual List<LanguageEnum> Languages
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

        private int AbilityModifier(string attribute)
        {
            var t = this.GetType();
            var propinfo = t.GetProperty(attribute);
            return (int)Math.Floor(((int)propinfo.GetValue(this,null) - 10.0) / 2.0);
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
        #endregion

        #region Inventory
        public IItem Head
        {
            get
            {
                return this._Head;
            }
            set
            {
                this._Head = value;
            }
        }

        public IItem Body
        {
            get
            {
                return this._Body;
            }
            set
            {
                this._Body = value;
            }
        }

        public IItem RightArm
        {
            get
            {
                return this._RightArm;
            }
            set
            {
                this._RightArm = value;
            }
        }

        public IHandCombatItem RightHand
        {
            get
            {
                return this._RightHand;
            }
            set
            {
                this._RightHand = value;
            }
        }

        public IItem LeftArm
        {
            get
            {
                return this._LeftArm;
            }
            set
            {
                this._LeftArm = value;
            }
        }

        public IHandCombatItem LeftHand
        {
            get
            {
                return this._LeftHand;
            }
            set
            {
                this._LeftHand = value;
            }
        }

        public IItem Legs
        {
            get
            {
                return this._Legs;
            }
            set
            {
                this._Legs = value;
            }
        }

        public IItem Feet
        {
            get
            {
                return this._Feet;
            }
            set
            {
                this._Feet = value;
            }
        }
        #endregion

        public int Attack()
        {
            int result = ((IWeapon)this.RightHand).Attack() + this.AbilityModifier("Strength") + SizeAttackBonus();
            return result > 0 ? result : 1;
        }

        private int SizeAttackBonus()
        {
            return SizeAttackModifier.SizeModifier(this.Size());
        }
    }
}