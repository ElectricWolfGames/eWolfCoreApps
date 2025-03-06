namespace ThumbnailCreator.Data
{
    public class ShowDetails
    {
        public string Description { get; set; }
        public List<EpisodeDetails> EpisodeDetails { get; set; } = new List<EpisodeDetails>();
        public string Episodes { get; set; } = "6";
        public bool OneOffShow { get; set; }
        public string Path { get; set; } = $@"E:\Video_Projects\Audios\99";
        public int Series { get; set; } = 2;
        public string ShowTypeLineA { get; set; } = "Radio";
        public string ShowTypeLineB { get; set; } = "Comedy";
        public string Source { get; set; }
        public string Title { get; set; }
        public string TitleLine2 { get; set; }
    }
}