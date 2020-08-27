using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    public class Challenge1
    {
        public static int ReturnProduct(int val1, int val2, int val3)
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
            int product;
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
                    product = 0;
                    Console.WriteLine($"{product}");
                    return product;
                }
                else
                {
                    int result = ReturnProduct(intArr[0], intArr[1], intArr[2]);
                    product = result;
                    Console.WriteLine($"{product}");
                    return product;
                }

            }
            catch (Exception)
            {
                product = 1;
                Console.WriteLine($"{product}");
                return product;
            }
        }
    }
}
