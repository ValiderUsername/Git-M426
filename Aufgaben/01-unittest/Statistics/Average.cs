using System;
using System.Collections.Generic;

namespace Statistics
{
    public class Average
    {
        public double Mean(List<int> numbers)
        {
            try
            {
                numbers.Capacity = numbers.Count;
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("{0}");
            }
            int sum = 0;
            double mean = 0.0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            mean = (double)sum / numbers.Count;
            return mean;
        }
        public double Median(List<int> zahlen)
        {

        }
    }
}
