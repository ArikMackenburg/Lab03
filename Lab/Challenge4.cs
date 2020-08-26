using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.InteropServices.ComTypes;

namespace Lab
{
    public class Challenge4
    {
        public static int[] IdentifyNumbers(int[] arr)
        {
            int[] Numbers = new int[1];
            Numbers[0] = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                int spot = Numbers.Length;
                int length = Numbers.Length + 1;
                if ( Array.IndexOf( Numbers, arr[i])==-1)
                {
                    int[] numbers = new int[length];
                    Array.Copy(Numbers, numbers, Numbers.Length);
                    numbers[spot] = arr[i];
                    Numbers = numbers;

                }
            }
            return Numbers;
        }

        public static int[] Score(int[] arr)
        {
            int[] numbers = IdentifyNumbers(arr);
            int[] score = new int[numbers.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if( arr[i] == numbers[j])
                    {
                        score[j]++;
                    }
                }
            }
            return score;
        }
        public static int Winner(int[] numbers, int[] scores)
        {
            int winner = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                if (scores[winner] < scores[i])
                {
                    winner = i;
                }
            }
            return numbers[winner];
        }
    }
}
