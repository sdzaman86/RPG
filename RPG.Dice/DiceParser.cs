using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.RollDice
{
    public class DiceParser
    {
        public int Roll(string d20)
        {
            string[] components = d20.Split('d');

            int numDice = Int32.Parse(components[0]);
            int numSides = Int32.Parse(components[1]);
            int result = new Dice(numDice, numSides).Roll();

            return result;
        }
    }
}
