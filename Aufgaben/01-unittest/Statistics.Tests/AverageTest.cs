using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Sdk;

namespace Statistics.Tests
{
    public class AverageTest
    {
        [Fact]
        public void TestMeanOfTwoNumbers()
        {
            List<int> numbers = new List<int> { 10, 3 };
            double expected = 6.5;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfFiveNumbers()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5};
            double expected = 3;
            Average average = new Average();

            double actual = average.Mean(numbers);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestMeanOfNoNumbers()
        {
            List<int> numbers = new List<int> {};
            double expected = 0;
            Average average = new Average();

            double actual = average.Mean(numbers);
            Assert.Equal(expected, actual);
        }

    }
}
