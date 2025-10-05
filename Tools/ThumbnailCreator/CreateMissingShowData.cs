using eWolfAudioShows;
using eWolfAudioShows.Interfaces;
using System.IO;
using ThumbnailCreator.Data;

namespace ThumbnailCreator
{
    internal class CreateMissingShowData
    {
        public ShowDetails ShowDetails { get; set; }

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
                MainWindow mainWindow = new MainWindow(ShowDetails);
                mainWindow.ShowDialog();
            }
        }

        private static List<IAudioShow> GetAll()
        {
            return Holder.GetAll();
        }

        private void SetShow(IAudioShow show)
        {
            string image = $"{show.OutputPath}\\Ref\\{show.Title}.jpeg";

            ShowDetails = new ShowDetails
            {
                Source = image, // TODO: need to load the image.
                Title = show.Title,
                TitleLine2 = show.TitleLine2,
                Path = show.OutputPath,
                Description = show.Description,
                ShowTypeLineA = "RADIO",
                ShowTypeLineB = "COMEDY",
                Series = show.Shows.Shows.Count(),
                ShortShow = false,
                CompleteShow = false,
                ComdeyShow = true,
                ScifiShow = false
            };

            if (show.ShowTypes == eWolfAudioShows.Data.Enums.ShowTypes.SciFiDrama)
            {
                ShowDetails.ScifiShow = true;
                ShowDetails.ComdeyShow = false;
            }

            int count = 0;
            foreach (var serie in show.Shows.Shows)
            {
                int epCount = 1;
                count++;
                foreach (var ep in serie.Episodes)
                {
                    string name = $"s0{count}e0{epCount++}";

                    EpisodeDetails s01e01 = new EpisodeDetails();
                    s01e01.TitleExtra = "";
                    s01e01.Title = $"{name} {ep.Name}";
                    s01e01.Description = ep.Description;
                    ShowDetails.EpisodeDetails.Add(s01e01);
                }
            }
        }
    }
}