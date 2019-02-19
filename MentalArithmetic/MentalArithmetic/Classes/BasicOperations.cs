using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MentalArithmetic.Classes
{
    abstract class BasicOperations : BasicCalculation
    {
        Number secondNumber;

        public BasicOperations(int min, int max, bool fraction) : base(min, max, fraction)
        {
            secondNumber = new Number(min, max, fraction);
        }

        public BasicOperations(int min, int max, bool fraction, int secondMin, int secondMax) : base(min,max,fraction)
        {
            secondNumber = new Number(secondMin, secondMax,fraction);
        }
    }
}
