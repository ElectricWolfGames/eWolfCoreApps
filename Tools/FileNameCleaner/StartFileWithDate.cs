using CommonCode;

namespace FileNameCleaner;

internal class StartFileWithDate
{
    private string _path;

    public StartFileWithDate(string path)
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
            Console.WriteLine(entry);

            string name = Path.GetFileNameWithoutExtension(entry);
            string pathOnly = entry.Replace(Path.GetFileName(entry), string.Empty);

            var r = StringsHelper.HasDateNotAtStart(name);
            if (!r)
                continue;

            var stringYear = StringsHelper.GetYearFrom(name);
            string temp = name.Replace(stringYear, string.Empty);

            temp = $"{stringYear} {temp}";
            temp = Helpers.RemoveOtherWords(temp);

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