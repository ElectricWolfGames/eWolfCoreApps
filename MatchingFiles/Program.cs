using System;
using System.Security.Cryptography;

namespace MatchingFiles
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            FindmatchingFiles findmatchingFiles;

            findmatchingFiles = new FindmatchingFiles();
            findmatchingFiles.Compera($"K:\\Films\\_ToSort_Done\\");

            for (int i = 1; i < 10; i++)
            {
                findmatchingFiles = new FindmatchingFiles();
                findmatchingFiles.Compera($"K:\\Films\\19{i}0\\");

                findmatchingFiles = new FindmatchingFiles();
                findmatchingFiles.Compera($"K:\\FilmsClassicSci-Fi\\19{i}0\\");
            }

            for (int i = 0; i < 5; i++)
            {
                findmatchingFiles = new FindmatchingFiles();
                findmatchingFiles.Compera($"K:\\Films\\20{i}0\\");
            }

            Console.WriteLine("DONE");
        }
    }
}