namespace ThumbnailCreator.Data
{
    public static partial class Shows
    {
        private static ShowDetails HobbyBobbies()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/Hobby Bobbies.jpeg";
            showDetails.Title = "Hobby Bobbies";
            showDetails.Path = $@"E:\_AudioTemp\_Ark\Comedy\Hobby Bobbies\";
            showDetails.Description = "";
            showDetails.Episodes = "";
            showDetails.Series = 2;

            EpisodeDetails episodeDetails;

            for (int i = 0; i < 4; i++)
            {
                episodeDetails = new EpisodeDetails();
                episodeDetails.TitleExtra = ": Series 1";
                episodeDetails.Title = $"s01e0{i}";
                episodeDetails.Description = "";
                showDetails.EpisodeDetails.Add(episodeDetails);
            }
            for (int i = 0; i < 4; i++)
            {
                episodeDetails = new EpisodeDetails();
                episodeDetails.TitleExtra = ": Series 2";
                episodeDetails.Title = $"s02e0{i}";
                episodeDetails.Description = "";
                showDetails.EpisodeDetails.Add(episodeDetails);
            }

            return showDetails;
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

        private static ShowDetails SetRudyRareRecords()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/Rudys Rarer Rcords.jpeg";
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
            episodeDetails.Title = "s03e01 No Richie, No Cry";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 3";
            episodeDetails.Title = "s03e02 It's A Family Affair";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 3";
            episodeDetails.Title = "s03e03 Redemption Song";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 3";
            episodeDetails.Title = "s03e04 Rudy's Rare Record";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 3";
            episodeDetails.Title = "s03e05 Lights Out";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 3";
            episodeDetails.Title = "s03e06 Girls and Boys";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 4";
            episodeDetails.Title = "s04e01 Three's a Crowd";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 4";
            episodeDetails.Title = "s04e02 Best Local Business";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 4";
            episodeDetails.Title = "s04e03 Let It Grow";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 4";
            episodeDetails.Title = "s04e04 It's Grim Up North";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 4";
            episodeDetails.Title = "s04e05 Miss Reenie Comes to Stay";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 4";
            episodeDetails.Title = "s04e06 Sound of da Police";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            return showDetails;
        }
    }
}