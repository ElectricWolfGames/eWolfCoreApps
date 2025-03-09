namespace ThumbnailCreator.Data
{
    public static partial class Shows
    {
        // 1920 x 1040
        internal static ShowDetails PopulateStarShipData()
        {
            return MarriottsMonologues_7();
            //return MarriottsMonologues_6();
            //return MarriottsMonologues_5();
            //return MarriottsMonologues_4();
            //return MarriottsMonologues_3();
            //return MarriottsMonologues_2();
            //return MarriottsMonologues_1();

            //return Party();
            //return DoNothingTilYouHearfromMe();
            //return MirandaHartsJokeShop();
            //return SetClaytonGrange();
            //return SetRudyRareRecords();
            //return SetAnsgstrom();
            //return HobbyBobbies();
            //return Nebulous();
        }

        

        private static ShowDetails MarriottsMonologues_1()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/MM/1 Lion.jpeg";
            showDetails.Title = "Curious little boy and the lion";
            showDetails.TitleLine2 = "With Thora Hird";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\07 Marriotts Monologues\";
            showDetails.Description = "The monologues of Marriott Edgar, performed by actors and comedians";
            showDetails.Episodes = "Marriotts Monologues";
            showDetails.Series = 1;
            showDetails.OneOffShow = true;

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = "";
            episodeDetails.Title = "";

            episodeDetails.Description = "Thora Hird with the classic tales of the curious little boy and the lion.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            return showDetails;
        }

        private static ShowDetails MarriottsMonologues_4()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/MM/4 The Battle of Hastings.jpeg";
            showDetails.Title = "The Battle of Hastings";
            showDetails.TitleLine2 = "With Bernie Clifton";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\07 Marriotts Monologues\";
            showDetails.Description = "The monologues of Marriott Edgar, performed by actors and comedians";
            showDetails.Episodes = "Marriotts Monologues";
            showDetails.Series = 1;
            showDetails.OneOffShow = true;

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = "";
            episodeDetails.Title = "";

            episodeDetails.Description = "Bernie Clifton is the monologist for 'The Battle of Hastings'";
            showDetails.EpisodeDetails.Add(episodeDetails);

            return showDetails;
        }

        private static ShowDetails MarriottsMonologues_5()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/MM/5 Three Ha pence a foot.jpeg";
            showDetails.Title = "Three Ha'pence a foot";
            showDetails.TitleLine2 = "With Bernie Clifton";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\07 Marriotts Monologues\";
            showDetails.Description = "The monologues of Marriott Edgar, performed by actors and comedians";
            showDetails.Episodes = "Marriotts Monologues";
            showDetails.Series = 1;
            showDetails.OneOffShow = true;

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = "";
            episodeDetails.Title = "";

            episodeDetails.Description = "Bernie Clifton is the monologist for 'Three Ha'pence a foot'";
            showDetails.EpisodeDetails.Add(episodeDetails);

            return showDetails;
        }

        private static ShowDetails MarriottsMonologues_6()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/MM/6 Jonah and the Grampus.jpeg";
            showDetails.Title = "Jonah and the Grampus";
            showDetails.TitleLine2 = "With Roy Hudd";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\07 Marriotts Monologues\";
            showDetails.Description = "The monologues of Marriott Edgar, performed by actors and comedians";
            showDetails.Episodes = "Marriotts Monologues";
            showDetails.Series = 1;
            showDetails.OneOffShow = true;

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = "";
            episodeDetails.Title = "";

            episodeDetails.Description = "Roy Hudd is the monologist for 'Jonah and the Grampus'";
            showDetails.EpisodeDetails.Add(episodeDetails);

            return showDetails;
        }

        private static ShowDetails MarriottsMonologues_7()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/MM/7 Gunner Joe.jpeg";
            showDetails.Title = "Gunner Joe";
            showDetails.TitleLine2 = "With Roy Hudd";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\07 Marriotts Monologues\";
            showDetails.Description = "The monologues of Marriott Edgar, performed by actors and comedians";
            showDetails.Episodes = "Marriotts Monologues";
            showDetails.Series = 1;
            showDetails.OneOffShow = true;

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = "";
            episodeDetails.Title = "";

            episodeDetails.Description = "Roy Hudd is the monologist for 'Gunner Joe'";
            showDetails.EpisodeDetails.Add(episodeDetails);

            return showDetails;
        }



        private static ShowDetails MarriottsMonologues_2()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/MM/3 Goalkeeper Joe.jpeg";
            showDetails.Title = "Goalkeeper Joe";
            showDetails.TitleLine2 = "With Roy Castle";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\07 Marriotts Monologues\";
            showDetails.Description = "The monologues of Marriott Edgar, performed by actors and comedians";
            showDetails.Episodes = "Marriotts Monologues";
            showDetails.Series = 1;
            showDetails.OneOffShow = true;

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = "";
            episodeDetails.Title = "";

            episodeDetails.Description = "Roy Castle is the monologist for 'Goalkeeper Joe'";
            showDetails.EpisodeDetails.Add(episodeDetails);

            return showDetails;
        }

        private static ShowDetails MarriottsMonologues_3()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/MM/3 The Magna Charta.jpeg";
            showDetails.Title = "The Magna Charta";
            showDetails.TitleLine2 = "With Roy Castle";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\07 Marriotts Monologues\";
            showDetails.Description = "The monologues of Marriott Edgar, performed by actors and comedians";
            showDetails.Episodes = "Marriotts Monologues";
            showDetails.Series = 1;
            showDetails.OneOffShow = true;

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = "";
            episodeDetails.Title = "";

            episodeDetails.Description = "Roy Castle is the monologist for 'The Magna Charta'";
            showDetails.EpisodeDetails.Add(episodeDetails);

            return showDetails;
        }

       
    }
}