
namespace FileNameCleaner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string path = @"N:\";
            RemoveEmptyFolders refs = new RemoveEmptyFolders(path);
            refs.Do();
        }
    }
}