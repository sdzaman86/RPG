using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.Skills;
using RPG.General;

namespace RPG.Skills
{
    public interface ISkill
    {
        int SkillRank();

        AttributeEnum KeyAbility();

        bool TrainedOnly();

        int ArmorCheckPenalty();

        string Check();

        int Action();

        string TryAgain();

        string Special();

        string Synergy();

        string Restriction();

        string Untrained();

        string OpposingSkill();
    }
}
