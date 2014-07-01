using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RPG.RollDice;
using System.Xml;
using System.IO;
using System.Reflection;
using System.Configuration;

namespace RPG.Character.Age
{
    class AgeCalculator
    {
        public int BeginningAge(string race, string classType)
        {
            int result;
            string modifier;

            string path = System.IO.Path.GetFullPath("../../../Assemblies/Config/Age/");
            string[] files = File.ReadAllLines(path);
            XmlTextReader reader = new XmlTextReader(@"Config\Human.xml");

            //file ageSettings = ;     
            //modifier = ageSettings.Class().where(x => x.classType == classType).First().Modifier;
            modifier = "1d4";
            string[] components = modifier.Split('d');
            int numDice = Int32.Parse(components[0]);
            int numSides = Int32.Parse(components[1]);
            

            //result = ageSettings.Adulthood + new Dice(numDice, numSides).Roll();
            result = 15 + new Dice(numDice, numSides).Roll();

            return result;
        }
    }
}
