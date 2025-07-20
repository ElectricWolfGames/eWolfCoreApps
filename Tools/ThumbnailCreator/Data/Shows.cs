using System.Runtime.Intrinsics.X86;
using System.Threading;

namespace ThumbnailCreator.Data
{
    public static partial class Shows
    {
        public static ShowDetails KingofBath()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/23 King of Bath.jpeg";
            showDetails.Title = "King of Bath";
            showDetails.TitleLine2 = "";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\23 King of Bath\";
            showDetails.Description = "In the fashionable spa town of Bath, one man is the arbiter of taste and the epitome of elegance: the self-proclaimed ‘King of Bath’, Beau Nash. In his capacity as Master of Ceremonies, he presides over the city’s social life, arranging balls and concerts for the ‘ton’, keeping a discreet eye on distinguished visitors and smoothing over any quarrels or disagreements.";
            showDetails.ShowTypeLineA = "Radio";
            showDetails.ShowTypeLineB = "Comedy";
            showDetails.Series = 1;
            showDetails.ShortShow = false;
            showDetails.CompleteShow = false;
            showDetails.ComdeyShow = true;
            showDetails.ScifiShow = false;

            EpisodeDetails s01e01 = new EpisodeDetails();
            s01e01.TitleExtra = "";
            s01e01.Title = "s01e01 By Any Other Name";
            s01e01.Description = "";
            showDetails.EpisodeDetails.Add(s01e01);

            EpisodeDetails s01e02 = new EpisodeDetails();
            s01e02.TitleExtra = "";
            s01e02.Title = "s01e02 Merely Players";
            s01e02.Description = "";
            showDetails.EpisodeDetails.Add(s01e02);

            EpisodeDetails s01e03 = new EpisodeDetails();
            s01e03.TitleExtra = "";
            s01e03.Title = "s01e03 Ars Brevis";
            s01e03.Description = "";
            showDetails.EpisodeDetails.Add(s01e03);

            EpisodeDetails s01e04 = new EpisodeDetails();
            s01e04.TitleExtra = "";
            s01e04.Title = "s01e04 Suffer Little Children";
            s01e04.Description = "";
            showDetails.EpisodeDetails.Add(s01e04);

            EpisodeDetails s01e05 = new EpisodeDetails();
            s01e05.TitleExtra = "";
            s01e05.Title = "s01e05 Blessed Are We";
            s01e05.Description = "";
            showDetails.EpisodeDetails.Add(s01e05);

            EpisodeDetails s01e06 = new EpisodeDetails();
            s01e06.TitleExtra = "";
            s01e06.Title = "s01e06 The Clockwork Man";
            s01e06.Description = "";
            showDetails.EpisodeDetails.Add(s01e06);

            return showDetails;
        }

        // 1920 x 1040
        internal static ShowDetails PopulateShowData()
        {
            return KingofBath();
            //return Leviathan99();
            //return Relocation();
            //return PleaseUseOtherDoor();
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