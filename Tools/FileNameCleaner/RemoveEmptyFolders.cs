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

            ProcessPath(_path);
        }

        private void ProcessPath(string path)
        {
            try
            {
                var items = Directory.GetFileSystemEntries(path);

                if (items.Count() == 0)
                {
                    Console.WriteLine(path + "   Removed");
                    Directory.Delete(path);
                }

                foreach (var entry in items)
                {
                    if (Directory.Exists(entry))
                        ProcessPath(entry);
                }
            }
            catch { }
        }
    }
}


       