namespace ThumbnailCreator.Data
{
    public static partial class Shows
    {
        // 1920 x 1040
        internal static ShowDetails PopulateStarShipData()
        {
            return MirandaHartsJokeShop();
            return SetClaytonGrange();
            //return SetRudyRareRecords();
            //return SetAnsgstrom();
            //return HobbyBobbies();
            //return Nebulous();
        }

        private static ShowDetails MirandaHartsJokeShop()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/JokeShop.jpeg";
            showDetails.Title = "Miranda Hart's Joke Shop";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading\03 Miranda Harts Joke Shop\";
            showDetails.Description = "Miranda is an unconventional woman. She's six feet tall, self-conscious and posh. And is frequently mistaken for a man. She's also invested her inheritance in a joke shop that she runs with her friend Stevie while trying to deal with her outrageously embarrassing mother.";
            showDetails.Episodes = "4";
            showDetails.Series = 1;

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e01 What A Flirt";
            episodeDetails.Description = "Miranda flirts with Gary, but is mistaken for a man by passers-by when she un-knowingly buys clothes from a shop for transvestites. Other mix-ups scare Gary away, as they make Miranda look like she is desperate for a baby.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e02 What A Job";
            episodeDetails.Description = "Miranda tries to prove she can get a proper job away from the joke shop.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e03 What A Wife";
            episodeDetails.Description = "Gary needs a pretend wife for the evening and for some reason he chooses Stevie over Miranda.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e04 What An Excuse";
            episodeDetails.Description = "Miranda's mother tries desperately to play Cupid for Miranda.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            return showDetails;
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