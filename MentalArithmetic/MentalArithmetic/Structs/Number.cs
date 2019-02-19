using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MentalArithmetic
{
    struct Number
    {
        double generatedNumber;
        bool fraction;
        Random r;

        public double GeneratedNumber { get => generatedNumber; private set => generatedNumber = value; }
        public bool Fraction { get => fraction; private set => fraction = value; }

        public Number(int min, int max,bool fraction) : this()
        {
            r = new Random();
            Fraction = fraction;
            if (Fraction)
            {
                GeneratedNumber = r.Next(min, max) + r.NextDouble();
            }
            else
            {
                GeneratedNumber = r.Next(min, max);
            }
        }

        public override string ToString()
        {
            return ((Fraction)? Math.Round(GeneratedNumber,2) : Math.Round(GeneratedNumber)).ToString();
        }
    }
}
