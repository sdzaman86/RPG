using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RPG.General;

namespace RPG.Skills.Skills
{
    public class Appraise : AbstractSkill
    {
        public override int SkillRank()
        {
            return 1;
        }

        public override AttributeEnum KeyAbility()
        {
            return AttributeEnum.Intelligence;
        }

        public override bool TrainedOnly()
        {
            return false;
        }

        public override int ArmorCheckPenalty()
        {
            return 0;
        }

        public override int Action()
        {
            return 10;
        }

        public override string TryAgain()
        {
            return "No";
        }

        public override string Special()
        {
            return "Dwarves get +2 on metal & stone items. Masters of raven familiars gain +3. Diligent characters get +2";
        }

        public override string Synergy()
        {
            return "Characters with 5 ranks of a craft skill the same kind as the item, they recieve +2";
        }

        public override string Restriction()
        {
            return "None";
        }

        public override string Untrained()
        {
            return "Failure on common or well-known items when untrained reveals no estimate. Succeeding on rare or exotic items when untrained gives an estimate of 50% to 150% of actual value";
        }

        public override string OpposingSkill()
        {
            return "None";
        }
    }
}
