using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    class Dice
    {
        private Random r = new Random();
        private int diceNumber;

        public int DiceNumber
        {
            get => diceNumber;
        }

        public Dice()
        {
            diceNumber = r.Next(1, 6);
        }

        public int roll()
        {
            int random;
            do
            {
              random = r.Next(1, 6);
            } while (diceNumber == random);
            diceNumber = random;
            return diceNumber;
        }
    }
}
