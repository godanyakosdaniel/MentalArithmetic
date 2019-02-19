using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MentalArithmetic.Classes
{
    class Exponent : BasicCalculation
    {
        byte index;

        public byte Index { get => index; private set => index = value; }

        public Exponent(int min, int max, bool fraction, byte index) : base(min, max, fraction: false)
        {
            Index = index;
            Result = Math.Pow(Result,index);
        }

        public override string ToString()
        {
            return base.ToString()+"^"+index+" = ";
        }
    }
}
