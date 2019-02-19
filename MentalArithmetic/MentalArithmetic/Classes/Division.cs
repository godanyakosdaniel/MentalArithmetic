using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MentalArithmetic.Classes
{
    class Division : BasicOperations
    {
        public Division(int min, int max, bool fraction) : base(min, max, fraction)
        {
        }

        public Division(int min, int max, bool fraction, int secondMin, int secondMax) : base(min, max, fraction, secondMin, secondMax)
        {
        }
    }
}
