using System.Threading;

namespace ThumbnailCreator.Data
{
    public static partial class Shows
    {
        public static ShowDetails PlumHouse()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/19 Plum House.jpeg";
            showDetails.Title = "Plum House";
            showDetails.TitleLine2 = "Comedy about the eccentric and inept staff at Plum House, former country home of minor 18th-century poet George Pudding. Written by Ben Cottam and Paul Mckenna.";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\19 Plum House\";
            showDetails.Description = "";
            showDetails.ShowTypeLineA = "Radio";
            showDetails.ShowTypeLineB = "Comedy";
            showDetails.Series = 3;
            showDetails.ShortShow = false;
            showDetails.CompleteShow = false;
            showDetails.ComdeyShow = true;
            showDetails.ScifiShow = false;

            EpisodeDetails s01e01 = new EpisodeDetails();
            s01e01.TitleExtra = "";
            s01e01.Title = "s01e01 Why Why Wi?";
            s01e01.Description = "The museum's preparations for the annual WI visit include hiding away valuable artefacts, as - according to Peter - some members are prone to stealing them. And Julian gives a disastrous lecture on the life and work of George Pudding.";
            showDetails.EpisodeDetails.Add(s01e01);

            EpisodeDetails s01e02 = new EpisodeDetails();
            s01e02.TitleExtra = "";
            s01e02.Title = "s01e02 Perilously Poorly Peter";
            s01e02.Description = "Peter is forced to visit town. He leaves his hopelessly out-of-touch deputy Julian in charge, who sees it as a perfect opportunity for him to finally make his mark on the place.";
            showDetails.EpisodeDetails.Add(s01e02);

            EpisodeDetails s01e03 = new EpisodeDetails();
            s01e03.TitleExtra = "";
            s01e03.Title = "s01e03 Trust The Trust";
            s01e03.Description = "A mysterious visitor arrives. When he shows genuine interest in how the place is run, the team immediately suspect he has been sent by the Trust to spy on them.";
            showDetails.EpisodeDetails.Add(s01e03);

            EpisodeDetails s01e04 = new EpisodeDetails();
            s01e04.TitleExtra = "";
            s01e04.Title = "s01e04 Peter v Prynne";
            s01e04.Description = "Tom has organised a special summer event and invited the great and good from the world of George Pudding scholarship. But with Peter encountering his arch nemesis - the unbearably pompous Mungo Prynne, Julian upsetting a neighbouring farmer and Emma rather enjoying the plum punch, will it be remembered for the right reasons?";
            showDetails.EpisodeDetails.Add(s01e04);

            EpisodeDetails s01e05 = new EpisodeDetails();
            s01e05.TitleExtra = "";
            s01e05.Title = "s01e05 The Rather Risky Ramble";
            s01e05.Description = "Tom returns from a team building course in London to find the Plum House team have been bickering in his absence.";
            showDetails.EpisodeDetails.Add(s01e05);

            EpisodeDetails s01e06 = new EpisodeDetails();
            s01e06.TitleExtra = "";
            s01e06.Title = "s01e06 Lights, Camera, Pudding";
            s01e06.Description = "The team at the museum are startled to hear that Peter has agreed to Plum House being used as a location in a period drama.";
            showDetails.EpisodeDetails.Add(s01e06);

            EpisodeDetails s02e01 = new EpisodeDetails();
            s02e01.TitleExtra = "";
            s02e01.Title = "s02e01 A Sound Investment";
            s02e01.Description = "The team are making an audio tour they hope will bring visitors flocking in. But they can't agree on who will star in the recording, and Tom has a bigger problem when he accidentally breaks the most valuable artefact in the museum.";
            showDetails.EpisodeDetails.Add(s02e01);

            EpisodeDetails s02e02 = new EpisodeDetails();
            s02e02.TitleExtra = "";
            s02e02.Title = "s02e02 Thief Encounter";
            s02e02.Description = "Peter and Julian are determined to retrieve a valuable pudding artefact and they've enlisted the help of a crooked connection to do so. Emma and Tom try to keep everyone on the straight and narrow - but Maureen finds herself mysteriously drawn to the shady visitor.";
            showDetails.EpisodeDetails.Add(s02e02);

            EpisodeDetails s02e03 = new EpisodeDetails();
            s02e03.TitleExtra = "";
            s02e03.Title = "s02e03 Black Pudding";
            s02e03.Description = "The offer of an honorary degree at a less than prestigious ex-polytechnic sends Peter into a depressive spiral, as he questions whether he has wasted his life. The team call on the chief psychiatrist to the academic profession, the radical Doctor Bloch.";
            showDetails.EpisodeDetails.Add(s02e03);

            EpisodeDetails s02e04 = new EpisodeDetails();
            s02e04.TitleExtra = "";
            s02e04.Title = "s02e04 Death Comes To Plum House";
            s02e04.Description = "Tom has organised a Murder Mystery event at Plum House. But when a storm prevents the visitors from reaching the museum, the team decide to try the game themselves. Maureen is determined to prove the murderer is Julian, while Peter is carried away with his new person - but a bloodcurdling scream from Alan means the team have a real mystery to solve.";
            showDetails.EpisodeDetails.Add(s02e04);

            EpisodeDetails s02e05 = new EpisodeDetails();
            s02e05.TitleExtra = "";
            s02e05.Title = "s02e05 Hot Quiz";
            s02e05.Description = "A local pub quiz becomes the arena to decide who is best and smartest at Plum House after Tom decides that Peter and Julian should no longer be in charge of the finances.";
            showDetails.EpisodeDetails.Add(s02e05);

            EpisodeDetails s02e06 = new EpisodeDetails();
            s02e06.TitleExtra = "";
            s02e06.Title = "s02e06 Wedding Bells";
            s02e06.Description = "The team are preparing to host their first wedding at the museum. With a journalist coming to cover the event, it's a publicity coup for Plum House. But the groom has cold feet. Can they carry on regardless with a fake wedding? Tom is dubious - until Julian suggests he might pretend to marry Emma.";
            showDetails.EpisodeDetails.Add(s02e06);

            EpisodeDetails s03e01 = new EpisodeDetails();
            s03e01.TitleExtra = "";
            s03e01.Title = "s03e01 Better The Devil";
            s03e01.Description = "With manager Tom off on leave, the arrival of Roger from Head Office - sent to reform the operation, is a shock to them all. How will they get rid of him and entice Tom back?";
            showDetails.EpisodeDetails.Add(s03e01);

            EpisodeDetails s03e02 = new EpisodeDetails();
            s03e02.TitleExtra = "";
            s03e02.Title = "s03e02 #SO BRITISH";
            s03e02.Description = "The curator Peter Knight finds unlikely TV fame when he is featured on an ancestry show helping Derren Brown trace his roots to the museum.";
            showDetails.EpisodeDetails.Add(s03e02);

            EpisodeDetails s03e03 = new EpisodeDetails();
            s03e03.TitleExtra = "";
            s03e03.Title = "s03e03 A Knight to Remember";
            s03e03.Description = "The Plum House team are once again invited to the Museum of the Year awards in London, leaving Julian in charge in Tom and Peter's absence.";
            showDetails.EpisodeDetails.Add(s03e03);

            EpisodeDetails s03e04 = new EpisodeDetails();
            s03e04.TitleExtra = "";
            s03e04.Title = "s03e04 Grace and Favour";
            s03e04.Description = "Tom hopes to earn some funds for the museum by renting out Peter's apartment. Meanwhile there's love in the air for Tom and Julian, but not in the way either expects...";
            showDetails.EpisodeDetails.Add(s03e04);

            EpisodeDetails s03e05 = new EpisodeDetails();
            s03e05.TitleExtra = "";
            s03e05.Title = "s03e05 All in Good Faith";
            s03e05.Description = "The team welcome a new vicar to their parish, and Maureen and Alan try in their own way to help with church repairs and maintenance, to disastrous effect. Meanwhile, Tom tries to patch things up with Emma.";
            showDetails.EpisodeDetails.Add(s03e05);

            EpisodeDetails s03e06 = new EpisodeDetails();
            s03e06.TitleExtra = "";
            s03e06.Title = "s03e06 Fete and Fortune";
            s03e06.Description = "Plum House is hosting the annual Summer Fete for the area. Meanwhile Maureen's old nemesis Sue is out to get her...";
            showDetails.EpisodeDetails.Add(s03e06);

            return showDetails;
        }

        // 1920 x 1040
        internal static ShowDetails PopulateShowData()
        {
            return PlumHouse();
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