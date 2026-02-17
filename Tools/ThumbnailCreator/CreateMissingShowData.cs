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
            List<IAudioEpisodesShow> shows = GetAllEpisodesShow();
            foreach (var show in shows)
            {
                if (string.IsNullOrWhiteSpace(show.OutputPath))
                    continue;

                string showPath = show.OutputPath;

                int count = 1;
                foreach (var episode in show.Episodes.EpisodeItems)
                {
                    if (!string.IsNullOrWhiteSpace(episode.OutputPath))
                    {
                        Directory.CreateDirectory(System.IO.Path.Combine(showPath, episode.OutputPath));
                    }

                    string pathTest = System.IO.Path.Combine(showPath, episode.OutputPath, $"{episode.Name}_Thumbnail.png");

                    if (!File.Exists(pathTest))
                    {
                        AudioEpisodesShow audioEpisodesShow = new()
                        {
                            SeriesTitle = $"{show.Title.ToUpper()} {show.TitleLine2.ToUpper()}",
                            ShowTitle = $"{count}). {episode.Name}",
                            OutputPath = System.IO.Path.Combine(showPath, episode.OutputPath),
                            IndexCurrent = count,
                            IndexTotal = show.Episodes.EpisodeItems.Count,
                            ShowDescription = episode.Description
                        };

                        audioEpisodesShow.ShowDialog();

                        AudioEpisodesThumbnails audioEpisodesThumbnails = new()
                        {
                            SeriesTitle = show.Title.ToUpper(),
                            SeriesTitleLine2 = show.TitleLine2.ToUpper(),
                            ShowTitle = $"{episode.Name}",
                            OutputPath = System.IO.Path.Combine(showPath, episode.OutputPath),
                            IndexCurrent = count,
                            IndexTotal = show.Episodes.EpisodeItems.Count,
                            ShowDescription = episode.Description
                        };

                        audioEpisodesThumbnails.ShowDialog();
                    }

                    count++;
                }
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