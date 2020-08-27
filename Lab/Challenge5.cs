using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    public class Challenge5
    {
        public static int GetLargest(int[] arr)
        {
            int largest = arr[0];
            for ( int i = 0; i < arr.Length; i++)
            {
                if( largest < arr[i])
                {
                    largest = arr[i];
                }
            }
            return largest;
        }
    }
}
