using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MentalArithmetic.Classes
{
    abstract class BasicCalculation
    {
        Number firstNumber;
        double result;

        internal Number FirstNumber { get => firstNumber; private set => firstNumber = value; }
        public double Result { get => result; protected set => result = value; }

        protected BasicCalculation(int min, int max, bool fraction)
        {
            FirstNumber = new Number(min, max, fraction);
            Result = FirstNumber.GeneratedNumber;
        }

        public bool comparison(float numberToCompare)
        {
            return (Result == numberToCompare) ? true : false;
        }

        public override string ToString()
        {
            return firstNumber.ToString();
        }
    }
}
