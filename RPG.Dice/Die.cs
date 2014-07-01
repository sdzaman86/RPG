using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.RollDice
{
    public class Die
    {

        private Random randomGenerator = new Random();
        private int numSides;

        public Die()
        {
            this.numSides = 20;
        }

        public Die(int sides)
        {
            this.numSides = sides;
        }

        public int NumSides()
        {
            return this.numSides;
        }

        public int Roll()
        {
            return this.randomGenerator.Next(1, this.numSides);
        }
    }
}
