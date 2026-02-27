namespace FileNameCleaner;

internal class CleanUpFileNames
{
    private string _path;

    public CleanUpFileNames(string path)
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
                ProcessPath(entry + "\\");
                continue;
            }

            string name = Path.GetFileNameWithoutExtension(entry);
            string pathOnly = entry.Replace(Path.GetFileName(entry), string.Empty);
            var temp = Helpers.RemoveOtherWords(name);
            temp = Helpers.RemoveOtherWords(name);
            temp += Path.GetExtension(entry);

            string newPath = pathOnly + temp;
            if (entry != newPath)
            {
                try
                {
                    Console.WriteLine("Update: " + pathOnly + temp);
                    File.Move(entry, newPath);
                }
                catch { }
            }
        }
    }
}