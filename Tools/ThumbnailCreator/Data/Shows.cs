using System.Threading;

namespace ThumbnailCreator.Data
{
    public static partial class Shows
    {
        public static ShowDetails Bookcases()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/17 Bookcases.jpeg";
            showDetails.Title = "Bookcases";
            showDetails.TitleLine2 = "";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\17 Bookcases\";
            showDetails.Description = "London, 1853, and the sedate religious publishing house of Spavin and Spavin is about to experience a radical shake-up. Vivacious actress Cordelia is on the hunt for her next  husband and has her eye on Gerald, one of the firm's partners, while her son, Primus, has ambitions to take over the firm. And when he does, it'll be out with the Bibles and in with the best sellers - starting with Charlotte Brontë's latest blockbuster....";
            showDetails.ShowTypeLineA = "Radio";
            showDetails.ShowTypeLineB = "Comedy";
            showDetails.Series = 2;
            showDetails.ShortShow = false;
            showDetails.CompleteShow = false;
            showDetails.ComdeyShow = true;
            showDetails.ScifiShow = false;

            EpisodeDetails s01e01 = new EpisodeDetails();
            s01e01.TitleExtra = "";
            s01e01.Title = "s01e01 Bronte Country";
            s01e01.Description = "London 1853, and a firm of religious publishers is transformed by an actress and her son.";
            showDetails.EpisodeDetails.Add(s01e01);

            EpisodeDetails s01e02 = new EpisodeDetails();
            s01e02.TitleExtra = "";
            s01e02.Title = "s01e02 Gone for a Burton";
            s01e02.Description = "1855 - Primus's latest publishing coup is an explorer, but he seems to have lost his way.";
            showDetails.EpisodeDetails.Add(s01e02);

            EpisodeDetails s01e03 = new EpisodeDetails();
            s01e03.TitleExtra = "";
            s01e03.Title = "s01e03 The Man in White";
            s01e03.Description = "Bored by Gerald, Cordelia is having fun with struggling novelist Wilkie Collins.";
            showDetails.EpisodeDetails.Add(s01e03);

            EpisodeDetails s01e04 = new EpisodeDetails();
            s01e04.TitleExtra = "";
            s01e04.Title = "s01e04 The Prosser Prize";
            s01e04.Description = "Primus does his utmost to ensure one of his books will win a literary award.";
            showDetails.EpisodeDetails.Add(s01e04);

            EpisodeDetails s02e01 = new EpisodeDetails();
            s02e01.TitleExtra = "";
            s02e01.Title = "s02e01 Self Help";
            s02e01.Description = "1860 London. Publishing sitcom with Maggie Steed and Elizabeth Spriggs.";
            showDetails.EpisodeDetails.Add(s02e01);

            EpisodeDetails s02e02 = new EpisodeDetails();
            s02e02.TitleExtra = "";
            s02e02.Title = "s02e02 Great Expectations";
            s02e02.Description = "Ailing Victorian publishers Spavin and Spavin hope Charles Dickens can save them.";
            showDetails.EpisodeDetails.Add(s02e02);

            EpisodeDetails s02e03 = new EpisodeDetails();
            s02e03.TitleExtra = "";
            s02e03.Title = "s02e03 Terminal Journals";
            s02e03.Description = "Primus plots to save the firm by publishing deathbed memoirs of the famous.";
            showDetails.EpisodeDetails.Add(s02e03);

            EpisodeDetails s02e04 = new EpisodeDetails();
            s02e04.TitleExtra = "";
            s02e04.Title = "s02e04 Merger Most Foul";
            s02e04.Description = "Edith’s refusal to let Primus publish her books sparks desperate merger talks.";
            showDetails.EpisodeDetails.Add(s02e04);

            return showDetails;
        }

        public static ShowDetails DeepStationEmerald()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/Scifi/05 Deep Station Emerald.jpeg";
            showDetails.Title = "Deep Station Emerald";
            showDetails.TitleLine2 = "";
            showDetails.Path = $@"E:\_AudioTemp\Scifi\_Uploading_SciFi\05 Deep Station Emerald\";
            showDetails.Description = "Joe Turner’s four-part drama is a futuristic undersea thriller. The crew of a research base on the ocean floor discovers a source of cold fusion, the solution to all the world’s energy problems. Elation turns to terror, however, when a series of ‘accidents’ causes several deaths, and a strange virus which mutates DNA is loosed… obviously, someone on board is a killer…";
            showDetails.ShowTypeLineA = "SciFi";
            showDetails.ShowTypeLineB = "Drama";
            showDetails.Series = 1;
            showDetails.ShortShow = false;
            showDetails.CompleteShow = true;
            showDetails.ComdeyShow = false;
            showDetails.ScifiShow = true;

            EpisodeDetails s01e01 = new EpisodeDetails();
            s01e01.TitleExtra = "";
            s01e01.Title = "s01e01 Five Miles Down";
            s01e01.Description = "";
            showDetails.EpisodeDetails.Add(s01e01);

            EpisodeDetails s01e02 = new EpisodeDetails();
            s01e02.TitleExtra = "";
            s01e02.Title = "s01e02 Conspiracy";
            s01e02.Description = "";
            showDetails.EpisodeDetails.Add(s01e02);

            EpisodeDetails s01e03 = new EpisodeDetails();
            s01e03.TitleExtra = "";
            s01e03.Title = "s01e03 Heat";
            s01e03.Description = "";
            showDetails.EpisodeDetails.Add(s01e03);

            EpisodeDetails s01e04 = new EpisodeDetails();
            s01e04.TitleExtra = "";
            s01e04.Title = "s01e04 And Then There Were Three";
            s01e04.Description = "";
            showDetails.EpisodeDetails.Add(s01e04);

            return showDetails;
        }

        // 1920 x 1040
        internal static ShowDetails PopulateShowData()
        {
            return DeepStationEmerald();
            //return Bookcases();
            //return RigorMortis();
            //return DetectiveSergeantNickMohammed();
            //return Married();
            //return _1834();
            //return WelcomeToOurVillagePleaseInvadeCarefully();
            //return Dot();
            //return RobinWendysWetWeekends();
            //return LittleMonster();
            //return Ectoplasm();
            //return APlagueOfGoodness();
            //return _625Y();
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