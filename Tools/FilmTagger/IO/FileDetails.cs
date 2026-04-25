using CommonCode;
using System.IO;

namespace FilmTagger.IO;

public class FileDetails
{
    public FileDetails(string fullPath)
    {
        FullPath = fullPath;
        Name = Path.GetFileName(fullPath);

        string box = StringsHelper.GetBoxBrackets(fullPath);
        FilmTypes = StringsHelper.GetWordTypes(box).ToList();
    }

    public List<string> FilmTypes { get; set; }
    public string FullPath { get; set; }
    public string Name { get; set; }
}