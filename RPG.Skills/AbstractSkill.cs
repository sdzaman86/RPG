using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.General;

namespace RPG.Skills
{
    public abstract class AbstractSkill : ISkill
    {
        public abstract int SkillRank();

        public abstract AttributeEnum KeyAbility();

        public abstract bool TrainedOnly();

        public abstract int ArmorCheckPenalty();

        public abstract int Action();

        public abstract string TryAgain();

        public abstract string Special();

        public abstract string Synergy();

        public abstract string Restriction();

        public abstract string Untrained();

        public abstract string OpposingSkill();


        public string Check()
        {
            throw new NotImplementedException();
        }
    }
}
