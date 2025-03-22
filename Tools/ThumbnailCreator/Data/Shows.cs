namespace ThumbnailCreator.Data
{
    public static partial class Shows
    {
        public static ShowDetails _625Y()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/Scifi/625Y.jpeg";
            showDetails.Title = "625Y";
            showDetails.TitleLine2 = "Complete story";
            showDetails.Path = $@"E:\_AudioTemp\Scifi\NEXT\Mix/625Y\";
            showDetails.Description = "Research scientist Kate Brown makes a dramatic discovery in her laboratory about human genes. Scientists try to hang on to the news that they've found a way to extend human life. First the politicians, and then the people, find out. Very quickly things turn very nasty.";
            showDetails.ShowTypeLineA = "SciFi";
            showDetails.ShowTypeLineB = "Drama";
            showDetails.Series = 1;
            showDetails.ShortShow = false;
            showDetails.ComdeyShow = false;
            showDetails.ScifiShow = true;

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = "";
            episodeDetails.Title = "Complete story";
            episodeDetails.Description = "By Wally K Daly";
            showDetails.EpisodeDetails.Add(episodeDetails);

            return showDetails;
        }

        // 1920 x 1040
        internal static ShowDetails PopulateShowData()
        {
            return _625Y();
            //return BigJimTheFigaroClub();
            //return HostPlanetEarth();
            //return AliensInTheMind();
            //return MarriottsMonologues_7();
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
    }
}