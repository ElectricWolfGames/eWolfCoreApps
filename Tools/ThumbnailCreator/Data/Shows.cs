﻿using System.Runtime.Intrinsics.X86;
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

        public static ShowDetails TheCastle()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/24 The Castle.jpeg";
            showDetails.Title = "The Castle";
            showDetails.TitleLine2 = "";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\24 The Castle\";
            showDetails.Description = "Hie ye to The Castle, a rollicking sitcom set way back then, starring James Fleet (The Vicar Of Dibley), Neil Dudgeon (Life Of Riley, Midsomer Murders), Martha Howe-Douglas (Horrible Histories) & Ingrid Oliver (Doctor Who).";
            showDetails.ShowTypeLineA = "Radio";
            showDetails.ShowTypeLineB = "Comedy";
            showDetails.Series = 4;
            showDetails.ShortShow = false;
            showDetails.CompleteShow = false;
            showDetails.ComdeyShow = true;
            showDetails.ScifiShow = false;

            EpisodeDetails s01e01 = new EpisodeDetails();
            s01e01.TitleExtra = "";
            s01e01.Title = "s01e01 Episodes 1";
            s01e01.Description = "Sir William De Warenne moves into the castle next door, and discovers the lovely Anne. Anne discovers the lovely Sam. Charlotte discovers that she is supposed to stay out of the way.";
            showDetails.EpisodeDetails.Add(s01e01);

            EpisodeDetails s01e02 = new EpisodeDetails();
            s01e02.TitleExtra = "";
            s01e02.Title = "s01e02 Episodes 2";
            s01e02.Description = "An unexpected lion and the world's first satellite dish spell trouble for Anne and Sam Tree's ongoing romance.";
            showDetails.EpisodeDetails.Add(s01e02);

            EpisodeDetails s01e03 = new EpisodeDetails();
            s01e03.TitleExtra = "";
            s01e03.Title = "s01e03 Episodes 3";
            s01e03.Description = "De Warenne decides to woo Lady Anne with a swearing cook and a chocolate fountain. What Ho! magazine features a world exclusive.";
            showDetails.EpisodeDetails.Add(s01e03);

            EpisodeDetails s01e04 = new EpisodeDetails();
            s01e04.TitleExtra = "";
            s01e04.Title = "s01e04 Episodes 4";
            s01e04.Description = "Sir John decides to open a theme castle and Sam Tree decides to save Unicorn Forest. Meanwhile, Anne and Charlotte are looking out for flying sheep.";
            showDetails.EpisodeDetails.Add(s01e04);

            EpisodeDetails s01e05 = new EpisodeDetails();
            s01e05.TitleExtra = "";
            s01e05.Title = "s01e05 Episodes 5";
            s01e05.Description = "The village pub acquires two new mysterious barmaids as Anne and Charlotte plot to ensnare Sam Tree. De Warenne gets in touch with his feminine side whilst Duncan gets in touch with his masculine one.";
            showDetails.EpisodeDetails.Add(s01e05);

            EpisodeDetails s01e06 = new EpisodeDetails();
            s01e06.TitleExtra = "";
            s01e06.Title = "s01e06 Episodes 6";
            s01e06.Description = "Featuring an art exhibition, a strolling footpad, a dodgy flat-pack scaffold and a lawnmower.";
            showDetails.EpisodeDetails.Add(s01e06);

            EpisodeDetails s02e01 = new EpisodeDetails();
            s02e01.TitleExtra = "";
            s02e01.Title = "s02e01 Houston We Have An Problemme";
            s02e01.Description = "Brave knight Sir William De Warenne's dungeon renovation falls foul of the Health and Safety inspectors. Meanwhile Thomas has invented a new rocket.";
            showDetails.EpisodeDetails.Add(s02e01);

            EpisodeDetails s02e02 = new EpisodeDetails();
            s02e02.TitleExtra = "";
            s02e02.Title = "s02e02 Nice To Gavotte You, To Gavotte You Nice";
            s02e02.Description = "The arrival of a new handyman, a mysterious Frenchwoman and a celebrity dance competition puts everyone in a whirl.";
            showDetails.EpisodeDetails.Add(s02e02);

            EpisodeDetails s02e03 = new EpisodeDetails();
            s02e03.TitleExtra = "";
            s02e03.Title = "s02e03 Is This A Turnip That I See Before Me?";
            s02e03.Description = "A troupe of travelling players, a case of mistaken cushions, a spittoon of mead and a high-speed turnip cause collusion and confusion in equal measure.";
            showDetails.EpisodeDetails.Add(s02e03);

            EpisodeDetails s02e04 = new EpisodeDetails();
            s02e04.TitleExtra = "";
            s02e04.Title = "s02e04 Pool Party Of Doom";
            s02e04.Description = "A heatwave and an archaeological excavation leads to an unexpected swimming pool.";
            showDetails.EpisodeDetails.Add(s02e04);

            EpisodeDetails s02e05 = new EpisodeDetails();
            s02e05.TitleExtra = "";
            s02e05.Title = "s02e05 Be Sure To Wear Some Flowers In Your Visor";
            s02e05.Description = "Sir John decides to raise money by holding a rock festival in the grounds of Woodstock. Cue the sounds of the electric lute, new-fangled hummous from the Levant and much disapproval from Pope Innocent VI.";
            showDetails.EpisodeDetails.Add(s02e05);

            EpisodeDetails s02e06 = new EpisodeDetails();
            s02e06.TitleExtra = "";
            s02e06.Title = "s02e06 Something Old, Something New, Something Borrowed, Something Filled With Helium";
            s02e06.Description = "A new suitor for Anne puts De Warenne's visor firmly out of joint, and a primitive sat-nav and some surgically-introduced helium cause chaos at the altar.";
            showDetails.EpisodeDetails.Add(s02e06);

            EpisodeDetails s03e01 = new EpisodeDetails();
            s03e01.TitleExtra = "";
            s03e01.Title = "s03e01 The Dragon Of Mass Destruction";
            s03e01.Description = "De Warenne is in trouble as an official inquiry into the Crusades gets mixed up with a Talent Competition and a Dragon of Mass Destruction. Plus embroidery gets a right dissing.";
            showDetails.EpisodeDetails.Add(s03e01);

            EpisodeDetails s03e02 = new EpisodeDetails();
            s03e02.TitleExtra = "";
            s03e02.Title = "s03e02 The Pilchards Of Doom";
            s03e02.Description = "Sir John grapples with both an adulterous affair and a tin of pilchards. Meanwhile, Thomas explores the secrets of the universe and Anne falls in love with King Russell de Brand.";
            showDetails.EpisodeDetails.Add(s03e02);

            EpisodeDetails s03e03 = new EpisodeDetails();
            s03e03.TitleExtra = "";
            s03e03.Title = "s03e03 The Snowballs Of Hell";
            s03e03.Description = "There's romance in the air for Charlotte as a vicious gang war breaks out in the castle. Meanwhile, De Warenne discovers the fondue and declares martial law.";
            showDetails.EpisodeDetails.Add(s03e03);

            EpisodeDetails s03e04 = new EpisodeDetails();
            s03e04.TitleExtra = "";
            s03e04.Title = "s03e04 The Vuvuzela Of Terror";
            s03e04.Description = "An Englishman's home is his castle and an Englishman's moat is his tax write-off - until Sir John is investigated and has to hire some Frenchmen and a bucket of eels. Meanwhile, the Woodstock Hospital is about to lose its no-star status.";
            showDetails.EpisodeDetails.Add(s03e04);

            EpisodeDetails s03e05 = new EpisodeDetails();
            s03e05.TitleExtra = "";
            s03e05.Title = "s03e05 Four Wiseguys And A Funeral";
            s03e05.Description = "When some gangsters from De Warenne's past pay a little visit, Henry becomes a made man and Charlotte becomes an unmade woman. Plus a clever sting and a souped-up getaway sheep.";
            showDetails.EpisodeDetails.Add(s03e05);

            EpisodeDetails s03e06 = new EpisodeDetails();
            s03e06.TitleExtra = "";
            s03e06.Title = "s03e06 There's No Place Like Woodstock";
            s03e06.Description = "Somewhere, over the rainbow, there is a bunch of idiots from Woodstock and a mysterious man known only as Lord Andrew Lloyd Webber.";
            showDetails.EpisodeDetails.Add(s03e06);

            EpisodeDetails s04e01 = new EpisodeDetails();
            s04e01.TitleExtra = "";
            s04e01.Title = "s04e01 Tender Is The Knight";
            s04e01.Description = "Sir John fills his castle with wounded soldiers and De Warenne fills his trousers with ice. Plus a new valet arrives hotfoot from somewhere called Downton Abbey.";
            showDetails.EpisodeDetails.Add(s04e01);

            EpisodeDetails s04e02 = new EpisodeDetails();
            s04e02.TitleExtra = "";
            s04e02.Title = "s04e02 The Only Way Is Ethics";
            s04e02.Description = "Someone, or something, is hacking into peoples' private conversations and Master Henry could end up in jail. Meanwhile Lady Anne has taken to nuzzling De Warenne's trusty War Horse.";
            showDetails.EpisodeDetails.Add(s04e02);

            EpisodeDetails s04e03 = new EpisodeDetails();
            s04e03.TitleExtra = "";
            s04e03.Title = "s04e03 Highlights & Twilights";
            s04e03.Description = "Two mysterious visitors, one deathly pale and one deathly orange. It's the love that dare not speak its name and the love that can speak its name but can't pronounce it properly.";
            showDetails.EpisodeDetails.Add(s04e03);

            EpisodeDetails s04e04 = new EpisodeDetails();
            s04e04.TitleExtra = "";
            s04e04.Title = "s04e04 Boogie Knights";
            s04e04.Description = "The wedding of the decade is almost ruined by 200 tents and an over-excited woodpecker. Plus Henry, Duncan and De Warenne gatecrash a rather special hen night.";
            showDetails.EpisodeDetails.Add(s04e04);

            EpisodeDetails s04e05 = new EpisodeDetails();
            s04e05.TitleExtra = "";
            s04e05.Title = "s04e05 Give Me the Flaming Torch";
            s04e05.Description = "The Olympics are coming to Woodstock, so what better time for Sir William to go on a go-slow and for Henry to hunt for dragons? Meanwhile, Sir John tries to get fit.";
            showDetails.EpisodeDetails.Add(s04e05);

            EpisodeDetails s04e06 = new EpisodeDetails();
            s04e06.TitleExtra = "";
            s04e06.Title = "s04e06 A Term for the Worse";
            s04e06.Description = "Anne's off to Cambridge, but Charlotte doesn't know the meaning of the word 'thick'. Literally. Is this the end of a beautiful friendship?";
            showDetails.EpisodeDetails.Add(s04e06);

            return showDetails;
        }

        // 1920 x 1040
        internal static ShowDetails PopulateShowData()
        {
            //return TheCastle();
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