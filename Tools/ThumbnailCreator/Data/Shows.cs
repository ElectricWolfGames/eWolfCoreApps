namespace ThumbnailCreator.Data
{
    public static partial class Shows
    {
        // 1920 x 1040
        internal static ShowDetails PopulateStarShipData()
        {
            return SetClaytonGrange();
            //return SetRudyRareRecords();
            //return SetAnsgstrom();
            //return HobbyBobbies();
            //return Nebulous();
        }

  
        private static ShowDetails SetClaytonGrange()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/Clayton Grange Title.png";
            showDetails.Title = "Clayton Grange";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading\Clayton Grange\";
            showDetails.Description = "Comedy set around Clayton Grange, a top secret Scientific Institute with a government brief to solve the global fuel crisis, cheer people up and make war just a bit more gentle.";
            showDetails.Episodes = "4";
            showDetails.Series = 2;

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e01";
            episodeDetails.Description = "The staff at Clayton Grange are trying to find a way of making the nation happy.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e02";
            episodeDetails.Description = "The team of brilliantly stupid scientists attempt to solve the global fuel crisis. With a hamster.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e03";
            episodeDetails.Description = "The team attempt to make war just a bit more gentle. Meet the scientists who are a bit rubbish at life. And not much better at science.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e04";
            episodeDetails.Description = "Meet the scientists who are a bit rubbish at life. And not much better at science.";
            showDetails.EpisodeDetails.Add(episodeDetails);



            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 2";
            episodeDetails.Title = "s02e01";
            episodeDetails.Description = "The team launch their revolutionary spray-on clothes, a local MP comes to visit to boost his election campaign and an embarrassing virus escapes from genetics and threatens the very nature of democracy.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 2";
            episodeDetails.Title = "s02e02";
            episodeDetails.Description = "Professor Saunders hopes to persuade his elderly aunt to leave her fortune to science. Meanwhile, his team develop a gun powered simply by thought, but no-one succeeds in thinking very well.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 2";
            episodeDetails.Title = "s02e03";
            episodeDetails.Description = "Geoff cannot resist using a 'bring your child to work day' to do some controversial genetic manipulation, while Saunders trials a bionic suit that recycles your own urine.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 2";
            episodeDetails.Title = "s02e04";
            episodeDetails.Description = "Spurred on by Saunders, the weary scientific team tries to impress a visiting Nobel Prize judge with their self-replicating killer robo-ants.\r\n";
            showDetails.EpisodeDetails.Add(episodeDetails);


            return showDetails;
        }
        }
    }