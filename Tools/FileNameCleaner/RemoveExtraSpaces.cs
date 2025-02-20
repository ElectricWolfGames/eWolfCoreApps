namespace FileNameCleaner
{
    internal class RemoveExtraSpaces
    {
        private string _path;

        public RemoveExtraSpaces(string path)
        {
            _path = path;
        }

        public void Do()
        {

            ProcessPath(_path);
        }
        private void ProcessPath(string path)
        {
            var items = Directory.GetFileSystemEntries(path);

           foreach (var entry in items)
           {
                if (Directory.Exists(entry))
                {
                    ProcessPath(entry);
                    continue;
                }

                /*bool spaceDash = entry.Contains(" - ");
                if (spaceDash)
                    Console.WriteLine(entry);
                */



                bool spaceWord = entry.Contains(" AMZN ");
                if (spaceWord)
                {
                    // Console.WriteLine(entry);
                    string lastName = Path.GetFileNameWithoutExtension(entry);
                    Console.WriteLine(lastName);
                }

                /*bool spaceDot = entry.Contains(" .");
                if (spaceDot)
                    Console.WriteLine(entry);*/
            }

        }
    }
}


       