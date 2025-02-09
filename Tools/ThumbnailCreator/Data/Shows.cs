namespace ThumbnailCreator.Data
{
    public static class Shows
    {
        // 1920 x 1040
        internal static ShowDetails PopulateStarShipData()
        {
            return SetRudyRareRecords();
            //return Nebulous();
            //return SetAnsgstrom();
        }

        private static ShowDetails Nebulous()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/Nebulous A.jpeg";
            showDetails.Title = "Nebulous";
            showDetails.Path = $@"E:\_AudioTemp\_Ark\Comedy\Nebulous_V2\";
            showDetails.Description = "";
            showDetails.Episodes = "";
            showDetails.Series = 3;

            EpisodeDetails episodeDetails;

            for (int i = 0; i < 6; i++)
            {
                episodeDetails = new EpisodeDetails();
                episodeDetails.TitleExtra = ": Series 1";
                episodeDetails.Title = $"s01e0{i} The Man Who Wasn't Dead";
                episodeDetails.Description = "";
                showDetails.EpisodeDetails.Add(episodeDetails);
            }
            for (int i = 0; i < 6; i++)
            {
                episodeDetails = new EpisodeDetails();
                episodeDetails.TitleExtra = ": Series 2";
                episodeDetails.Title = $"s02e0{i} The Man Who Wasn't Dead";
                episodeDetails.Description = "";
                showDetails.EpisodeDetails.Add(episodeDetails);
            }
            for (int i = 0; i < 6; i++)
            {
                episodeDetails = new EpisodeDetails();
                episodeDetails.TitleExtra = ": Series 3";
                episodeDetails.Title = $"s03e0{i} The Man Who Wasn't Dead";
                episodeDetails.Description = "";
                showDetails.EpisodeDetails.Add(episodeDetails);
            }

            return showDetails;
        }

        private static ShowDetails SetAnsgstrom()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/Ansgstrom b.jpeg";
            showDetails.Title = "Ansgstrom";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_All_E\Ansgstrom\";
            showDetails.Description = "Knut Angström is a brooding, alcoholic, maverick Swedish detective from the tough streets of Oslo. Following the death of his wife, he is posted to the Njalsland peninsula where he becomes embroiled in a labyrinthine murder (or possibly not-murder) case which bears an eerie similarity to the Askeladden killings - a case from his distant past.";
            showDetails.Episodes = "4";
            showDetails.Series = 1;

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e01 The Man Who Wasn't Dead";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e02 The Two Faces of Benny from Abba";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e03 Into the Mad Mind of Madness";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e04 The Hunter Is The Hunted And The Hunter";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            return showDetails;
        }

        private static ShowDetails SetRudyRareRecords()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Title = "Rudy's Rare Records";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_All_G\Rudys Rarer Rcords\";
            showDetails.Description = "Adam Sharpe, who returns to Birmingham from London after a breakdown, and is forced to move in with his father Rudy Sharpe. They squeeze into the flat above the eponymous Rudy's Rare Records, his dad's shambolic record shop selling reggae, ska and soul.";
            showDetails.Episodes = "6";
            showDetails.Series = 4;

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e01";
            episodeDetails.Description = "Take Me Home, Country Roads";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e02";
            episodeDetails.Description = "Roots Manoeuvres";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e03";
            episodeDetails.Description = "Get Up, Stand Up";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e04";
            episodeDetails.Description = "The Heart of Saturday Night";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 2";
            episodeDetails.Title = "s02e01";
            episodeDetails.Description = "Ill Communication";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 2";
            episodeDetails.Title = "s02e02";
            episodeDetails.Description = "Oh Carolina";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 2";
            episodeDetails.Title = "s02e03";
            episodeDetails.Description = "Daddy Cool";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 2";
            episodeDetails.Title = "s02e04";
            episodeDetails.Description = "Ride With Me";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 3";
            episodeDetails.Title = "s03e01";
            episodeDetails.Description = "No Richie, No Cry";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 3";
            episodeDetails.Title = "s03e02";
            episodeDetails.Description = "It's A Family Affair";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 3";
            episodeDetails.Title = "s03e03";
            episodeDetails.Description = "Redemption Song";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 3";
            episodeDetails.Title = "s03e04";
            episodeDetails.Description = "Rudy's Rare Record";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 3";
            episodeDetails.Title = "s03e05";
            episodeDetails.Description = "Lights Out";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 3";
            episodeDetails.Title = "s03e06";
            episodeDetails.Description = "Girls and Boys";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 4";
            episodeDetails.Title = "s04e01";
            episodeDetails.Description = "Three's a Crowd";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 4";
            episodeDetails.Title = "s04e02";
            episodeDetails.Description = "Best Local Business";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 4";
            episodeDetails.Title = "s04e03";
            episodeDetails.Description = "Let It Grow";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 4";
            episodeDetails.Title = "s04e04";
            episodeDetails.Description = "It's Grim Up North";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 4";
            episodeDetails.Title = "s04e05";
            episodeDetails.Description = "Miss Reenie Comes to Stay";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 4";
            episodeDetails.Title = "s04e06";
            episodeDetails.Description = "Sound of da Police";
            showDetails.EpisodeDetails.Add(episodeDetails);

            return showDetails;
        }
    }
}