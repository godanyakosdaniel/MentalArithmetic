using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MentalArithmetic.Classes
{
    abstract class BasicOperations : BasicCalculation
    {
        Number secondNumber;

        internal Number SecondNumber { get => secondNumber; private set => secondNumber = value; }

        public BasicOperations(int min, int max, bool fraction) : base(min, max, fraction)
        {
            SecondNumber = new Number(min, max, fraction);
        }

        public BasicOperations(int min, int max, bool fraction, int secondMin, int secondMax) : base(min, max, fraction)
        {
            SecondNumber = new Number(secondMin, secondMax, fraction);
        }
    }
}
