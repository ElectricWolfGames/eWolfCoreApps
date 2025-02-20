using System.IO;

namespace FileNameCleaner
{
    internal class CleanUpFileNames
    {
        private string _path;
        public CleanUpFileNames(string path)
        {
            _path = path;

        }
        public void Do()
        {
            var items = Directory.GetFileSystemEntries(_path);

            foreach (var entry in items)
            {

                string name = Path.GetFileNameWithoutExtension(entry);
                string pathOnly = entry.Replace(Path.GetFileName(entry), string.Empty);
                //Console.WriteLine(name);

                var temp = Helpers.RemoveOtherWords(name);

                temp += Path.GetExtension(entry);
                //Console.WriteLine(temp);
                Console.WriteLine(pathOnly +  temp);

                string newPath = pathOnly + temp;
                if (entry != newPath)
                {
                    File.Move(entry, newPath);
                }
            }
        }
    }

}