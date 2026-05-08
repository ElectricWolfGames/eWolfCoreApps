using eWolfCommonCore;
using System.IO;

namespace FilmTagger.IO;

public class FileDetails
{
    private string _orginalPath;

    public FileDetails(string fullPath)
    {
        _orginalPath = fullPath;
        FullPath = Path.GetDirectoryName(fullPath);
        Name = Path.GetFileNameWithoutExtension(fullPath);
        Extension = Path.GetExtension(fullPath);
        string box = StringsHelper.GetBoxBrackets(fullPath);
        FilmTypes = StringsHelper.GetWordTypes(box).ToList();
    }

    public string Extension { get; set; }
    public List<string> FilmTypes { get; set; }
    public string FullPath { get; set; }
    public string Name { get; set; }

    public void Save()
    {
        string filmTypes = string.Join(",", FilmTypes);
        if (!string.IsNullOrEmpty(filmTypes))
            filmTypes = $"[{filmTypes}]";

        string fullPath = $"{FullPath}\\{Name} {filmTypes}".Trim();
        fullPath = $"{fullPath}.{Extension}";

        if (fullPath != _orginalPath)
        {
            File.Move(_orginalPath, fullPath);
        }
    }
}