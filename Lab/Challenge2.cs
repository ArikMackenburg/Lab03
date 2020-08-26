using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    public class Challenge2
    {
        public static void HandleChallenge2()
        {
        prompt:
            Console.WriteLine("Pick a number between 2-10");
            string input = Console.ReadLine();
            int length = LengthHandler(input);
            if( length == -1)
            {
                goto prompt;
            }
            double[] arr = new double[length];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Choose number {i+1} of {length}" );
                string num = Console.ReadLine();
                arr[i] = InputHandler(num);
            }
            Console.WriteLine(FindAverage(arr));
            
        }
        public static double FindAverage(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            double avg = sum / arr.Length;
            return avg;
        }

        public static double InputHandler(string input)
        {   
            try
            {
                double num = Convert.ToDouble(input);
                if (num < 0)
                {
                    num = System.Math.Abs(num);
                    return num;
                }
                else
                {
                    return num;
                }
            }
            catch (Exception)
            {
                double num = 0;
                return num;
            }
        }

        public static int LengthHandler(string input)
        {
            try
            {
                int arrLength;
                arrLength = Convert.ToInt32(input);
                if (arrLength > 1 && arrLength < 11)
                {
                    return arrLength;
                }
                else
                {
                    return -1;
                }
            }
            catch(Exception)
            {
                return -1;
            }
        }

    }
}
