using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Config.Config.Race;
using RPG.Character.Class;
using RPG.Character.Race;
using RPG.General;
using RPG.RollDice;

namespace RPG.Character
{
    public class CharacterFactory : AbstractReflectionFactory<AbstractCharacter,Human>
    {
        private int _HeightOffset = 0;
        private GenderEnum _Gender;
        private RaceSettings _Config;
        Random newRandom = new Random();

        public AbstractCharacter CreateInstance(RaceEnum race, ClassEnum classType, AlignmentEnum alignment, GenderEnum gender)
        {
            this._Gender = gender;
            this._Config = this.GetConfig(race);

            AbstractCharacter c = this.CreateInstance(race.ToString());
            c.Gender = gender;
            c.Class = classType;
            c.Alignment = alignment;            
            this.RollNewStats(c);
            
            return c;
        }

        public void RollNewStats(AbstractCharacter c)
        {
            this._HeightOffset = DiceParser.Roll(this._Config.Height.First().Modifier, newRandom);
            c.Age = this.BeginningAge(c.Class);
            c.Height = this.CalcHeight();
            c.Weight = this.CalcWeight();

            
            c.Strength = this.StatRoll();
            c.Dexterity = this.StatRoll();
            c.Constitution = this.StatRoll();
            c.Intelligence = this.StatRoll();
            c.Wisdom = this.StatRoll();
            c.Charisma = this.StatRoll();

            foreach (KeyValuePair<string, int> modifier in c.StatModifierDict)
                c.Set(modifier.Key, modifier.Value);
        }

        private int StatRoll()
        {
            List<int> rolls = new List<int>();
            rolls = new Dice(4, 6, this.newRandom).RollResults();            

            rolls.Remove(rolls.Min());
            return rolls.Sum();
        }

        private RaceSettings GetConfig(RaceEnum race)
        {
            string path = System.IO.Path.GetFullPath(string.Format("Config/Race/{0}.xml", race.ToString()));
            string xml = File.ReadAllText(path);

            var raceConfig = new RaceSettings();
            raceConfig = raceConfig.Deserialize(xml);
            
            return raceConfig;
        }

        private int BeginningAge(ClassEnum classType)
        {
            int result;
            string modifier;

            modifier = this._Config.ClassModifier.AsEnumerable().Where(x => x.ClassType == classType.ToString()).First().Modifier;
            result = DiceParser.Roll(this._Config.AgeMilestones.AsEnumerable().First().Adulthood + "+" + modifier, this.newRandom);

            return result;
        }

        private int CalcHeight()
        {
            int result;

            int baseHeight = Int32.Parse(this._Config.Gender.Where(x=>x.Gender==this._Gender.ToString()).First().GetHeightRows().First().Base);
            result = baseHeight + this._HeightOffset;

            return result;
        }

        private int CalcWeight()
        {
            int result;
            
            int baseWeight = Int32.Parse(this._Config.Gender.Where(x => x.Gender == this._Gender.ToString()).First().GetWeightRows().First().Base);
            result = baseWeight + DiceParser.Roll(this._HeightOffset + this._Config.Weight.First().Modifier, this.newRandom); ;

            return result;
        }
    }
}
