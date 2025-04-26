
using System.Reflection.Metadata.Ecma335;

namespace FileNameCleaner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // string path = @"K:\TV\";
            //string path = "E:\\_ToWatch\\Films\\ToStore\\";
            string path = "E:\\_ToWatch\\Films\\ToStore\\To Check\\Star Wars Skeleton Crew\\720\\";
            CleanUpFileNames cfn = new CleanUpFileNames(path);
            cfn.Do();

            StartFileWithDate sfwd = new StartFileWithDate(path);
            sfwd.Do();


            //RemoveExtraSpaces res = new RemoveExtraSpaces(path);
            //res.Do();

            //RemoveEmptyFolders refs = new RemoveEmptyFolders(path);
            //refs.Do();
        }
    }
}