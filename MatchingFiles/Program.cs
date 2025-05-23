using System;
using System.Security.Cryptography;

namespace MatchingFiles
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string path = "K:\\FilmsClassicSci-Fi\\1960\\";
            FindmatchingFiles findmatchingFiles = new FindmatchingFiles();
            findmatchingFiles.Compera(path);

            Console.WriteLine("DONE");
        }
    }
}