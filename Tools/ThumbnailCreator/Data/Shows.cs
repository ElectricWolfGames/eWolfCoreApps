using System.Threading;

namespace ThumbnailCreator.Data
{
    public static partial class Shows
    {
        

        // 1920 x 1040
        internal static ShowDetails PopulateShowData()
        {
            return Married();
            return _1834();
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

        public static ShowDetails Married()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/15 Married.jpeg";
            showDetails.Title = "Married";
            showDetails.TitleLine2 = "";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\15 Married\";
            showDetails.Description = "Sci-fi sitcom about Robin Lightfoot, a confirmed bachelor who wakes up one day in a parallel universe where he is married with two children.";
            showDetails.ShowTypeLineA = "Radio";
            showDetails.ShowTypeLineB = "Comedy";
            showDetails.Series = 3;
            showDetails.ShortShow = false;
            showDetails.CompleteShow = false;
            showDetails.ComdeyShow = true;
            showDetails.ScifiShow = false;


            EpisodeDetails s01e01 = new EpisodeDetails();
            s01e01.TitleExtra = "";
            s01e01.Title = "s01e01 Episodes 1";
            s01e01.Description = "Robin Lightfoot is grumpy yet happily single. Then one morning he wakes up to discover he's in a parallel universe. He's got a wife and two children.Is it a nightmare, a practical joke or something much more sinister ?";
            showDetails.EpisodeDetails.Add(s01e01);

            EpisodeDetails s01e02 = new EpisodeDetails();
            s01e02.TitleExtra = "";
            s01e02.Title = "s01e02 Episodes 2";
            s01e02.Description = "Robin Lightfoot has awoken in a parallel universe - not only does he have a family, but two half-brothers, both called Ian.";
            showDetails.EpisodeDetails.Add(s01e02);

            EpisodeDetails s01e03 = new EpisodeDetails();
            s01e03.TitleExtra = "";
            s01e03.Title = "s01e03 Episodes 3";
            s01e03.Description = "Bachelor Robin Lightfoot is feeling a little warmer towards his adopted 'wife' - but then he discovers 'his' past misdemeanours and his doppelganger's other woman turns up to rock the boat.";
            showDetails.EpisodeDetails.Add(s01e03);

            EpisodeDetails s01e04 = new EpisodeDetails();
            s01e04.TitleExtra = "";
            s01e04.Title = "s01e04 Episodes 4";
            s01e04.Description = "Robin is starting like his life in a parallel universe as a married man. But he is completely thrown when the children's entertainer he has booked for his son's birthday party turns out to be comedian Arthur Smith from his old universe.";
            showDetails.EpisodeDetails.Add(s01e04);

            EpisodeDetails s01e05 = new EpisodeDetails();
            s01e05.TitleExtra = "";
            s01e05.Title = "s01e05 Episodes 5";
            s01e05.Description = "Just as he is starting to make the most of his new life, Robin is whisked back to his old universe, where his doppelganger has been wreaking havoc.";
            showDetails.EpisodeDetails.Add(s01e05);

            EpisodeDetails s01e06 = new EpisodeDetails();
            s01e06.TitleExtra = "";
            s01e06.Title = "s01e06 Episodes 6";
            s01e06.Description = "Robin is accused of murdering his new family and blackmailed for a divorce settlement.Two small questions: how is he going to win his new wife back, and how is he going to avoid the death penalty ?";
            showDetails.EpisodeDetails.Add(s01e06);


            EpisodeDetails s02e01 = new EpisodeDetails();
            s02e01.TitleExtra = "";
            s02e01.Title = "s02e01 Churlish";
            s02e01.Description = "Life is about to change with Robin's divorce from the woman he was never married to in the first place.";
            showDetails.EpisodeDetails.Add(s02e01);

            EpisodeDetails s02e02 = new EpisodeDetails();
            s02e02.TitleExtra = "";
            s02e02.Title = "s02e02 The Truth Is Out There";
            s02e02.Description = "Robin uses a scam from his old universe to make himself rich in his new universe. In the process he attracts the attention of the security services and learns the horrible truth about Operation War of the Worlds.";
            showDetails.EpisodeDetails.Add(s02e02);

            EpisodeDetails s02e03 = new EpisodeDetails();
            s02e03.TitleExtra = "";
            s02e03.Title = "s02e03 Betrayal";
            s02e03.Description = "Divorced and penniless though he may be, Robin is about to discover that life can be sweet in his new universe - even if it is at someone else's expense.";
            showDetails.EpisodeDetails.Add(s02e03);

            EpisodeDetails s02e04 = new EpisodeDetails();
            s02e04.TitleExtra = "";
            s02e04.Title = "s02e04 Identity";
            s02e04.Description = "Robin has trouble with parallel worlds - there are 232 of him. Then he meets a woman he knew from another life. Confused? He is.";
            showDetails.EpisodeDetails.Add(s02e04);

            EpisodeDetails s02e05 = new EpisodeDetails();
            s02e05.TitleExtra = "";
            s02e05.Title = "s02e05 Serenity";
            s02e05.Description = "It has been a taxing few months for Robin in his new universe. But at last he seems to have tapped that well of inner peace. Or is there a more obvious explanation?";
            showDetails.EpisodeDetails.Add(s02e05);

            EpisodeDetails s02e06 = new EpisodeDetails();
            s02e06.TitleExtra = "";
            s02e06.Title = "s02e06 War Of The Worlds";
            s02e06.Description = "It is a fight to the death as Robin finally meets his doppelganger. When two universes collide, there can be only one winner.";
            showDetails.EpisodeDetails.Add(s02e06);


            EpisodeDetails s03e01 = new EpisodeDetails();
            s03e01.TitleExtra = "";
            s03e01.Title = "s03e01 Episodes 1";
            s03e01.Description = "To his horror, Robin is going through a phase of being nice. But 'wife' Lesley is now an artist and doesn't want to know him. So Robin is left holding the baby - well, two teenagers and three babies.";
            showDetails.EpisodeDetails.Add(s03e01);

            EpisodeDetails s03e02 = new EpisodeDetails();
            s03e02.TitleExtra = "";
            s03e02.Title = "s03e02 Episodes 2";
            s03e02.Description = "The two universes have collided and Dirk sees an ideal opportunity to make money: he opens Cafe Apocalypse.";
            showDetails.EpisodeDetails.Add(s03e02);

            EpisodeDetails s03e03 = new EpisodeDetails();
            s03e03.TitleExtra = "";
            s03e03.Title = "s03e03 Episodes 3";
            s03e03.Description = "The King's ex, Adrian Turnball, quite literally drops in on Robin and Co after being trapped in a vortex for five weeks.";
            showDetails.EpisodeDetails.Add(s03e03);

            EpisodeDetails s03e04 = new EpisodeDetails();
            s03e04.TitleExtra = "";
            s03e04.Title = "s03e04 Episodes 4";
            s03e04.Description = "Robin, Leslie and Dirk go for a drive - through a time anomaly - and find themselves in deepest, darkest Texas.";
            showDetails.EpisodeDetails.Add(s03e04);

            EpisodeDetails s03e05 = new EpisodeDetails();
            s03e05.TitleExtra = "";
            s03e05.Title = "s03e05 Episodes 3";
            s03e05.Description = "Robin has encountered many strange phenomena since the universes collided. Today he has two Arthur Smiths for the price of one.";
            showDetails.EpisodeDetails.Add(s03e05);

            EpisodeDetails s03e06 = new EpisodeDetails();
            s03e06.TitleExtra = "";
            s03e06.Title = "s03e06 Episodes 4";
            s03e06.Description = "Grumpy bachelor Robin Lightfoot suddenly realises he must have been personally responsible for the two universes colliding when he travels back in time to the day he was born.";
            showDetails.EpisodeDetails.Add(s03e06);

            return showDetails;
        }

        public static ShowDetails _1834()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/14 1834.jfif";
            showDetails.Title = "1834";
            showDetails.TitleLine2 = "";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\14 1834\";
            showDetails.Description = "Comedy series about a 21st Century English teacher from Cheadle Hulme who wakes up to find himself in Macclesfield - in 1834";
            showDetails.ShowTypeLineA = "Radio";
            showDetails.ShowTypeLineB = "Comedy";
            showDetails.Series = 1;
            showDetails.ShortShow = false;
            showDetails.CompleteShow = false;
            showDetails.ComdeyShow = true;
            showDetails.ScifiShow = false;



            EpisodeDetails s01e01 = new EpisodeDetails();
            s01e01.TitleExtra = "";
            s01e01.Title = "s01e01 What Century Are You Living In?";
            s01e01.Description = "After a few drinks, English teacher Jason Slater wakes up in the 19th century.";
            showDetails.EpisodeDetails.Add(s01e01);

            EpisodeDetails s01e02 = new EpisodeDetails();
            s01e02.TitleExtra = "";
            s01e02.Title = "s01e02 The Time Machine";
            s01e02.Description = "Jason decides that the invention of the toasted sandwich maker will sort out his new 19th century life.";
            showDetails.EpisodeDetails.Add(s01e02);

            EpisodeDetails s01e03 = new EpisodeDetails();
            s01e03.TitleExtra = "";
            s01e03.Title = "s01e03 Strong Continental Lager";
            s01e03.Description = "What 19th century Macclesfield really needs is a decent pub, serving decent lager. Jason is just the man to organise it, or so he thinks.";
            showDetails.EpisodeDetails.Add(s01e03);

            EpisodeDetails s01e04 = new EpisodeDetails();
            s01e04.TitleExtra = "";
            s01e04.Title = "s01e04 Dentists And Lovers";
            s01e04.Description = "Ned needs root canal work, but 21st century Jason needs lessons in 19th century courting.";
            showDetails.EpisodeDetails.Add(s01e04);

            EpisodeDetails s01e05 = new EpisodeDetails();
            s01e05.TitleExtra = "";
            s01e05.Title = "s01e05 London";
            s01e05.Description = "Bored witless by one street Macclesfield, Jason suggests a trip to London, to general delight. But a mint popping highwayman soon changes everyone's plans.";
            showDetails.EpisodeDetails.Add(s01e05);

            EpisodeDetails s01e06 = new EpisodeDetails();
            s01e06.TitleExtra = "";
            s01e06.Title = "s01e06 Victorian Principles";
            s01e06.Description = "The young Queen Victoria is coming to Woolsley House for a visit. When Jason invents the electric guitar, he unwittingly changes the course of history.";
            showDetails.EpisodeDetails.Add(s01e06);


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
        public static ShowDetails Dot()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/12 Dot.jpeg";
            showDetails.Title = "Dot";
            showDetails.TitleLine2 = "";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\12 Dot (BBC)\";
            showDetails.Description = "Rollicking wartime comedy set in the personnel department of the Cabinet War Rooms. Sitcom by Ed Harris.";
            showDetails.ShowTypeLineA = "Radio";
            showDetails.ShowTypeLineB = "Comedy";
            showDetails.Series = 3;
            showDetails.ShortShow = false;
            showDetails.CompleteShow = false;
            showDetails.ComdeyShow = true;
            showDetails.ScifiShow = false;



            EpisodeDetails s01e01 = new EpisodeDetails();
            s01e01.TitleExtra = "";
            s01e01.Title = "s01e01 The Astonishing Adventures Of Agent Whiff-Whaff";
            s01e01.Description = "Dot and the gals from personnel are getting squiffy over Agent Bertie Whiff-Whaff. Bertie wants Dot promoted, but can Dot handle life on the other side of the hallway?";
            showDetails.EpisodeDetails.Add(s01e01);

            EpisodeDetails s01e02 = new EpisodeDetails();
            s01e02.TitleExtra = "";
            s01e02.Title = "s01e02 The Extraordinary Example Of The Ha'penny Exchange";
            s01e02.Description = "A little East End snotling has found her way into the Cabinet War Rooms. How will Dot dispose of her?";
            showDetails.EpisodeDetails.Add(s01e02);

            EpisodeDetails s01e03 = new EpisodeDetails();
            s01e03.TitleExtra = "";
            s01e03.Title = "s01e03 The Mystery At St. Horribly-Vulture's School For Boys";
            s01e03.Description = "Dot is sent to back to school to enlist a teacher for 'Shhh Bletchley Park', but is he of sound material?";
            showDetails.EpisodeDetails.Add(s01e03);

            EpisodeDetails s01e04 = new EpisodeDetails();
            s01e04.TitleExtra = "";
            s01e04.Title = "s01e04 Eenie Meenie Miney... Spy!";
            s01e04.Description = "The Russian ambassador is in town, Dot and the gals are on surveillance duty. Can they snaffle the Russian secrets?";
            showDetails.EpisodeDetails.Add(s01e04);


            EpisodeDetails s02e01 = new EpisodeDetails();
            s02e01.TitleExtra = "";
            s02e01.Title = "s02e01 Teeth";
            s02e01.Description = "The fellas are going gaga for Myrtle's new gnashers. As Hollywood beckons, how will Dot take the news she is no longer the star of her own show.";
            showDetails.EpisodeDetails.Add(s02e01);

            EpisodeDetails s02e02 = new EpisodeDetails();
            s02e02.TitleExtra = "";
            s02e02.Title = "s02e02 Psychology";
            s02e02.Description = "Peabody's not been the full shilling recently and now Dr Pinkly has arrived to test who is the psychological 'weak link' and everyone's a suspect. Who will be deemed sane and who will be sent to Sunnyside Sanatorium?";
            showDetails.EpisodeDetails.Add(s02e02);

            EpisodeDetails s02e03 = new EpisodeDetails();
            s02e03.TitleExtra = "";
            s02e03.Title = "s02e03 Meat";
            s02e03.Description = "The American ambassador is coming to town, and Dot is in charge of cooking up a storm. She must prepare a delicious cut of veal to woo the Ambassador. It's a shame she just ate it. How will they wriggle out of this one?";
            showDetails.EpisodeDetails.Add(s02e03);

            EpisodeDetails s02e04 = new EpisodeDetails();
            s02e04.TitleExtra = "";
            s02e04.Title = "s02e04 Trees";
            s02e04.Description = "Dot and the gals are tasked with a top secret mission in the countryside. A German plane crashes nearby, will this be Dot's big chance for promotion?";
            showDetails.EpisodeDetails.Add(s02e04);


            EpisodeDetails s03e01 = new EpisodeDetails();
            s03e01.TitleExtra = "";
            s03e01.Title = "s03e01 Saucepans for Spitfires!";
            s03e01.Description = "A national initiative to boost morale causes havoc in the War Rooms.";
            showDetails.EpisodeDetails.Add(s03e01);

            EpisodeDetails s03e02 = new EpisodeDetails();
            s03e02.TitleExtra = "";
            s03e02.Title = "s03e02 Dial M for Myrtle";
            s03e02.Description = "A suspicious death leaves the gals from personnel with no options other than to investigate.";
            showDetails.EpisodeDetails.Add(s03e02);

            EpisodeDetails s03e03 = new EpisodeDetails();
            s03e03.TitleExtra = "";
            s03e03.Title = "s03e03 Dig for Victory!";
            s03e03.Description = "The Women's Land Army are on the hunt for volunteers, and Dot and the gals are whisked off to the countryside to work the land. It is not long before Dot is planning a great escape.";
            showDetails.EpisodeDetails.Add(s03e03);

            EpisodeDetails s03e04 = new EpisodeDetails();
            s03e04.TitleExtra = "";
            s03e04.Title = "s03e04 London Can Take It";
            s03e04.Description = "Can Dot use her resemblance to Vera Lynn to get one over on Millicent as the they seek to ingratiate themselves with the PM?";
            showDetails.EpisodeDetails.Add(s03e04);


            return showDetails;
        }



        public static ShowDetails Ectoplasm()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/Ectoplasm.jpeg";
            showDetails.Title = "Ectoplasm";
            showDetails.TitleLine2 = "";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\09 Ectoplasm\";
            showDetails.Description = "The stories follow the adventures of Lord Zimbabwe (Romero), a \"walker in the ether\", or occult investigator; his friend and collaborator Doctor Lilac (Freedman), a German scientist who has invented various machines.";
            showDetails.ShowTypeLineA = "Radio";
            showDetails.ShowTypeLineB = "Comedy";
            showDetails.Series = 1;
            showDetails.ShortShow = false;
            showDetails.CompleteShow = true;
            showDetails.ComdeyShow = true;
            showDetails.ScifiShow = false;

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = "";
            episodeDetails.Title = "s01e01 The Curse of Tutancommon";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = "";
            episodeDetails.Title = "s01e02 The Case of the Missing Lost Soul";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = "";
            episodeDetails.Title = "s01e03 The Affair of the Baddie's Niece";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = "";
            episodeDetails.Title = "s01e04 The Adventure of the Stupid, Ignorant Americans";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);


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

        public static ShowDetails LittleMonster()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/Little Monster.jpeg";
            showDetails.Title = "Little Monster";
            showDetails.TitleLine2 = "";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\10 Little Monster\";
            showDetails.Description = "A darkly comic look at modern parenthood about a mother coming to grips with the fact that her new child Benjy is a little monster. Literally. With horns, scales, fangs and a habit of bringing in the remains of next door's chickens. But she still loves him/her/it anyway.";
            showDetails.ShowTypeLineA = "Radio";
            showDetails.ShowTypeLineB = "Comedy";
            showDetails.Series = 1;
            showDetails.ShortShow = false;
            showDetails.CompleteShow = true;
            showDetails.ComdeyShow = true;
            showDetails.ScifiShow = false;

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = "";
            episodeDetails.Title = "One off show";
            episodeDetails.Description = "";
            showDetails.EpisodeDetails.Add(episodeDetails);

            return showDetails;
        }
    }
}