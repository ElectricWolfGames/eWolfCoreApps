using eWolfAudioShows.Data;

namespace ThumbnailCreator.Data
{
    public class ShowDetails
    {
        public bool ComdeyShow { get; set; }
        public bool CompleteShow { get; set; }
        public string Description { get; set; }
        public List<EpisodeDetails> EpisodeDetails { get; set; } = new List<EpisodeDetails>();
        public string Episodes { get; set; } = "6";
        public string Path { get; set; } = $@"E:\Video_Projects\Audios\99";
        public bool ScifiShow { get; set; }
        public int Series { get; set; } = 2;
        public bool ShortShow { get; set; }
        public List<ShowItem> ShowItems { get; set; } = [];
        public string ShowTypeLineA { get; set; } = "Radio";
        public string ShowTypeLineB { get; set; } = "Comedy";
        public string Source { get; set; }
        public string Title { get; set; }
        public string TitleLine2 { get; set; }
    }
}