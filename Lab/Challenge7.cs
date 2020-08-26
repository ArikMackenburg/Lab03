using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Reflection.Metadata;

namespace Lab
{
    public class Challenge7
    {
        public static void WriteTextFile()
        {
            string text = File.ReadAllText(@"C:\Users\ArikM\OneDrive\Desktop\Delta\Lab03\Lab\words.txt");
            Console.WriteLine(text);
        }
    }
}
