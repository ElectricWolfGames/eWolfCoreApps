namespace ThumbnailCreator.Data
{
    public static partial class Shows
    {
        // 1920 x 1040
        internal static ShowDetails PopulateStarShipData()
        {
            //return MarriottsMonologues_3();
            //return MarriottsMonologues_2();
            return MarriottsMonologues_1();

            //return Party();
            //return DoNothingTilYouHearfromMe();
            //return MirandaHartsJokeShop();
            //return SetClaytonGrange();
            //return SetRudyRareRecords();
            //return SetAnsgstrom();
            //return HobbyBobbies();
            //return Nebulous();
        }

        private static ShowDetails DoNothingTilYouHearfromMe()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/05 Do Nothings Until.jpeg";
            showDetails.Title = "Do Nothing 'Til You Hear from Me";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\05 Do Nothings Until\";
            showDetails.Description = "Sitcom about a cantankerous trombone player. Stars Ram John Holder, Yvonne Brewster, George Layton, Sam Kelly, Caroline Lee Johnson and more.";
            showDetails.Episodes = "6";
            showDetails.Series = 2;

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e01 Body and Soul";
            episodeDetails.Description = "At a bandmate's funeral, musicians Roy and George face up to their own mortality.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e02 Let's Face the Music";
            episodeDetails.Description = "Will musicians Roy and George live up to the billing at their comeback gig?";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e03 The Folks Who Live on the Hill";
            episodeDetails.Description = "Vi is sick, and Roy is no help. Then unexpected guests arrive for Victor's birthday party.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e04 Round Midnight";
            episodeDetails.Description = "When an old musician friend turns up after 40 years abroad, Roy begins to smell a rat.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e05 I Could Write a Book";
            episodeDetails.Description = "Roy must face up to life after the loss of Leonard, his beloved trombone.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e06 She's Funny That Way";
            episodeDetails.Description = "Could the return of an old flame mark the end of Roy and George's musical marriage?";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 2";
            episodeDetails.Title = "s02e01 Lulu's Back in Town";
            episodeDetails.Description = "Musician Roy panics when his wife's vivacious sister takes best pal George out for dinner.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 2";
            episodeDetails.Title = "s02e02 I Get Along Without You Very Well";
            episodeDetails.Description = "When Barry's wife walks out, Roy knows the best way to get her back, until rum intervenes.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 2";
            episodeDetails.Title = "s02e03 Swingin' Down the Lane";
            episodeDetails.Description = "Can musicians Roy and George settle a 50-year-old score with their former bandleader?";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 2";
            episodeDetails.Title = "s02e04 Thanks for the Memory";
            episodeDetails.Description = "Can Roy lift George's spirits by organising a very special celebration?";
            showDetails.EpisodeDetails.Add(episodeDetails);

            return showDetails;
        }

        private static ShowDetails MarriottsMonologues_1()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/MM/1 Lion.jpeg";
            showDetails.Title = "Curious little boy and the lion";
            showDetails.TitleLine2 = "With Thora Hird";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\07 Marriotts Monologues\";
            showDetails.Description = "The monologues of Marriott Edgar, performed by actors and comedians";
            showDetails.Episodes = "Marriotts Monologues";
            showDetails.Series = 1;
            showDetails.OneOffShow = true;

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = "";
            episodeDetails.Title = "";

            episodeDetails.Description = "Thora Hird with the classic tales of the curious little boy and the lion.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            return showDetails;
        }

        private static ShowDetails MarriottsMonologues_2()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/MM/3 Goalkeeper Joe.jpeg";
            showDetails.Title = "Goalkeeper Joe";
            showDetails.TitleLine2 = "With Roy Castle";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\07 Marriotts Monologues\";
            showDetails.Description = "The monologues of Marriott Edgar, performed by actors and comedians";
            showDetails.Episodes = "Marriotts Monologues";
            showDetails.Series = 1;
            showDetails.OneOffShow = true;

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = "";
            episodeDetails.Title = "";

            episodeDetails.Description = "Roy Castle is the monologist for 'Goalkeeper Joe'";
            showDetails.EpisodeDetails.Add(episodeDetails);

            return showDetails;
        }

        private static ShowDetails MarriottsMonologues_3()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/MM/3 The Magna Charta.jpeg";
            showDetails.Title = "The Magna Charta";
            showDetails.TitleLine2 = "With Roy Castle";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\07 Marriotts Monologues\";
            showDetails.Description = "The monologues of Marriott Edgar, performed by actors and comedians";
            showDetails.Episodes = "Marriotts Monologues";
            showDetails.Series = 1;
            showDetails.OneOffShow = true;

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = "";
            episodeDetails.Title = "";

            episodeDetails.Description = "Roy Castle is the monologist for 'The Magna Charta'";
            showDetails.EpisodeDetails.Add(episodeDetails);

            return showDetails;
        }

        private static ShowDetails Party()
        {
            ShowDetails showDetails = new ShowDetails();
            showDetails.Source = @"Images/Party v1.jpeg";
            showDetails.Title = "Party";
            showDetails.Path = $@"E:\_AudioTemp\Comedy\_Uploading_B\06 Party\";
            showDetails.Description = "Four young idealists have decided to form a new political party to save the world from itself. The new fifth member, Duncan, sets about saving the world from them.";
            showDetails.Episodes = "6";
            showDetails.Series = 4;

            EpisodeDetails episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e01";
            episodeDetails.Description = "Tom Basden's political satire about five young adults who want to change the world but having no idea how, and little idea why. The group attempt to choose a constitution.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e02";
            episodeDetails.Description = "The friends wrangle over their new party's foreign policy. Or at least they would if they had a pen. The arrival of Phoebe's politically astute older boyfriend threatens the party's future, as Jared's insecurities come bubbling to the surface.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e03";
            episodeDetails.Description = "The Party clarifies its policies on climate change, while Duncan deals with the aftermath of under-cooked chicken sausages from a BBQ. Before long, murder is committed and the young idealists are placed in a compromising position.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 1";
            episodeDetails.Title = "s01e04";
            episodeDetails.Description = "The Party take to the streets with their inaugural protest. If only it wasn't raining. Jared's musical attempts to draw attention backfire painfully and Mel is desperate to get arrested.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 2";
            episodeDetails.Title = "s02e01 All Publicity Is Good Publicity";
            episodeDetails.Description = "The young aspiring politicians of the new political party attempt to step up a gear and get the recognition and publicity they deserve. All they need to do is sort out the diversity of their group first.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 2";
            episodeDetails.Title = "s02e02 It's Technology, Stupid";
            episodeDetails.Description = "The aspiring politicians get to grips with technology and launch a recruiting campaign on the internet.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 2";
            episodeDetails.Title = "s02e03 Prison Ain't All That Bad";
            episodeDetails.Description = "The aspiring MPs use prison-based TV shows as inspiration for their law and order policy.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 2";
            episodeDetails.Title = "s02e04 Is The Party Over?";
            episodeDetails.Description = "The aspiring politicians move on to tackle drugs and housing, but the future of the party looks uncertain as Jared is all set to move to the Isle of Wight.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 3";
            episodeDetails.Title = "s03e01 The Curry";
            episodeDetails.Description = "The group reconvene after their summer break and the ambition steps up a gear.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 3";
            episodeDetails.Title = "s03e02 The Grundy";
            episodeDetails.Description = "This week the group visit Phoebe and 'The Grundy' in hospital.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 3";
            episodeDetails.Title = "s03e03 The Splits";
            episodeDetails.Description = "The party head off to Corby to research for the upcoming by-election.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 3";
            episodeDetails.Title = "s03e04 Radio";
            episodeDetails.Description = "The aspiring politicians get their first radio interview ahead of the by-election.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            episodeDetails = new EpisodeDetails();
            episodeDetails.TitleExtra = ": Series 4";
            episodeDetails.Title = "s04e01 Christmas Special";
            episodeDetails.Description = "The group of aspiring political agitators once again apply their small minds to big problems. This Christmas one-off special sees the team reunite one last time to take on Donald Trump.";
            showDetails.EpisodeDetails.Add(episodeDetails);

            return showDetails;
        }
    }
}