using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MentalArithmetic.Classes
{
    class Subtraction : BasicOperations
    {
        public Subtraction(int min, int max, bool fraction) : base(min, max, fraction)
        {
            Result -= SecondNumber.GeneratedNumber;
        }

        public Subtraction(int min, int max, bool fraction, int secondMin, int secondMax) : base(min, max, fraction, secondMin, secondMax)
        {
            Result -= SecondNumber.GeneratedNumber;
        }

        public override string ToString()
        {
            return base.ToString() + " - " + SecondNumber.ToString()+" = " ;
        }
    }
}
