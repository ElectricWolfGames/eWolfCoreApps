namespace ThumbnailCreator.Data
{
    public static class Shows
    {
        internal static ShowDetails PopulateStarShipData()
        {
            ShowDetails showDetails = new ShowDetails();

            showDetails.Title = "The Spaceship";
            showDetails.Description = "The Spaceship is a science fiction comedy set in the year 2104 and onwards that premiered on BBC Radio 7 over the course of five days during the last week of June 2005. It was written by Paul Barnhill and Neil Warhurst and was directed by Sally Avens.";

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.Title = "s01e01: Lost";
            episodeDetails.Description = "The crew is responsible for taking care of the princess of the Urg.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.Title = "s01e02: Indestructible";
            episodeDetails.Description = "Why does The Indestructible III explode for no reason?";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.Title = "s01e03: Monster";
            episodeDetails.Description = "Who or what is in the hold of The Really Invincible III.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.Title = "s01e04: Dirty";
            episodeDetails.Description = "Clive 55’s experiment with dark matter goes awry.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.Title = "s01e05: Enemies";
            episodeDetails.Description = "The crew prepare to meet the Duhwop-eye.";
            showDetails.EpisodeDetails.Add(episodeDetails);
            // s2

            episodeDetails = new EpisodeDetails();
            episodeDetails.Title = "s02e01: Hole";
            episodeDetails.Description = "While dealing with the unpleasant consequences of the first ever incident of travel through a black hole, the crew faces a race of call-centre operative plants.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.Title = "s02e02: Manhood";
            episodeDetails.Description = "Scientist Clive 55 reconstructs a dead space pirate and before long he's running the ship.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.Title = "s02e03: Rude";
            episodeDetails.Description = "The crew have some space tourists on board, but it turns into a holiday from hell.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.Title = "s02e04: Sick";
            episodeDetails.Description = "The crew contract a mystery virus which makes them age at an alarming rate.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.Title = "s02e05: The End";
            episodeDetails.Description = "The End: The crew find themselves at the end of the universe.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            return showDetails;


        }
    }
}