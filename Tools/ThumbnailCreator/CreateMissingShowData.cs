using eWolfAudioShows;
using eWolfAudioShows.Interfaces;
using System.IO;
using ThumbnailCreator.Data;

namespace ThumbnailCreator
{
    internal class CreateMissingShowData
    {
        private ShowDetails _showDetails;

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

                string image = $"{show.OutputPath}Ref\\{show.Title}.jpeg";
                if (!File.Exists(image))
                    continue;

                SetShow(show);
            }
        }

        private static List<IAudioShow> GetAll()
        {
            return Holder.GetAll();
        }

        private void SetShow(IAudioShow show)
        {
            string path = $"{show.OutputPath}\\thumbnails\\";
            string image = $"{path}\\Ref\\{show.Title}.jpeg";

            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = image; // TODO: need to load the image.
            showDetails.Title = show.Title;
            showDetails.TitleLine2 = "";
            showDetails.Path = show.OutputPath;
            showDetails.Description = show.Description;
            showDetails.ShowTypeLineA = "Radio";
            showDetails.ShowTypeLineB = "Comedy";
            showDetails.Series = show.Shows.Shows.Count();
            showDetails.ShortShow = false;
            showDetails.CompleteShow = false;
            showDetails.ComdeyShow = true;
            showDetails.ScifiShow = false;

            _showDetails = showDetails;
        }
    }
}