namespace ThumbnailCreator.Data
{
    public static class Shows
    {
        // 1920 x 1040 
        internal static ShowDetails PopulateStarShipData()
        {
            ShowDetails showDetails = new ShowDetails();


            showDetails.Title = "Life after Life";
            showDetails.Path = $@"E:\Video_Projects\Audios\11\Images\";
            showDetails.Description = "Uncle Sid's out of prison, on probation. He was serving a life sentence for armed robbery.  The only place he has to stay is back in good old Muswell Hill.  But the area has changed from his early days. Now he's with his middle-class niece and her nice middle-class family.";
            showDetails.Episodes = "1";
            showDetails.Series = "1";


            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = "Series 1";
            episodeDetails.Title = "s01e01 The Start";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);




            return showDetails;
        }
    }
}