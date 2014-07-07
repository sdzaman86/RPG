using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Skills.NewFolder1
{
    public class AppraiseCheck : AbstractCheck
    {
        private Random randomSeed = new Random();
        /*target = inventory.selected
        int CheckBonus = 0;
        
        if(target.quality == "common" || target.quality == "well-known")
        {
            public override int DC = 12;
            public override string Success = inventory.target.value = value;
            if(Character.Skills.Appraise.SkillRank == 0)
            {
                public override string Failure = "Fail";
            }
            else
            {
            public override string Failure = "2d6+3*.1 * value";
            }
        }
          
        else if(target.quality == "rare" || target.quality == "exotic")
        {
            DCrand = randomSeed[0,2];
            if(DCrand = 0)
            {
                public override int DC = 15;
            }
            if(DCrand = 1)
            {
                public override int DC = 20;
            }
            if(DCrand = 2)
            {
                public override int DC = 20 + UNSPECIFIED;
            }
            public override string Failure = "Fail";
            if(Character.Skills.Appraise.SkillRank == 0)
            {
                public override string Success = "2d6+3*.1 * value";
            }
            else
            {
                public override string Success = inventory.target.value = value;
            }
        }
          
        if(inventory.find("Magnifying Glass") == true && target.desc == "small" ||inventory.find("Magnifying Glass") == true && target.desc == "highly detailed")
        {
            CheckBonus += 2; 
        }
        if(inventory.find("Merchant's Scale") == true && target.valuedBy == "weight")
        {
            CheckBonus += 2; 
        }
        if(Character.Race = "Dwarf" && target.type = "stone" || Character.Race = "Dwarf" && target.type = "metal")
        {
            CheckBonus += 2;
        }
        if(Character.Familiar = "Raven")
        {
            CheckBonus += 3; 
        }
        if(Character.Feat.Find("Diligent") == true)
        {
            CheckBonus += 2; 
        }
        if(target.Craft == "Metal")
        {
            if(Character.Craft.Metal.Skill >= 5)
            {
                CheckBonus += 2;
            }
        }
        else if(target.Craft == "Leather")
        {
            if(Character.Craft.Leather.Skill >= 5)
            {
                CheckBonus += 2;
            }
        }
        else if(target.Craft == "Cloth")
        {
            if(Character.Craft.Cloth.Skill >= 5)
            {
                CheckBonus += 2;
            }
        }
        public override int Bonus = CheckBonus;
        */
    }
}
