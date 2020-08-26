using System;
using Lab;
using Xunit;

namespace Lab.Test
{
    public class Challenge1Test
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(1,5,2,10)]
        [InlineData(-1,2,2,-4)]
        [InlineData(0,100,2,0)]
        public void Take3ReturnSum(int val1, int val2, int val3, int expect)
        {
            int sum = Challenge1.ReturnSum(val1, val2, val3);

            Assert.Equal(expect, sum);
        }
        [Theory]
        [InlineData("a b c",1)]
        [InlineData("1 2 4",8)]
        [InlineData("1 2",0)]
        [InlineData("1 2 3 4",6)]
        public void InputReturnsCorrectly(string input, int expect)
        {
            int result = Challenge1.InputHandler(input);

            Assert.Equal(expect, result);
        }
    }

}
