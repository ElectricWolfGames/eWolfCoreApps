using eWolfAudioShows;
using eWolfAudioShows.Interfaces;
using eWolfAudioShows.Shows_OLD;
using System.IO;
using ThumbnailCreator.Data;

namespace ThumbnailCreator
{
    internal class CreateMissingShowData
    {
        public ShowDetails ShowDetails { get; set; }

        public void Do()
        {
            var shows = GetAllEpisodesShow();
            foreach (var show in shows)
            {
                if (string.IsNullOrWhiteSpace(show.OutputPath))
                    continue;

                /*
                string path = $"{show.OutputPath}\\thumbnails\\";
                Directory.CreateDirectory(path);

                if (File.Exists($"{path}\\1.png"))
                    continue;

                string image = $"{show.OutputPath}Ref\\{show.Title}.jpeg";
                if (!File.Exists(image))
                    continue;

                SetShow(show);
                MainWindow mainWindow = new MainWindow(ShowDetails);
                mainWindow.ShowDialog();*/
            }
        }

        private static List<IAudioEpisodesShow> GetAllEpisodesShow()
        {
            return Holder.GetAllEpisodesShow();
        }

        private void SetShow(IAudioShowOLD show)
        {
            string image = $"{show.OutputPath}\\Ref\\{show.Title}.jpeg";

            ShowDetails = new ShowDetails
            {
                Source = image,
                Title = show.Title,
                TitleLine2 = show.TitleLine2,
                Path = show.OutputPath,
                Description = show.Description,
                ShowTypeLineA = "RADIO",
                ShowTypeLineB = "COMEDY",
                Series = show.Shows.ShowItems.Count,
                ShortShow = false,
                CompleteShow = false,
                ComdeyShow = true,
                ScifiShow = false,
                ShowItems = show.Shows.ShowItems
            };

            if (show.ShowTypes == eWolfAudioShows.Data.Enums.ShowTypes.SciFiDrama)
            {
                ShowDetails.ScifiShow = true;
                ShowDetails.ComdeyShow = false;
            }

            int count = 0;
            foreach (var serie in show.Shows.ShowItems)
            {
                int epCount = 1;
                count++;
                foreach (var ep in serie.Episodes)
                {
                    string name = $"s0{count}e0{epCount++}";
                    if (!string.IsNullOrWhiteSpace(serie.PartName))
                    {
                        name = $"s{serie.StartName}e{ep.Number.ToString("00")}";
                    }

                    EpisodeDetails s01e01 = new EpisodeDetails
                    {
                        TitleExtra = "",

                        Title = $"{name} {ep.Name}",

                        Description = ep.Description,
                        StartName = serie.StartName,
                        PartName = serie.PartName
                    };

                    ShowDetails.EpisodeDetails.Add(s01e01);
                }
            }
        }
    }
}