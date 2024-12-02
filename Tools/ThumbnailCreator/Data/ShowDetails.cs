namespace ThumbnailCreator.Data
{
    public class ShowDetails
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<EpisodeDetails> EpisodeDetails { get; set; } = new List<EpisodeDetails>();
    }
}