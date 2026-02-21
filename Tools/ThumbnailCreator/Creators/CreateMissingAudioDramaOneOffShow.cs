using CommonCode;
using eWolfAudioShows;
using eWolfAudioShows.Interfaces;
using System.IO;
using ThumbnailCreator.DramaAudioEpisodes;

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

            string pathTest = Path.Combine(showPath, $"{StringsHelper.MakeFileNameSafe(show.Title)}_thumbnail.png");

            if (!File.Exists(pathTest))
            {
                AudioDramaOneOffShow audioEpisodesShow = new()
                {
                    ShowTitle = show.Title.ToUpper(),
                    ShowTitleLine2 = show.TitleLine2,
                    OutputPath = Path.Combine(showPath),
                    ShowDescription = show.Description
                };

                audioEpisodesShow.ShowDialog();

                AudioDramaOneOffThumbnail audioEpisodesThumbnails = new()
                {
                    ShowTitle = show.Title.ToUpper(),
                    ShowTitleLine2 = show.TitleLine2,
                    StoryType = show.StoryType,
                    OutputPath = Path.Combine(showPath),
                    ShowDescription = show.Description
                };

                audioEpisodesThumbnails.ShowDialog();
            }
        }
    }
}