namespace FileNameCleaner
{
    internal class RemoveEmptyFolders
    {
        private string _path;

        public RemoveEmptyFolders(string path)
        {
            _path = path;
        }

        public void Do()
        {
            var folders = Directory.GetDirectories(_path);
            foreach (var folder in folders)
            {
                Console.WriteLine(folder);
            }
        }
    }
}