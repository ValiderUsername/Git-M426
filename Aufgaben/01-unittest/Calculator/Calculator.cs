﻿using System;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int summandA, int summandB)
        {
            return summandA + summandB;
        }

        public int Subtract(int minuend, int subtrahend)
        {
            return minuend - subtrahend;
        }

        public int Multiply(int Number, int Factor)
        {
            return Number * Factor;
        }

        public int Division(int DividedNumber, int Dividend)
        {
            return DividedNumber / Dividend;
        }
    }
}
