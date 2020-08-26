using System;
using System.Collections.Generic;
using System.Text;
using Lab;
using Xunit;


namespace Lab.Test
{
    public class Challenge2Test
    {
        [Theory]
        [InlineData(new double[] { 2, 2, 2 }, 2)]
        [InlineData(new double[] { 2, 4, 6 }, 4)]
        [InlineData(new double[] { 4, 8, 15, 16 }, 10.75)]
        public static void TestAverageOfInputs(double[] arr, double expect)
        {
            double result = Challenge2.FindAverage(arr);

            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData("4",4)]
        [InlineData("-4",4)]
        [InlineData("a",0)]
        public static void TestInputs(string input, double expect)
        {
            double result = Challenge2.InputHandler(input);

            Assert.Equal(expect, result);
        }

        [Theory]
        [InlineData("2",2)]
        [InlineData("1",-1)]
        [InlineData("11",-1)]
        public static void TestLengthInput(string input, int expect)
        {
            int result = Challenge2.LengthHandler(input);

            Assert.Equal(expect, result);
        }
    }
}
