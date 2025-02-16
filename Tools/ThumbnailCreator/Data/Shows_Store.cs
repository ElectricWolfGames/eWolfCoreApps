using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
