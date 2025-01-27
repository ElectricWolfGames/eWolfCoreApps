using System.Web;

namespace ThumbnailCreator.Data
{
    public class ShowDetails
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<EpisodeDetails> EpisodeDetails { get; set; } = new List<EpisodeDetails>();

        public string Path { get; set; } = $@"E:\Video_Projects\Audios\99";

        public string ShowType { get; set; } = "Radio Comedy";
        public string Episodes { get; set; } = "6";
        public int Series { get; set; } = 2;
    }
}