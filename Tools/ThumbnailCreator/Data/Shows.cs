using System.Runtime.Intrinsics.X86;
using System.Threading;

namespace ThumbnailCreator.Data
{
    public static partial class Shows
    {
        public static ShowDetails PleaseUseOtherDoor()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/21 Please Use Other Door.jpeg";
            showDetails.Title = "Please Use Other Door";
            showDetails.TitleLine2 = "";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\21 Please Use Other Door\";
            showDetails.Description = "";
            showDetails.ShowTypeLineA = "Radio";
            showDetails.ShowTypeLineB = "Comedy";
            showDetails.Series = 2;
            showDetails.ShortShow = false;
            showDetails.CompleteShow = false;
            showDetails.ComdeyShow = true;
            showDetails.ScifiShow = false;

            EpisodeDetails s01e01 = new EpisodeDetails();
            s01e01.TitleExtra = "";
            s01e01.Title = "s01e01 Episode One";
            s01e01.Description = "A satirical take on modern life. Naturalistic sketches taking a sometimes dark look at the world of work, relationships, institutions and families. Highlights include a goose enrolling as a police officer - and somehow managing to make it through the very tight vetting procedures. There's a character sceptical about time, and a doll-baby so realistic she's more of a nightmare than a toy.";
            showDetails.EpisodeDetails.Add(s01e01);

            EpisodeDetails s01e02 = new EpisodeDetails();
            s01e02.TitleExtra = "";
            s01e02.Title = "s01e02 Episode Two";
            s01e02.Description = "The second show includes a series of sketches in which someone is forced to watch Succession, a man applies for a business loan for a company whose aim is doing evil and a woman dates the Pied Piper.";
            showDetails.EpisodeDetails.Add(s01e02);

            EpisodeDetails s01e03 = new EpisodeDetails();
            s01e03.TitleExtra = "";
            s01e03.Title = "s01e03 Episode Three";
            s01e03.Description = "We attend the Schadenfreude Experience, there is a visit to a pet shop to buy a giraffe, and why you need a sense of humour to be a heart surgeon.";
            showDetails.EpisodeDetails.Add(s01e03);

            EpisodeDetails s01e04 = new EpisodeDetails();
            s01e04.TitleExtra = "";
            s01e04.Title = "s01e04 Episode Four";
            s01e04.Description = "Some parents tell their daughter the truth about Father Christmas, there is a friendly chat during a rugby scrum, and we witness a polite mugging.";
            showDetails.EpisodeDetails.Add(s01e04);

            EpisodeDetails s02e01 = new EpisodeDetails();
            s02e01.TitleExtra = "";
            s02e01.Title = "s02e01 Episode One";
            s02e01.Description = "Can you change your sexual orientation at will? Is it ever fair to blame the children for a divorce? What happens if a therapist brings their own emotional baggage to the treatment room?";
            showDetails.EpisodeDetails.Add(s02e01);

            EpisodeDetails s02e02 = new EpisodeDetails();
            s02e02.TitleExtra = "";
            s02e02.Title = "s02e02 Episode Two";
            s02e02.Description = "How can a tea-cosey help with dating decisions? What would football fans chant if they could express their true feelings? What are some of the do's and don'ts of role play?";
            showDetails.EpisodeDetails.Add(s02e02);

            EpisodeDetails s02e03 = new EpisodeDetails();
            s02e03.TitleExtra = "";
            s02e03.Title = "s02e03 Episode Three";
            s02e03.Description = "Can families be merged like companies? Should ransom notes be aesthetically pleasing? Why do people think truffle hunting in Tuscany would be the ideal life?";
            showDetails.EpisodeDetails.Add(s02e03);

            EpisodeDetails s02e04 = new EpisodeDetails();
            s02e04.TitleExtra = "";
            s02e04.Title = "s02e04 Episode Four";
            s02e04.Description = "How would middle class liberals plan a jewellery heist? What are the categories for the new Modern Man Awards? Why are people in care homes forced into group singing?";
            showDetails.EpisodeDetails.Add(s02e04);

            return showDetails;
        }

        // 1920 x 1040
        internal static ShowDetails PopulateShowData()
        {
            return PleaseUseOtherDoor();
            //return CenturyVampire();
            //            return PlumHouse();
            //return DeepStationEmerald();
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