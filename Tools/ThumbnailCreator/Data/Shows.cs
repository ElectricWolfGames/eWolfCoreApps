using System.Runtime.Intrinsics.X86;
using System.Threading;

namespace ThumbnailCreator.Data
{
    public static partial class Shows
    {
        public static ShowDetails Leviathan99()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/Scifi/06 Leviathan 99.jpeg";
            showDetails.Title = "Leviathan 99";
            showDetails.TitleLine2 = "Complete Story\nBy Ray Bradbury";
            showDetails.Path = $@"E:\_AudioTemp\Scifi\_Uploading_SciFi\06 Leviathan '99\";
            showDetails.Description = "A fantastical adaptation of Moby Dick, Ray Bradbury takes audiences past the moon and the stars in search of the greatest and brightest comet in the universe. Join a deranged captain, an eight-foot-tall telepathic spider, and our reluctant hero. You can call him Ishmael.";
            showDetails.ShowTypeLineA = "SciFi";
            showDetails.ShowTypeLineB = "Drama";
            showDetails.Series = 1;
            showDetails.ShortShow = false;
            showDetails.CompleteShow = true;
            showDetails.ComdeyShow = false;
            showDetails.ScifiShow = true;

            EpisodeDetails s01e01 = new EpisodeDetails();
            s01e01.TitleExtra = "";
            s01e01.Title = "Complete Story";
            s01e01.Description = "";
            showDetails.EpisodeDetails.Add(s01e01);

            return showDetails;
        }

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

        public static ShowDetails Relocation()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/22 Relocation.jpeg";
            showDetails.Title = "Relocation ";
            showDetails.TitleLine2 = "";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\22 Relocation\";
            showDetails.Description = "Comedy about a couple in witness relocation in the Welsh Valleys";
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
            s01e01.Description = "John and Sarah's life is turned upside down. As they're forced into a witness protection scheme, they wave goodbye to their life in London, change their names and embrace the charm of a Welsh town with a name they struggle to pronounce.";
            showDetails.EpisodeDetails.Add(s01e01);

            EpisodeDetails s01e02 = new EpisodeDetails();
            s01e02.TitleExtra = "";
            s01e02.Title = "s01e02 Episode Two";
            s01e02.Description = "John and Sarah adjust to a new life as Brian and Helen in Hirwaun, but robot babies and their neighbour knowing they are in witness protection start to complicate things.";
            showDetails.EpisodeDetails.Add(s01e02);

            EpisodeDetails s01e03 = new EpisodeDetails();
            s01e03.TitleExtra = "";
            s01e03.Title = "s01e03 Episode Three";
            s01e03.Description = "John and Sarah's motormouth neighbour Ioan now knows pretty much everything about them, and John faces some unwanted national attention.";
            showDetails.EpisodeDetails.Add(s01e03);

            EpisodeDetails s01e04 = new EpisodeDetails();
            s01e04.TitleExtra = "";
            s01e04.Title = "s01e04 Episode Four";
            s01e04.Description = "John finds out Ioan had been searching for the man he helped send to prison, and things take an unexpected and thoroughly unwelcome turn.";
            showDetails.EpisodeDetails.Add(s01e04);

            EpisodeDetails s02e01 = new EpisodeDetails();
            s02e01.TitleExtra = "";
            s02e01.Title = "s02e01 Episode One";
            s02e01.Description = "John and Sarah face yet another spell in witness protection. If being new parents wasn't enough, now they're relocating to the hometown of the officer in charge of their safety.";
            showDetails.EpisodeDetails.Add(s02e01);

            EpisodeDetails s02e02 = new EpisodeDetails();
            s02e02.TitleExtra = "";
            s02e02.Title = "s02e02 Episode Two";
            s02e02.Description = "Sarah takes on an undercover mission to find the criminal her and husband John are hiding from. Meanwhile, John makes a surprising discovery about the leader of his baby class.";
            showDetails.EpisodeDetails.Add(s02e02);

            EpisodeDetails s02e03 = new EpisodeDetails();
            s02e03.TitleExtra = "";
            s02e03.Title = "s02e03 Episode Three";
            s02e03.Description = "It's Christmas, but living under a witness protection scheme means John and Sarah don't feel very festive, while Ioan receives the job offer of a lifetime. Toby forms a new team to hunt down murderer Darren Bayes, John experiences a case of mistaken identity at the baby class, and Sarah is invited to an incredibly dangerous dinner party.";
            showDetails.EpisodeDetails.Add(s02e03);

            EpisodeDetails s02e04 = new EpisodeDetails();
            s02e04.TitleExtra = "";
            s02e04.Title = "s02e04 Episode Four";
            s02e04.Description = "Things reach peak calamity in the world of witness protection.";
            showDetails.EpisodeDetails.Add(s02e04);

            return showDetails;
        }

        // 1920 x 1040
        internal static ShowDetails PopulateShowData()
        {
            return Leviathan99();
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