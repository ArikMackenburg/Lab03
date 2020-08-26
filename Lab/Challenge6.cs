using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using Lab;

namespace Lab
{
    public class Challenge6
    {

        public static void TextFile()
        {
            Console.WriteLine("Write some stuff");
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\ArikM\OneDrive\Desktop\Delta\Lab03\Lab\words.txt", text);
        }
    }
}
