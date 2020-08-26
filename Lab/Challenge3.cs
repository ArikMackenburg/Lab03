using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
    public class Challenge3
    {
        public static void DrawTheThingy()
        {
            for (int i = -4; i < 5; i++)
            {
                int spaces = System.Math.Abs(i);
                int stars = 9 - spaces - spaces;
                MakeSpaces(spaces);
                MakeStars(stars);
                MakeSpaces(spaces);
                Console.Write(Environment.NewLine);
            }
        }
        public static void MakeSpaces(int spaces)
        {
            for (int i = 0; i < spaces; i++)
            {
                Console.Write(" ");
            }
        }
        public static void MakeStars(int stars)
        {
            for (int i = 0; i < stars; i++)
            {
                Console.Write("*");
            }

        }
    }
}

//    *
//   ***
//  *****
// *******
//*********
// *******
//  *****
//   ***
//    *
