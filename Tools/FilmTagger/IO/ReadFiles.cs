using System.IO;

namespace FilmTagger.IO;

internal class ReadFiles
{
    public ReadFiles(string path)
    {
        var files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
        foreach (var file in files)
        {
            var temp = new FileDetails(file);
            FileDetails.Add(temp);
        }
    }

    public List<FileDetails> FileDetails { get; set; } = [];
}