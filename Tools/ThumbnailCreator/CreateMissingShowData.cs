using eWolfAudioShows;
using eWolfAudioShows.Interfaces;
using System.IO;

namespace ThumbnailCreator
{
    internal class CreateMissingShowData
    {
        public void Do()
        {
            var shows = GetAll();
            foreach (var show in shows)
            {
                if (string.IsNullOrWhiteSpace(show.OutputPath))
                    continue;

                string path = $"{show.OutputPath}\\thumbnails\\";
                Directory.CreateDirectory(path);

                if (File.Exists($"{path}\\1.png"))
                    continue;

                int i = 0;
                i++;
            }
        }

        private static List<IAudioShow> GetAll()
        {
            return Holder.GetAll();
        }
    }
}