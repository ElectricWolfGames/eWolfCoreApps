
namespace FileNameCleaner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string path = @"E:\GCR\";
            RemoveEmptyFolders refs = new RemoveEmptyFolders(path);
            refs.Do();
        }
    }
}