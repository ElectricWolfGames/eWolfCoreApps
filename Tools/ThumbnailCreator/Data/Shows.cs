using System.Threading;

namespace ThumbnailCreator.Data
{
    public static partial class Shows
    {
        public static ShowDetails RigorMortis()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/18 RigorMortis.jpeg";
            showDetails.Title = "Rigor Mortis";
            showDetails.TitleLine2 = "";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\18 Rigor Mortis\";
            showDetails.Description = "Meet Dr Anthony Webster and Dr Ruth Anderson, two pathologists attempting to live normal lives in an atmosphere of death, decay and seriously unpleasant smells. Anthony loves his chosen profession, finding every cadaver exciting and surprising: 'they're like Kinder eggs that have died'. Ruth, however, longs for a juicy murder mystery, instead of one routine autopsy after another.";
            showDetails.ShowTypeLineA = "Radio";
            showDetails.ShowTypeLineB = "Comedy";
            showDetails.Series = 3;
            showDetails.ShortShow = false;
            showDetails.CompleteShow = false;
            showDetails.ComdeyShow = true;
            showDetails.ScifiShow = false;

            EpisodeDetails s01e01 = new EpisodeDetails();
            s01e01.TitleExtra = "";
            s01e01.Title = "s01e01 Episode 1";
            s01e01.Description = "";
            showDetails.EpisodeDetails.Add(s01e01);

            EpisodeDetails s01e02 = new EpisodeDetails();
            s01e02.TitleExtra = "";
            s01e02.Title = "s01e02 Episode 2";
            s01e02.Description = "";
            showDetails.EpisodeDetails.Add(s01e02);

            EpisodeDetails s01e03 = new EpisodeDetails();
            s01e03.TitleExtra = "";
            s01e03.Title = "s01e03 Episode 3";
            s01e03.Description = "";
            showDetails.EpisodeDetails.Add(s01e03);

            EpisodeDetails s01e04 = new EpisodeDetails();
            s01e04.TitleExtra = "";
            s01e04.Title = "s01e04 Episode 4";
            s01e04.Description = "";
            showDetails.EpisodeDetails.Add(s01e04);

            EpisodeDetails s01e05 = new EpisodeDetails();
            s01e05.TitleExtra = "";
            s01e05.Title = "s01e05 Episode 5";
            s01e05.Description = "";
            showDetails.EpisodeDetails.Add(s01e05);

            EpisodeDetails s01e06 = new EpisodeDetails();
            s01e06.TitleExtra = "";
            s01e06.Title = "s01e06 Episode 6";
            s01e06.Description = "";
            showDetails.EpisodeDetails.Add(s01e06);

            EpisodeDetails s02e01 = new EpisodeDetails();
            s02e01.TitleExtra = "";
            s02e01.Title = "s02e01 Episode 1";
            s02e01.Description = "";
            showDetails.EpisodeDetails.Add(s02e01);

            EpisodeDetails s02e02 = new EpisodeDetails();
            s02e02.TitleExtra = "";
            s02e02.Title = "s02e02 Episode 2";
            s02e02.Description = "";
            showDetails.EpisodeDetails.Add(s02e02);

            EpisodeDetails s02e03 = new EpisodeDetails();
            s02e03.TitleExtra = "";
            s02e03.Title = "s02e03 Episode 3";
            s02e03.Description = "";
            showDetails.EpisodeDetails.Add(s02e03);

            EpisodeDetails s02e04 = new EpisodeDetails();
            s02e04.TitleExtra = "";
            s02e04.Title = "s02e04 Episode 4";
            s02e04.Description = "";
            showDetails.EpisodeDetails.Add(s02e04);

            EpisodeDetails s02e05 = new EpisodeDetails();
            s02e05.TitleExtra = "";
            s02e05.Title = "s02e05 Episode 5";
            s02e05.Description = "";
            showDetails.EpisodeDetails.Add(s02e05);

            EpisodeDetails s02e06 = new EpisodeDetails();
            s02e06.TitleExtra = "";
            s02e06.Title = "s02e06 Episode 6";
            s02e06.Description = "";
            showDetails.EpisodeDetails.Add(s02e06);

            EpisodeDetails s03e01 = new EpisodeDetails();
            s03e01.TitleExtra = "";
            s03e01.Title = "s03e01 Episode 1";
            s03e01.Description = "";
            showDetails.EpisodeDetails.Add(s03e01);

            EpisodeDetails s03e02 = new EpisodeDetails();
            s03e02.TitleExtra = "";
            s03e02.Title = "s03e02 Episode 2";
            s03e02.Description = "";
            showDetails.EpisodeDetails.Add(s03e02);

            EpisodeDetails s03e03 = new EpisodeDetails();
            s03e03.TitleExtra = "";
            s03e03.Title = "s03e03 Episode 3";
            s03e03.Description = "";
            showDetails.EpisodeDetails.Add(s03e03);

            EpisodeDetails s03e04 = new EpisodeDetails();
            s03e04.TitleExtra = "";
            s03e04.Title = "s03e04 Episode 4";
            s03e04.Description = "";
            showDetails.EpisodeDetails.Add(s03e04);

            EpisodeDetails s03e05 = new EpisodeDetails();
            s03e05.TitleExtra = "";
            s03e05.Title = "s03e05 Episode 5";
            s03e05.Description = "";
            showDetails.EpisodeDetails.Add(s03e05);

            EpisodeDetails s03e06 = new EpisodeDetails();
            s03e06.TitleExtra = "";
            s03e06.Title = "s03e06 Episode 6";
            s03e06.Description = "";
            showDetails.EpisodeDetails.Add(s03e06);

            return showDetails;
        }

        public static ShowDetails RobinWendysWetWeekends()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/Robin Wendys Wet Weekends.jpeg";
            showDetails.Title = "Robin and Wendys Wet Weekends";
            showDetails.TitleLine2 = "";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\11 Robin Wendys Wet Weekends - BBC Radio\";
            showDetails.Description = "It revolves around the mundane lives of Robin and Wendy Mayfield. " +
                "Robin tends to be self-centred, demanding and controlling in his relationships. " +
                "Wendy, however, always seems to see the positive side of any situation, " +
                "and, while often frustrated, copes with Robin admirably. Both Robin and Wendy have relatively meaningless bureaucratic jobs.";
            showDetails.ShowTypeLineA = "Radio";
            showDetails.ShowTypeLineB = "Comedy";
            showDetails.Series = 4;
            showDetails.ShortShow = false;
            showDetails.CompleteShow = false;
            showDetails.ComdeyShow = true;
            showDetails.ScifiShow = false;

            EpisodeDetails s01e01 = new EpisodeDetails();
            s01e01.TitleExtra = "";
            s01e01.Title = "s01e01 The Heinrich Manoeuvre";
            s01e01.Description = "";
            showDetails.EpisodeDetails.Add(s01e01);

            EpisodeDetails s01e02 = new EpisodeDetails();
            s01e02.TitleExtra = "";
            s01e02.Title = "s01e02 A Fete Worse Than Death";
            s01e02.Description = "";
            showDetails.EpisodeDetails.Add(s01e02);

            EpisodeDetails s01e03 = new EpisodeDetails();
            s01e03.TitleExtra = "";
            s01e03.Title = "s01e03 A Cavalier Attitude";
            s01e03.Description = "";
            showDetails.EpisodeDetails.Add(s01e03);

            EpisodeDetails s01e04 = new EpisodeDetails();
            s01e04.TitleExtra = "";
            s01e04.Title = "s01e04 Police, Camera, Amphibian";
            s01e04.Description = "";
            showDetails.EpisodeDetails.Add(s01e04);

            EpisodeDetails s01e05 = new EpisodeDetails();
            s01e05.TitleExtra = "";
            s01e05.Title = "s01 Special: Robin & Wendy's Wet Edinburgh Weekend";
            s01e05.Description = "";
            showDetails.EpisodeDetails.Add(s01e05);

            EpisodeDetails s02e01 = new EpisodeDetails();
            s02e01.TitleExtra = "";
            s02e01.Title = "s02e01 Them and Us";
            s02e01.Description = "";
            showDetails.EpisodeDetails.Add(s02e01);

            EpisodeDetails s02e02 = new EpisodeDetails();
            s02e02.TitleExtra = "";
            s02e02.Title = "s02e02 Take the High Road";
            s02e02.Description = "";
            showDetails.EpisodeDetails.Add(s02e02);

            EpisodeDetails s02e03 = new EpisodeDetails();
            s02e03.TitleExtra = "";
            s02e03.Title = "s02e03 Entertaining Mr Stone";
            s02e03.Description = "";
            showDetails.EpisodeDetails.Add(s02e03);

            EpisodeDetails s02e04 = new EpisodeDetails();
            s02e04.TitleExtra = "";
            s02e04.Title = "s02e04 Lassie Go Home";
            s02e04.Description = "";
            showDetails.EpisodeDetails.Add(s02e04);

            EpisodeDetails s02e05 = new EpisodeDetails();
            s02e05.TitleExtra = "";
            s02e05.Title = "s02e05 A Green Unpleasant Land";
            s02e05.Description = "";
            showDetails.EpisodeDetails.Add(s02e05);

            EpisodeDetails s02e06 = new EpisodeDetails();
            s02e06.TitleExtra = "";
            s02e06.Title = "s02e06 About Some Boys";
            s02e06.Description = "";
            showDetails.EpisodeDetails.Add(s02e06);

            EpisodeDetails s03e01 = new EpisodeDetails();
            s03e01.TitleExtra = "";
            s03e01.Title = "s03e01 Alka Salsa";
            s03e01.Description = "";
            showDetails.EpisodeDetails.Add(s03e01);

            EpisodeDetails s03e02 = new EpisodeDetails();
            s03e02.TitleExtra = "";
            s03e02.Title = "s03e02 Dream Genie";
            s03e02.Description = "";
            showDetails.EpisodeDetails.Add(s03e02);

            EpisodeDetails s03e03 = new EpisodeDetails();
            s03e03.TitleExtra = "";
            s03e03.Title = "s03e03 Arrivederci Coma";
            s03e03.Description = "";
            showDetails.EpisodeDetails.Add(s03e03);

            EpisodeDetails s03e04 = new EpisodeDetails();
            s03e04.TitleExtra = "";
            s03e04.Title = "s03e04 Anniversary Waltz";
            s03e04.Description = "";
            showDetails.EpisodeDetails.Add(s03e04);

            EpisodeDetails s04e01 = new EpisodeDetails();
            s04e01.TitleExtra = "";
            s04e01.Title = "s04e01 Autumn Crocus";
            s04e01.Description = "";
            showDetails.EpisodeDetails.Add(s04e01);

            EpisodeDetails s04e02 = new EpisodeDetails();
            s04e02.TitleExtra = "";
            s04e02.Title = "s04e02 Congratulations, It's a Hob Nob";
            s04e02.Description = "";
            showDetails.EpisodeDetails.Add(s04e02);

            EpisodeDetails s04e03 = new EpisodeDetails();
            s04e03.TitleExtra = "";
            s04e03.Title = "s04e03 Baby Love";
            s04e03.Description = "";
            showDetails.EpisodeDetails.Add(s04e03);

            EpisodeDetails s04e04 = new EpisodeDetails();
            s04e04.TitleExtra = "";
            s04e04.Title = "s04e04 Ground Control to Major Derek";
            s04e04.Description = "";
            showDetails.EpisodeDetails.Add(s04e04);

            return showDetails;
        }

        public static ShowDetails WelcomeToOurVillagePleaseInvadeCarefully()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/13 Welcome To Our Village.jfif";
            showDetails.Title = "Welcome To Our Village, Please Invade Carefully";
            showDetails.TitleLine2 = "";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\13 Welcome To Our Village, Please Invade Carefully\";
            showDetails.Description = "Sitcom about an alien invasion of a small village, starring Hattie Morahan";
            showDetails.ShowTypeLineA = "Radio";
            showDetails.ShowTypeLineB = "Comedy";
            showDetails.Series = 2;
            showDetails.ShortShow = false;
            showDetails.CompleteShow = false;
            showDetails.ComdeyShow = true;
            showDetails.ScifiShow = false;

            EpisodeDetails s01e01 = new EpisodeDetails();
            s01e01.TitleExtra = "";
            s01e01.Title = "s01e01 Taking Overs";
            s01e01.Description = "The Geonin alien invaders are challenged to a village cricket match.";
            showDetails.EpisodeDetails.Add(s01e01);

            EpisodeDetails s01e02 = new EpisodeDetails();
            s01e02.TitleExtra = "";
            s01e02.Title = "s01e02 Minimum Volume";
            s01e02.Description = "Katrina attempts to sabotage Uljabaan's post-invasion education programme.";
            showDetails.EpisodeDetails.Add(s01e02);

            EpisodeDetails s01e03 = new EpisodeDetails();
            s01e03.TitleExtra = "";
            s01e03.Title = "s01e03 Power Block";
            s01e03.Description = "A busy Uljabaan asks Margaret to help him to oppress the humans.";
            showDetails.EpisodeDetails.Add(s01e03);

            EpisodeDetails s01e04 = new EpisodeDetails();
            s01e04.TitleExtra = "";
            s01e04.Title = "s01e04 Little Green Lights";
            s01e04.Description = "Uljabaan prepares for an invasion assessment by his superior, Gryvook.";
            showDetails.EpisodeDetails.Add(s01e04);

            EpisodeDetails s02e01 = new EpisodeDetails();
            s02e01.TitleExtra = "";
            s02e01.Title = "s02e01 Counter Plot";
            s02e01.Description = "Richard is alarmed to find that Uljabaan has commandeered six allotments for an experiment";
            showDetails.EpisodeDetails.Add(s02e01);

            EpisodeDetails s02e02 = new EpisodeDetails();
            s02e02.TitleExtra = "";
            s02e02.Title = "s02e02 Tempting Fete";
            s02e02.Description = "Tempers rise preparing for the village fete, and Lucy discovers guitar irritates aliens.";
            showDetails.EpisodeDetails.Add(s02e02);

            EpisodeDetails s02e03 = new EpisodeDetails();
            s02e03.TitleExtra = "";
            s02e03.Title = "s02e03 Questioning Loyalties";
            s02e03.Description = "Collaboration loyalty cards ruin Uljabaan's plans and Richard's chances in the pub quiz.";
            showDetails.EpisodeDetails.Add(s02e03);

            EpisodeDetails s02e04 = new EpisodeDetails();
            s02e04.TitleExtra = "";
            s02e04.Title = "s02e04 Ctrl-Alt-Del";
            s02e04.Description = "The computer catches a very common virus, making the invasion doomed in more ways than one";
            showDetails.EpisodeDetails.Add(s02e04);

            EpisodeDetails s02e05 = new EpisodeDetails();
            s02e05.TitleExtra = "";
            s02e05.Title = "s02e05 Testing Times";
            s02e05.Description = "Lucy must either pass her A-levels or leave the resistance.";
            showDetails.EpisodeDetails.Add(s02e05);

            EpisodeDetails s02e06 = new EpisodeDetails();
            s02e06.TitleExtra = "";
            s02e06.Title = "s02e06 Exit Strategy";
            s02e06.Description = "Uljabaan is determined to fail his annual inspection, but he needs help...";
            showDetails.EpisodeDetails.Add(s02e06);

            return showDetails;
        }

        // 1920 x 1040
        internal static ShowDetails PopulateShowData()
        {
            return RigorMortis();
            return DetectiveSergeantNickMohammed();
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