using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MentalArithmetic.Classes
{
    class Root : BasicCalculation
    {
        byte index;

        public byte Index { get => index; private set => index = value; }

        public Root(int min, int max, bool fraction, byte index) : base(min, max, fraction: false)
        {
            Index = index;
            Result = Math.Pow(Result, 1.0 / index);
        }

        public override string ToString()
        {
            return index+ "√" + base.ToString()+" = ";
        }
    }
}
