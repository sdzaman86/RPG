using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.Character.Class;
using RPG.Equipment;
using RPG.General;
using RPG.Equipment.Weapons;
using RPG.Equipment.Weapons.Unarmed;
using RPG.Equipment.Armor.Body;
using RPG.Equipment.Armor.Gloves;
using RPG.Equipment.Armor.Helmet;
using RPG.Equipment.Armor.Pants;
using RPG.Equipment.Armor.Shield;
using RPG.Equipment.Armor.Shoes;

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
        protected int _Health = 10;
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
        protected IHelmet _Head = new Head();
        protected IBody _Body = new Shirt();
        protected IGloves _RightArm = new Arm();
        protected IHandCombatItem _RightHand = new Hands();
        protected IGloves _LeftArm = new Arm();
        protected IHandCombatItem _LeftHand = new Hands();
        protected IPants _Legs = new Pant();
        protected IShoes _Feet = new Feet();
        #endregion
        #endregion

        #region Attributes
        public virtual StatEnum Size()
        {
            return StatEnum.Medium;
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

        public int Health
        {
            get
            {
                return this._Health;
            }
            set
            {
                this._Health = value;
            }
        }

        #endregion

        #region Inventory
        public IHelmet Head
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

        public IBody Body
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

        public IGloves RightArm
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

        public IGloves LeftArm
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

        public IPants Legs
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

        public IShoes Feet
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

        private AttackStruct Attack()
        {
            AttackStruct result = new AttackStruct();

            AttackStruct weaponAS = ((IWeapon)this.RightHand).Attack();
            result.Roll = weaponAS.Roll + this.AbilityModifier("Strength") + this.SizeModifier();
            result.Damage = weaponAS.Damage + this.AbilityModifier("Strength");

            return result;
        }

        public int Attack(AbstractCharacter c)
        {
            return c.Defend(this.Attack());
        }

        private int Defend(AttackStruct p)
        {
            int result = 0;

            if (p.Roll >= 20 || p.Roll > this.ArmorClass())
                result += p.Damage > 0 ? p.Damage : 1;

            this.Health -= result;
            return result;
        }

        private int SizeModifier()
        {
            return SizeAttackModifier.SizeModifier(this.Size());
        }

        public int ArmorClass()
        {
            return 10 + this.ArmorBonus() + this.ShieldBonus() + this.AbilityModifier("Dexterity") + this.SizeModifier();
        }

        private int ShieldBonus()
        {
            int ac = 0;

            if (this.RightHand.GetType().GetInterface(typeof(IShield).ToString()) != null)
                ac += ((IShield)this.RightHand).ArmorClass();
            if (this.LeftHand.GetType().GetInterface(typeof(IShield).ToString()) != null)
                ac += ((IShield)this.LeftHand).ArmorClass();

            return ac;
        }

        private int ArmorBonus()
        {
            int ac = 0;

            ac += this.Head.ArmorClass();
            ac += this.Body.ArmorClass();
            ac += this.RightArm.ArmorClass();
            ac += this.LeftArm.ArmorClass();
            ac += this.Legs.ArmorClass();
            ac += this.Feet.ArmorClass();

            return ac;
        }        
    }
}