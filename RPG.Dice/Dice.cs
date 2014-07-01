using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG.RollDice
{
    public class Dice
    {
        private Die die;
        private int numDice;

        public Dice()
        {
            this.die = new Die();
            this.numDice = 1;
        }

        public Dice(int numDice)
        {
            this.die = new Die();
            this.numDice = numDice;
        }

        public Dice(int numDice, int numSides)
        {
            this.die = new Die(numSides);
            this.numDice = numDice;
        }

        public int NumDice()
        {
            return this.numDice;
        }

        public int Roll()
        {
            int result=0;

            for (int i = 0; i < this.numDice; i++)
            {
                result += this.die.Roll();
            }

            return result;
        }

        public IEnumerable<Die> GetDice()
        {
            List<Die> result = new List<Die>();

            for (int i = 0; i < this.numDice; i++)
            {
                result.Add(die);
            }

            return result;
        }

        public int NumSides()
        {
            int result;

            result = this.GetDice().First().NumSides();

            return result;
        }


    }
}
