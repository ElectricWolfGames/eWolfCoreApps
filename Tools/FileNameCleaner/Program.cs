using System.Reflection.Metadata.Ecma335;

namespace FileNameCleaner
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // string path = @"K:\TV\";

            string path = "E:\\_ToWatch\\_ToCheck\\_ToStore\\";
            //string path = "E:\\_ToWatch\\_ToCheck\\Agatha Christie's Marple  2004\\";
            //string path = "E:\\_ToWatch\\_ToCheck\\Midsomer Murders\\";
            //string path = "E:\\_ToWatch\\_ToCheck\\The Last of Us\\";
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