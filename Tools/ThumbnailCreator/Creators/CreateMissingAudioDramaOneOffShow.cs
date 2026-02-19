using eWolfAudioShows;
using eWolfAudioShows.Interfaces;
using System.IO;
using ThumbnailCreator.DramaViews;

namespace ThumbnailCreator.Creators;

internal class CreateAudioDramaOneOffShow
{
    public void CreateThumbnails()
    {
        List<IAudioDramaOneOffShow> shows = Holder.GetAllIAudioDramaOneOffShow();
        foreach (var show in shows)
        {
            if (string.IsNullOrWhiteSpace(show.OutputPath))
                continue;

            string showPath = show.OutputPath;

            string pathTest = Path.Combine(showPath, $"{show.Title}_Thumbnail.png");

            if (!File.Exists(pathTest))
            {
                AudioEpisodesShow audioEpisodesShow = new()
                {
                    ShowTitle = $"{show.Title.ToUpper()} {show.TitleLine2.ToUpper()}",
                    OutputPath = Path.Combine(showPath),
                    ShowDescription = show.Description
                };

                audioEpisodesShow.ShowDialog();

                AudioEpisodesThumbnails audioEpisodesThumbnails = new()
                {
                    ShowTitle = $"{show.Title.ToUpper()} {show.TitleLine2.ToUpper()}",
                    OutputPath = Path.Combine(showPath),
                    ShowDescription = show.Description
                };

                audioEpisodesThumbnails.ShowDialog();
            }
        }
    }
}