using System;
using System.Collections.Generic;
using System.Text;
using Lab;
using Xunit;
namespace Lab.Test
{
    public class Challenge5Test
    {
        [Theory]
        [InlineData(new int[] { 1,2,3,4,5},5)]
        [InlineData(new int[] { -1,2,-50,300,27,27},300)]
        [InlineData(new int[] { -1, -2, -50, -300, -27, -27 }, -1)]
        public static void GivenArrayReturnLargestNum(int[] arr, int expect)
        {
            int result = Challenge5.GetLargest(arr);

            Assert.Equal(expect, result);
        }
    }
}
