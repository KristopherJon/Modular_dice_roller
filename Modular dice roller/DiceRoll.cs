using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modular_dice_roller
{
    public class DiceRoll
    {
        public int NumberOfDice { get; }
        public int DiceRangeMinimum { get; }
        public int DiceRangeMaximum { get; }

        public DiceRoll(int numberOfDice, int diceRangeMinimum, int diceRangeMaximum)
        {
            this.NumberOfDice = numberOfDice;
            this.DiceRangeMinimum = diceRangeMinimum;
            this.DiceRangeMaximum = diceRangeMaximum;
        }
    }
}
