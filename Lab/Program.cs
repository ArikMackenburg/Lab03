using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace Lab
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MainLoop();
        }

        public static void MainLoop()
        {
            int run = 0;
            while (run == 0)
            {
                Challenge1.HandleChallenge1();
                Challenge2.HandleChallenge2();
                Challenge3.DrawTheThingy();
                Console.WriteLine("Continue Y/N");
                string input = Console.ReadLine().ToLower();
                if (input == "y")
                {
                    continue;
                }
                if ( input != "y")
                {
                    break;
                }
            }
        }

        
    }
}
