using System;
using System.IO;
using System.Linq;
using Config.Config.Race;
using RPG.General;
using RPG.RollDice;

namespace RPG.Character
{
    public class CharacterCalculator
    {
        private int _HeightOffset = 0;
        private int _WeightOffset = 0;
        private string _Gender;
        private RaceSettings _Config;

        public CharacterCalculator(string race, string gender)
        {
            this._Config = this.GetConfig(race);
            this._HeightOffset = DiceParser.Roll(this._Config.Height.First().Modifier);
            this._WeightOffset = DiceParser.Roll(this._HeightOffset+this._Config.Weight.First().Modifier);
            this._Gender = gender;
        }

        public int BeginningAge(string classType)
        {
            int result;
            string modifier;

            modifier = this._Config.ClassModifier.AsEnumerable().Where(x => x.ClassType == classType).First().Modifier;
            result = DiceParser.Roll(this._Config.AgeMilestones.AsEnumerable().First().Adulthood + "+" + modifier);

            return result;
        }

        public int Height()
        {
            int result;

            int baseHeight = Int32.Parse(this._Config.Gender.Where(x=>x.Gender==this._Gender).First().GetHeightRows().First().Base);
            result = baseHeight + this._HeightOffset;

            return result;
        }

        public int Weight()
        {
            int result;

            int baseWeight = Int32.Parse(this._Config.Gender.Where(x => x.Gender == this._Gender).First().GetWeightRows().First().Base);
            result = baseWeight + this._WeightOffset;

            return result;
        }

        private RaceSettings GetConfig(string race)
        {
            string path = System.IO.Path.GetFullPath(string.Format("Config/Race/{0}.xml", race));
            string xml = File.ReadAllText(path);

            var raceConfig = new RaceSettings();
            raceConfig = raceConfig.Deserialize(xml);
            
            return raceConfig;
        }
    }
}
