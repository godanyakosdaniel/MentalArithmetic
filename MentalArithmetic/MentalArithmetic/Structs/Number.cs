using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MentalArithmetic
{
    struct Number
    {
        float generatedNumber;
        Random r;

        public float GeneratedNumber { get => generatedNumber; private set => generatedNumber = value; }

        public Number(int min, int max) : this()
        {
            r = new Random();
            GeneratedNumber = r.Next(min,max);
        }

        public override string ToString()
        {
            return GeneratedNumber.ToString() ;
        }
    }
}
