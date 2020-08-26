using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    public class Challenge1
    {
        public static int ReturnSum(int val1, int val2, int val3)
        {
            return val1 * val2 * val3;
        }

        public static void HandleChallenge1()
        {
            Console.WriteLine("Please enter 3 numbers");
            string input = Console.ReadLine();
            InputHandler(input);

        }
        public static int InputHandler(string input)
        {
            int sum;
            string[] arr = input.Split(" ");
            int[] intArr = new int[arr.Length];
            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    intArr[i] = Convert.ToInt32(arr[i]);
                }
                if (arr.Length < 3)
                {
                    sum = 0;
                    Console.WriteLine($"{sum}");
                    return sum;
                }
                else
                {
                    int result = ReturnSum(intArr[0], intArr[1], intArr[2]);
                    sum = result;
                    Console.WriteLine($"{sum}");
                    return sum;
                }

            }
            catch (Exception)
            {
                sum = 1;
                Console.WriteLine($"{sum}");
                return sum;
            }
        }
    }
}
