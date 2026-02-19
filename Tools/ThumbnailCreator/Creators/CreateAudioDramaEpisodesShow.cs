using eWolfAudioShows;
using eWolfAudioShows.Interfaces;
using System.IO;
using ThumbnailCreator.DramaViews;

namespace ThumbnailCreator.Creators;

internal class CreateAudioDramaEpisodesShow
{
    public void CreateThumbnails()
    {
        List<IAudioEpisodesShow> shows = Holder.GetAllEpisodesShow();
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
                    Directory.CreateDirectory(Path.Combine(showPath, episode.OutputPath));
                }

                string pathTest = Path.Combine(showPath, episode.OutputPath, $"{episode.Name}_Thumbnail.png");

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
}