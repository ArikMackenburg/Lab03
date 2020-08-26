using System;
using System.Collections.Generic;
using System.Text;
using Lab;
using Xunit;

namespace Lab.Test
{
    public class Challenge4Test
    {
        [Fact]
        public static void CheckNumbers()
        {
            int[] arr = new int[] { 1, 2, 2, 2, 3, 3, 3, 4, 4, 5 };
            int[] result = Challenge4.IdentifyNumbers(arr);
            Assert.Equal(new int[]{ 1,2,3,4,5},result);
        }

        [Fact]
        public static void CheckScore()
        {
            int[] arr = new int[] { 1, 2, 2, 2, 3, 3, 3, 4, 4, 5 };
            int[] result = Challenge4.Score(arr);
            Assert.Equal(new int[] { 1, 3, 3, 2, 1 }, result);
        }
        [Fact]
        public static void CheckWinner()
        {
            int[] arr = new int[] { 1, 2, 2, 2, 3, 3, 3, 4, 4, 5 };
            int[] score = new int[] { 1, 3, 3, 2, 1 };
            int result = Challenge4.Winner(arr,score);
            Assert.Equal(2, result);
        }
    }
}
