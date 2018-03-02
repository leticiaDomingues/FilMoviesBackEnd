using FilMoviesAPI.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesAPI
{
    public class FilMoviesDBInitializer : DropCreateDatabaseAlways<FilMoviesContext>
    {
        protected override void Seed(FilMoviesContext context)
        {
            //Create users
            List<User> users = new List<User> {
                new User() { Username = "let", Password = "123", Name = "Leticia Domingues" }, //users[0]
                new User() { Username = "maria", Password = "123", Name = "Maria Rodrigues" }, //users[1]
                new User() { Username = "isa", Password = "123", Name = "Isabela Sato" },      //users[2]
                new User() { Username = "alex", Password = "123", Name = "Alexsander Baldin" } //users[3]
            };
            context.Users.AddRange(users);

            //Create categories
            List<Category> categories = new List<Category> {
                new Category() { Name = "Drama" },             //categories[0]
                new Category() { Name = "Ação" },              //categories[1]
                new Category() { Name = "Animação" },          //categories[2]
                new Category() { Name = "Aventura" },          //categories[3]
                new Category() { Name = "Comédia" },           //categories[4]
                new Category() { Name = "Documentário" },      //categories[5]
                new Category() { Name = "Ficção Científica" }, //categories[6]
                new Category() { Name = "Guerra" },            //categories[7]
                new Category() { Name = "Romance" },           //categories[8]
                new Category() { Name = "Suspense" },          //categories[9]
                new Category() { Name = "Terror" }             //categories[10]
            };
            context.Categories.AddRange(categories);

            //Create directors
            List<Director> directors = new List<Director> {
                new Director() { Name = "Francis Ford Coppola" }, //directors[0]
                new Director() { Name = "David Fincher" },        //directors[1]
                new Director() { Name = "Guillermo del Toro" },   //directors[2]
                new Director() { Name = "Martin McDonagh" },      //directors[3]
                new Director() { Name = "Greta Gerwig" },         //directors[4]
                new Director() { Name = "Jordan Peele" },         //directors[5]
                new Director() { Name = "Michael Gracey" },       //directors[6]
                new Director() { Name = "Christopher Nolan" },    //directors[7]
                new Director() { Name = "Luca Guadagnino" },      //directors[8]
                new Director() { Name = "Paul Thomas Anderson" }, //directors[9]
                new Director() { Name = "Steven Spielberg" },     //directors[10]
                new Director() { Name = "Joe Wright" },           //directors[11]
                new Director() { Name = "Barry Jenkins" },        //directors[12]
                new Director() { Name = "Kenneth Lonergan" },     //directors[13]
                new Director() { Name = "Damien Chazelle" },      //directors[14]
                new Director() { Name = "Garth Davis" },          //directors[15]
                new Director() { Name = "Denis Villeneuve" },     //directors[16]
                new Director() { Name = "Stephen Chbosky" }       //directors[17]
            };
            context.Directors.AddRange(directors);

            //Create actors
            List<Actor> actors = new List<Actor> {
                new Actor() { Name = "Marlon Brando" },           //actors[0]
                new Actor() { Name = "Al Pacino" },               //actors[1]
                new Actor() { Name = "James Caan" },              //actors[2]
                new Actor() { Name = "Brad Pitt" },               //actors[3]
                new Actor() { Name = "Edward Norton" },           //actors[4]
                new Actor() { Name = "Helena Bonham Carter" },    //actors[5]
                new Actor() { Name = "Sally Hawkins" },           //actors[6]
                new Actor() { Name = "Octavia Spencer" },         //actors[7]
                new Actor() { Name = "Michael Shannon" },         //actors[8]
                new Actor() { Name = "Frances McDormand" },       //actors[9]
                new Actor() { Name = "Woody Harrelson" },         //actors[10]
                new Actor() { Name = "Sam Rockwell" },            //actors[11]
                new Actor() { Name = "Saoirse Ronan" },           //actors[12]
                new Actor() { Name = "Laurie Metcalf" },          //actors[13]
                new Actor() { Name = "Tracy Letts" },             //actors[14]
                new Actor() { Name = "Daniel Kaluuya" },          //actors[15]
                new Actor() { Name = "Allison Williams" },        //actors[16]
                new Actor() { Name = "Bradley Whitford" },        //actors[17]
                new Actor() { Name = "Hugh Jackman" },            //actors[18]
                new Actor() { Name = "Michelle Williams" },       //actors[19]
                new Actor() { Name = "Zac Efron" },               //actors[20]
                new Actor() { Name = "Fionn Whitehead" },         //actors[21]
                new Actor() { Name = "Barry Keoghan" },           //actors[22]
                new Actor() { Name = "Mark Rylance" },            //actors[23]
                new Actor() { Name = "Armie Hammer" },            //actors[24]
                new Actor() { Name = "Timothée Chalamet" },       //actors[25]
                new Actor() { Name = "Michael Stuhlbarg" },       //actors[26]
                new Actor() { Name = "Vicky Krieps" },            //actors[27]
                new Actor() { Name = "Daniel Day-Lewis" },        //actors[28]
                new Actor() { Name = "Lesley Manville" },         //actors[29]
                new Actor() { Name = "Meryl Streep" },            //actors[30]
                new Actor() { Name = "Tom Hanks" },               //actors[31]
                new Actor() { Name = "Sarah Paulson" },           //actors[32]
                new Actor() { Name = "Gary Oldman" },             //actors[33]
                new Actor() { Name = "Lily James" },              //actors[34]
                new Actor() { Name = "Kristin Scott Thomas" },    //actors[35]
                new Actor() { Name = "Mahershala Ali" },          //actors[36]
                new Actor() { Name = "Naomie Harris" },           //actors[37]
                new Actor() { Name = "Trevante Rhodes" },         //actors[38]
                new Actor() { Name = "Casey Affleck" },           //actors[39]
                new Actor() { Name = "Kyle Chandler" },           //actors[40]
                new Actor() { Name = "Ryan Gosling" },            //actors[41]
                new Actor() { Name = "Emma Stone" },              //actors[42]
                new Actor() { Name = "Rosemarie DeWitt" },        //actors[43]
                new Actor() { Name = "Dev Patel" },               //actors[44]
                new Actor() { Name = "Nicole Kidman" },           //actors[45]
                new Actor() { Name = "Rooney Mara" },             //actors[46]
                new Actor() { Name = "Amy Adams" },               //actors[47]
                new Actor() { Name = "Jeremy Renner" },           //actors[48]
                new Actor() { Name = "Forest Whitaker" },         //actors[49]
                new Actor() { Name = "Jacob Tremblay" },          //actors[50]
                new Actor() { Name = "Owen Wilson" },             //actors[51]
                new Actor() { Name = "Izabela Vidovic" }          //actors[52]
            };
            context.Actors.AddRange(actors);

            //Create movies
            Movie m1 = new Movie() { Title = "The Godfather", Duration = 117, ReleaseDate = new DateTime(1972, 03, 24), Description = "Widely regarded as one of the greatest films of all time, this mob drama, based on Mario Puzo's novel of the same name, focuses on the powerful Italian-American crime family of Don Vito Corleone (Marlon Brando). When the don's youngest son, Michael (Al Pacino), reluctantly joins the Mafia, he becomes involved in the inevitable cycle of violence and betrayal. Although Michael tries to maintain a normal relationship with his wife, Kay (Diane Keaton), he is drawn deeper into the family business.", ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2011/08/f623d26a6107a9cdbb2d805ed45675a6.jpg", Rate = 4.7f };
            m1.Categories = new List<Category>() { categories[0] };
            m1.Directors = new List<Director>() { directors[0] };
            m1.Actors = new List<Actor>() { actors[0], actors[1], actors[2] };
            context.Movies.Add(m1);

            Movie m2 = new Movie() { Title = "Fight Club", Duration = 139, ReleaseDate = new DateTime(1999, 10, 15), Description = "A nameless first person narrator (Edward Norton) attends support groups in attempt to subdue his emotional state and relieve his insomniac state. When he meets Marla (Helena Bonham Carter), another fake attendee of support groups, his life seems to become a little more bearable. However when he associates himself with Tyler (Brad Pitt) he is dragged into an underground fight club and soap making scheme. Together the two men spiral out of control and engage in competitive rivalry for love and power. When the narrator is exposed to the hidden agenda of Tyler's fight club, he must accept the awful truth that Tyler may not be who he says he is.", ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2011/06/f61a417411a0b4369a10d044bf669acc.jpg", Rate = 4.5f };
            m2.Categories = new List<Category>() { categories[0] };
            m2.Directors = new List<Director>() { directors[1] };
            m2.Actors = new List<Actor>() { actors[3], actors[4], actors[5] };
            context.Movies.Add(m2);
            
            Movie m3 = new Movie()
            {
                Title = "The Shape of Water",
                Duration = 123,
                ReleaseDate = new DateTime(2018, 02, 01),
                Description = "From master storyteller Guillermo del Toro comes THE SHAPE OF WATER, an otherworldly fable set against the backdrop of Cold War era America circa 1962. In the hidden high-security government laboratory where she works, lonely Elisa (Sally Hawkins) is trapped in a life of isolation. Elisa's life is changed forever when she and co-worker Zelda (Octavia Spencer) discover a secret classified experiment. Rounding out the cast are Michael Shannon, Richard Jenkins, Michael Stuhlbarg, and Doug Jones.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/10/THE-SHAPE-OF-WATER.jpg",
                Rate = 4.1f
            };
            m3.Categories = new List<Category>() { categories[0], categories[8] };
            m3.Directors = new List<Director>() { directors[2] };
            m3.Actors = new List<Actor>() { actors[6], actors[7], actors[8] };
            context.Movies.Add(m3);

            Movie m4 = new Movie()
            {
                Title = "Three Billboards Outside Ebbing",
                Duration = 115,
                ReleaseDate = new DateTime(2018, 02, 15),
                Description = "THREE BILLBOARDS OUTSIDE EBBING, MISSOURI is a darkly comic drama from Academy Award nominee Martin McDonagh (In Bruges). After months have passed without a culprit in her daughter's murder case, Mildred Hayes (Academy Award winner Frances McDormand) makes a bold move, painting three signs leading into her town with a controversial message directed at William Willoughby (Academy Award nominee Woody Harrelson), the town's revered chief of police. When his second-in-command Officer Dixon (Sam Rockwell), an immature mother's boy with a penchant for violence, gets involved, the battle between Mildred and Ebbing's law enforcement is only exacerbated.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/03/three_billboards_outside_ebbing_missouri.jpg",
                Rate = 4.2f
            };
            m4.Categories = new List<Category>() { categories[0], categories[4] };
            m4.Directors = new List<Director>() { directors[3] };
            m4.Actors = new List<Actor>() { actors[9], actors[10], actors[11] };
            context.Movies.Add(m4);

            Movie m5 = new Movie()
            {
                Title = "Lady Bird",
                Duration = 93,
                ReleaseDate = new DateTime(2018, 02, 15),
                Description = "Christine 'Lady Bird' MacPherson is a high school senior from the 'wrong side of the tracks.' She longs for adventure, sophistication, and opportunity, but finds none of that in her Sacramento Catholic high school. LADY BIRD follows the title character's senior year in high school, including her first romance, her participation in the school play, and most importantly, her applying for college.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2018/02/2019953.jpg",
                Rate = 4.0f
            };
            m5.Categories = new List<Category>() { categories[0], categories[8] };
            m5.Directors = new List<Director>() { directors[4] };
            m5.Actors = new List<Actor>() { actors[12], actors[13], actors[14] };
            context.Movies.Add(m5);

            Movie m6 = new Movie()
            {
                Title = "Get Out",
                Duration = 104,
                ReleaseDate = new DateTime(2017, 02, 24),
                Description = "Chris and his girlfriend Rose go upstate to visit her parents for the weekend. At first, Chris reads the family's overly accommodating behavior as nervous attempts to deal with their daughter's interracial relationship, but as the weekend progresses, a series of increasingly disturbing discoveries lead him to a truth that he never could have imagined.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/02/get_out_ver3.jpg",
                Rate = 4.1f
            };
            m6.Categories = new List<Category>() { categories[9], categories[10] };
            m6.Directors = new List<Director>() { directors[5] };
            m6.Actors = new List<Actor>() { actors[15], actors[16], actors[17] };
            context.Movies.Add(m6);

            Movie m7 = new Movie()
            {
                Title = "The Greatest Showman",
                Duration = 105,
                ReleaseDate = new DateTime(2017, 12, 25),
                Description = "Orphaned, penniless but ambitious and with a mind crammed with imagination and fresh ideas, the American Phineas Taylor Barnum will always be remembered as the man with the gift to effortlessly blur the line between reality and fiction. Thirsty for innovation and hungry for success, the son of a tailor will manage to open a wax museum but will soon shift focus to the unique and peculiar, introducing extraordinary, never-seen-before live acts on the circus stage. Some will call Barnum's wide collection of oddities, a freak show; however, when the obsessed for cheers and respectability showman gambles everything on the opera singer Jenny Lind to appeal to a high-brow audience, he will somehow lose sight of the most important aspect of his life: his family. Will Barnum risk it all to be accepted?",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/11/23519217_1402072619923533_4678360081776644191_n.jpg",
                Rate = 3.9f
            };
            m7.Categories = new List<Category>() { categories[0] };
            m7.Directors = new List<Director>() { directors[6] };
            m7.Actors = new List<Actor>() { actors[18], actors[19], actors[20] };
            context.Movies.Add(m7);

            Movie m8 = new Movie()
            {
                Title = "Dunkirk",
                Duration = 106,
                ReleaseDate = new DateTime(2017, 07, 21),
                Description = "Evacuation of Allied soldiers from the British Empire, and France, who were cut off and surrounded by the German army from the beaches and harbor of Dunkirk, France, between May 26- June 04, 1940, during Battle of France in World War II.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2016/12/dunkirk.jpg",
                Rate = 3.9f
            };
            m8.Categories = new List<Category>() { categories[0], categories[1], categories[7] };
            m8.Directors = new List<Director>() { directors[7] };
            m8.Actors = new List<Actor>() { actors[21], actors[22], actors[23] };
            context.Movies.Add(m8);

            Movie m9 = new Movie()
            {
                Title = "Call Me By Your Name",
                Duration = 130,
                ReleaseDate = new DateTime(2018, 01, 19),
                Description = "CALL ME BY YOUR NAME, the new film by Luca Guadagnino, is a sensual and transcendent tale of first love, based on the acclaimed novel by André Aciman. It's the summer of 1983 in the north of Italy, and Elio Perlman (Timothée Chalamet), a precocious 17-year-old young man, spends his days in his family's 17th century villa transcribing and playing classical music, reading, and flirting with his friend Marzia (Esther Garrel). Elio enjoys a close relationship with his father (Michael Stuhlbarg), an eminent professor specializing in Greco-Roman culture, and his mother Annella (Amira Casar), a translator, who favor him with the fruits of high culture in a setting that overflows with natural delights. While Elio's sophistication and intellectual gifts suggest he is already a fully-fledged adult, there is much that yet remains innocent and unformed about him, particularly about matters of the heart. ",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/09/21557858_10155696483274813_3616001807481403409_n.jpg",
                Rate = 4.2f
            };
            m9.Categories = new List<Category>() { categories[0], categories[8] };
            m9.Directors = new List<Director>() { directors[8] };
            m9.Actors = new List<Actor>() { actors[24], actors[25], actors[26] };
            context.Movies.Add(m9);

            Movie m10 = new Movie()
            {
                Title = "Phantom Thread",
                Duration = 130,
                ReleaseDate = new DateTime(2018, 01, 19),
                Description = "Set in the glamour of 1950s post-war London, renowned dressmaker Reynolds Woodcock (Daniel Day-Lewis) and his sister Cyril (Lesley Manville) are at the center of British fashion, dressing royalty, movie stars, heiresses, socialites, debutants, and dames with the distinct style of The House of Woodcock. Women come and go through Woodcock's life, providing the confirmed bachelor with inspiration and companionship, until he comes across a young, strong-willed woman, Alma (Vicky Krieps), who soon becomes a fixture in his life as his muse and lover. Once controlled and planned, he finds his carefully tailored life disrupted by love.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/12/phantom_thread_ver2.jpg",
                Rate = 3.8f
            };
            m10.Categories = new List<Category>() { categories[0], categories[8] };
            m10.Directors = new List<Director>() { directors[9] };
            m10.Actors = new List<Actor>() { actors[27], actors[28], actors[29] };
            context.Movies.Add(m10);

            Movie m11 = new Movie()
            {
                Title = "The Post",
                Duration = 115,
                ReleaseDate = new DateTime(2018, 01, 12),
                Description = "When American military analyst, Daniel Ellsberg, realizes to his disgust the depths of the US government's deceptions about the futility of the Vietnam War, he takes action by copying top-secret documents that would become the Pentagon Papers. Later, Washington Post owner, Kay Graham, is still adjusting to taking over her late husband's business when editor Ben Bradlee discovers the New York Times has scooped them with an explosive expose on those papers. Determined to compete, Post reporters find Ellsberg himself and a complete copy of those papers. However, the Post's plans to publish their findings are put in jeopardy with a Federal restraining order that could get them all indicted for Contempt. Now, Kay Graham must decide whether to back down for the safety of her paper or publish and fight for the Freedom of the Press. In doing so, Graham and her staff join a fight that would have America's democratic ideals in the balance. ",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/11/3649186.jpg",
                Rate = 3.6f
            };
            m11.Categories = new List<Category>() { categories[0] };
            m11.Directors = new List<Director>() { directors[10] };
            m11.Actors = new List<Actor>() { actors[30], actors[31], actors[32] };
            context.Movies.Add(m11);

            Movie m12 = new Movie()
            {
                Title = "Darkest Hour",
                Duration = 125,
                ReleaseDate = new DateTime(2017, 12, 22),
                Description = "With Europe on the threshold of World War II as Hitler's armies rampage across the continent's once proud nations, the Prime Minister of the United Kingdom, Neville Chamberlain, is forced to resign, appointing Winston Churchill as his replacement. But even in his early days as the country's leader, Churchill is under pressure to commence peace negotiations with the German dictator or to fight head-on the seemingly invincible Nazi regime, whatever the cost. However difficult and dangerous his decision may be, Winston Churchill has no choice, but to shine in his darkest hour.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/09/image005.jpg",
                Rate = 3.6f
            };
            m12.Categories = new List<Category>() { categories[0] };
            m12.Directors = new List<Director>() { directors[11] };
            m12.Actors = new List<Actor>() { actors[33], actors[34], actors[35] };
            context.Movies.Add(m12);

            Movie m13 = new Movie()
            {
                Title = "Moonlight",
                Duration = 111,
                ReleaseDate = new DateTime(2017, 12, 22),
                Description = "Three time periods - young adolescence, mid-teen and young adult - in the life of black-American Chiron is presented. When a child, Chiron lives with his single, crack addict mother Paula in a crime ridden neighborhood in Miami. Chiron is a shy, withdrawn child largely due to his small size and being neglected by his mother, who is more concerned about getting her fixes and satisfying her carnal needs than taking care of him. Because of these issues, Chiron is bullied, the slurs hurled at him which he doesn't understand beyond knowing that they are meant to be hurtful. Besides his same aged Cuban-American friend Kevin, Chiron is given what little guidance he has in life from a neighborhood drug dealer named Juan, who can see that he is neglected, and Juan's caring girlfriend Teresa, whose home acts as a sanctuary away from the bullies and away from Paula's abuse. ",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/06/moonlight_ver2_xxlg.jpg",
                Rate = 4.1f
            };
            m13.Categories = new List<Category>() { categories[0] };
            m13.Directors = new List<Director>() { directors[12] };
            m13.Actors = new List<Actor>() { actors[36], actors[37], actors[38] };
            context.Movies.Add(m13);

            Movie m14 = new Movie()
            {
                Title = "Manchester by the Sea",
                Duration = 135,
                ReleaseDate = new DateTime(2016, 12, 16),
                Description = "Lee Chandler is a brooding, irritable loner who works as a handyman for a Boston apartment block. One damp winter day he gets a call summoning him to his hometown, north of the city. His brother's heart has given out suddenly, and he's been named guardian to his 16-year-old nephew. As if losing his only sibling and doubts about raising a teenager weren't enough, his return to the past re-opens an unspeakable tragedy. ",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/02/manchester-by-the-sea-poster.jpg",
                Rate = 3.8f
            };
            m14.Categories = new List<Category>() { categories[0] };
            m14.Directors = new List<Director>() { directors[13] };
            m14.Actors = new List<Actor>() { actors[39], actors[19], actors[40] };
            context.Movies.Add(m14);

            Movie m15 = new Movie()
            {
                Title = "La La Land",
                Duration = 128,
                ReleaseDate = new DateTime(2016, 12, 25),
                Description = "Aspiring actress serves lattes to movie stars in between auditions and jazz musician Sebastian scrapes by playing cocktail-party gigs in dingy bars. But as success mounts, they are faced with decisions that fray the fragile fabric of their love affair, and the dreams they worked so hard to maintain in each other threaten to rip them apart.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2016/08/097062.jpg",
                Rate = 4.2f
            };
            m15.Categories = new List<Category>() { categories[0], categories[4], categories[8] };
            m15.Directors = new List<Director>() { directors[14] };
            m15.Actors = new List<Actor>() { actors[41], actors[42], actors[43] };
            context.Movies.Add(m15);

            Movie m16 = new Movie()
            {
                Title = "Lion",
                Duration = 118,
                ReleaseDate = new DateTime(2017, 01, 06),
                Description = "In 1986, Saroo was a five-year-old child in India of a poor but happy rural family. On a trip with his brother, Saroo soon finds himself alone and trapped in a moving decommissioned passenger train that takes him to Calcutta, 1500 miles away from home. Now totally lost in an alien urban environment and too young to identify either himself or his home to the authorities, Saroo struggles to survive as a street child until he is sent to an orphanage. Soon, Saroo is selected to be adopted by the Brierley family in Tasmania, where he grows up in a loving, prosperous home. However, for all his material good fortune, Saroo finds himself plagued by his memories of his lost family in his adulthood and tries to search for them even as his guilt drives him to hide this quest from his adoptive parents and his girlfriend. Only when he has an epiphany does he realize not only the answers he needs, but also the steadfast love that he has always had with all his loved ones in both worlds.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/02/Sem_t%C3%ADtulo.jpg",
                Rate = 4.3f
            };
            m16.Categories = new List<Category>() { categories[0] };
            m16.Directors = new List<Director>() { directors[15] };
            m16.Actors = new List<Actor>() { actors[44], actors[45], actors[46] };
            context.Movies.Add(m16);

            Movie m17 = new Movie()
            {
                Title = "Arrival ",
                Duration = 116,
                ReleaseDate = new DateTime(2016, 11, 11),
                Description = "Linguistics professor Louise Banks leads an elite team of investigators when gigantic spaceships touchdown in 12 locations around the world. As nations teeter on the verge of global war, Banks and her crew must race against time to find a way to communicate with the extraterrestrial visitors. Hoping to unravel the mystery, she takes a chance that could threaten her life and quite possibly all of mankind.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2016/08/chegada_7.jpg",
                Rate = 4.2f
            };
            m17.Categories = new List<Category>() { categories[0], categories[6] };
            m17.Directors = new List<Director>() { directors[16] };
            m17.Actors = new List<Actor>() { actors[47], actors[48], actors[49] };
            context.Movies.Add(m17);

            Movie m18 = new Movie()
            {
                Title = "Wonder",
                Duration = 113,
                ReleaseDate = new DateTime(2017, 11, 17),
                Description = "Based on the New York Times bestseller, WONDER tells the incredibly inspiring and heartwarming story of August Pullman. Born with facial differences that, up until now, have prevented him from going to a mainstream school, Auggie becomes the most unlikely of heroes when he enters the local fifth grade. As his family, his new classmates, and the larger community all struggle to discover their compassion and acceptance, Auggie's extraordinary journey will unite them all and prove you can't blend in when you were born to stand out.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/10/wonder_ver11.jpg",
                Rate = 4.3f
            };
            m18.Categories = new List<Category>() { categories[0] };
            m18.Directors = new List<Director>() { directors[17] };
            m18.Actors = new List<Actor>() { actors[50], actors[51], actors[52] };
            context.Movies.Add(m18);

            Movie m19 = new Movie()
            {
                Title = "La La Land",
                Duration = 128,
                ReleaseDate = new DateTime(2016, 12, 25),
                Description = "Aspiring actress serves lattes to movie stars in between auditions and jazz musician Sebastian scrapes by playing cocktail-party gigs in dingy bars. But as success mounts, they are faced with decisions that fray the fragile fabric of their love affair, and the dreams they worked so hard to maintain in each other threaten to rip them apart.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2016/08/097062.jpg",
                Rate = 4.2f
            };
            m19.Categories = new List<Category>() { categories[0], categories[4], categories[8] };
            m19.Directors = new List<Director>() { directors[14] };
            m19.Actors = new List<Actor>() { actors[41], actors[42], actors[43] };
            context.Movies.Add(m19);

            Movie m20 = new Movie()
            {
                Title = "La La Land",
                Duration = 128,
                ReleaseDate = new DateTime(2016, 12, 25),
                Description = "Aspiring actress serves lattes to movie stars in between auditions and jazz musician Sebastian scrapes by playing cocktail-party gigs in dingy bars. But as success mounts, they are faced with decisions that fray the fragile fabric of their love affair, and the dreams they worked so hard to maintain in each other threaten to rip them apart.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2016/08/097062.jpg",
                Rate = 4.2f
            };
            m20.Categories = new List<Category>() { categories[0], categories[4], categories[8] };
            m20.Directors = new List<Director>() { directors[14] };
            m20.Actors = new List<Actor>() { actors[41], actors[42], actors[43] };
            context.Movies.Add(m20);

            Movie m21 = new Movie()
            {
                Title = "La La Land",
                Duration = 128,
                ReleaseDate = new DateTime(2016, 12, 25),
                Description = "Aspiring actress serves lattes to movie stars in between auditions and jazz musician Sebastian scrapes by playing cocktail-party gigs in dingy bars. But as success mounts, they are faced with decisions that fray the fragile fabric of their love affair, and the dreams they worked so hard to maintain in each other threaten to rip them apart.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2016/08/097062.jpg",
                Rate = 4.2f
            };
            m21.Categories = new List<Category>() { categories[0], categories[4], categories[8] };
            m21.Directors = new List<Director>() { directors[14] };
            m21.Actors = new List<Actor>() { actors[41], actors[42], actors[43] };
            context.Movies.Add(m21);

            Movie m22 = new Movie()
            {
                Title = "La La Land",
                Duration = 128,
                ReleaseDate = new DateTime(2016, 12, 25),
                Description = "Aspiring actress serves lattes to movie stars in between auditions and jazz musician Sebastian scrapes by playing cocktail-party gigs in dingy bars. But as success mounts, they are faced with decisions that fray the fragile fabric of their love affair, and the dreams they worked so hard to maintain in each other threaten to rip them apart.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2016/08/097062.jpg",
                Rate = 4.2f
            };
            m22.Categories = new List<Category>() { categories[0], categories[4], categories[8] };
            m22.Directors = new List<Director>() { directors[14] };
            m22.Actors = new List<Actor>() { actors[41], actors[42], actors[43] };
            context.Movies.Add(m22);

            Movie m23 = new Movie()
            {
                Title = "Three Billboards Outside Ebbing",
                Duration = 115,
                ReleaseDate = new DateTime(2018, 02, 15),
                Description = "THREE BILLBOARDS OUTSIDE EBBING, MISSOURI is a darkly comic drama from Academy Award nominee Martin McDonagh (In Bruges). After months have passed without a culprit in her daughter's murder case, Mildred Hayes (Academy Award winner Frances McDormand) makes a bold move, painting three signs leading into her town with a controversial message directed at William Willoughby (Academy Award nominee Woody Harrelson), the town's revered chief of police. When his second-in-command Officer Dixon (Sam Rockwell), an immature mother's boy with a penchant for violence, gets involved, the battle between Mildred and Ebbing's law enforcement is only exacerbated.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/03/three_billboards_outside_ebbing_missouri.jpg",
                Rate = 4.2f
            };
            m23.Categories = new List<Category>() { categories[0], categories[4] };
            m23.Directors = new List<Director>() { directors[3] };
            m23.Actors = new List<Actor>() { actors[9], actors[10], actors[11] };
            context.Movies.Add(m23);

            Movie m24 = new Movie()
            {
                Title = "Three Billboards Outside Ebbing",
                Duration = 115,
                ReleaseDate = new DateTime(2018, 02, 15),
                Description = "THREE BILLBOARDS OUTSIDE EBBING, MISSOURI is a darkly comic drama from Academy Award nominee Martin McDonagh (In Bruges). After months have passed without a culprit in her daughter's murder case, Mildred Hayes (Academy Award winner Frances McDormand) makes a bold move, painting three signs leading into her town with a controversial message directed at William Willoughby (Academy Award nominee Woody Harrelson), the town's revered chief of police. When his second-in-command Officer Dixon (Sam Rockwell), an immature mother's boy with a penchant for violence, gets involved, the battle between Mildred and Ebbing's law enforcement is only exacerbated.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/03/three_billboards_outside_ebbing_missouri.jpg",
                Rate = 4.2f
            };
            m24.Categories = new List<Category>() { categories[0], categories[4] };
            m24.Directors = new List<Director>() { directors[3] };
            m24.Actors = new List<Actor>() { actors[9], actors[10], actors[11] };
            context.Movies.Add(m24);

            Movie m25 = new Movie()
            {
                Title = "Three Billboards Outside Ebbing",
                Duration = 115,
                ReleaseDate = new DateTime(2018, 02, 15),
                Description = "THREE BILLBOARDS OUTSIDE EBBING, MISSOURI is a darkly comic drama from Academy Award nominee Martin McDonagh (In Bruges). After months have passed without a culprit in her daughter's murder case, Mildred Hayes (Academy Award winner Frances McDormand) makes a bold move, painting three signs leading into her town with a controversial message directed at William Willoughby (Academy Award nominee Woody Harrelson), the town's revered chief of police. When his second-in-command Officer Dixon (Sam Rockwell), an immature mother's boy with a penchant for violence, gets involved, the battle between Mildred and Ebbing's law enforcement is only exacerbated.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/03/three_billboards_outside_ebbing_missouri.jpg",
                Rate = 4.2f
            };
            m25.Categories = new List<Category>() { categories[0], categories[4] };
            m25.Directors = new List<Director>() { directors[3] };
            m25.Actors = new List<Actor>() { actors[9], actors[10], actors[11] };
            context.Movies.Add(m25);

            Movie m26 = new Movie()
            {
                Title = "Three Billboards Outside Ebbing",
                Duration = 115,
                ReleaseDate = new DateTime(2018, 02, 15),
                Description = "THREE BILLBOARDS OUTSIDE EBBING, MISSOURI is a darkly comic drama from Academy Award nominee Martin McDonagh (In Bruges). After months have passed without a culprit in her daughter's murder case, Mildred Hayes (Academy Award winner Frances McDormand) makes a bold move, painting three signs leading into her town with a controversial message directed at William Willoughby (Academy Award nominee Woody Harrelson), the town's revered chief of police. When his second-in-command Officer Dixon (Sam Rockwell), an immature mother's boy with a penchant for violence, gets involved, the battle between Mildred and Ebbing's law enforcement is only exacerbated.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/03/three_billboards_outside_ebbing_missouri.jpg",
                Rate = 4.2f
            };
            m26.Categories = new List<Category>() { categories[0], categories[4] };
            m26.Directors = new List<Director>() { directors[3] };
            m26.Actors = new List<Actor>() { actors[9], actors[10], actors[11] };
            context.Movies.Add(m26);

            Movie m27 = new Movie()
            {
                Title = "Lion",
                Duration = 118,
                ReleaseDate = new DateTime(2017, 01, 06),
                Description = "In 1986, Saroo was a five-year-old child in India of a poor but happy rural family. On a trip with his brother, Saroo soon finds himself alone and trapped in a moving decommissioned passenger train that takes him to Calcutta, 1500 miles away from home. Now totally lost in an alien urban environment and too young to identify either himself or his home to the authorities, Saroo struggles to survive as a street child until he is sent to an orphanage. Soon, Saroo is selected to be adopted by the Brierley family in Tasmania, where he grows up in a loving, prosperous home. However, for all his material good fortune, Saroo finds himself plagued by his memories of his lost family in his adulthood and tries to search for them even as his guilt drives him to hide this quest from his adoptive parents and his girlfriend. Only when he has an epiphany does he realize not only the answers he needs, but also the steadfast love that he has always had with all his loved ones in both worlds.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/02/Sem_t%C3%ADtulo.jpg",
                Rate = 4.3f
            };
            m27.Categories = new List<Category>() { categories[0] };
            m27.Directors = new List<Director>() { directors[15] };
            m27.Actors = new List<Actor>() { actors[44], actors[45], actors[46] };
            context.Movies.Add(m27);

            Movie m28 = new Movie()
            {
                Title = "Lion",
                Duration = 118,
                ReleaseDate = new DateTime(2017, 01, 06),
                Description = "In 1986, Saroo was a five-year-old child in India of a poor but happy rural family. On a trip with his brother, Saroo soon finds himself alone and trapped in a moving decommissioned passenger train that takes him to Calcutta, 1500 miles away from home. Now totally lost in an alien urban environment and too young to identify either himself or his home to the authorities, Saroo struggles to survive as a street child until he is sent to an orphanage. Soon, Saroo is selected to be adopted by the Brierley family in Tasmania, where he grows up in a loving, prosperous home. However, for all his material good fortune, Saroo finds himself plagued by his memories of his lost family in his adulthood and tries to search for them even as his guilt drives him to hide this quest from his adoptive parents and his girlfriend. Only when he has an epiphany does he realize not only the answers he needs, but also the steadfast love that he has always had with all his loved ones in both worlds.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/02/Sem_t%C3%ADtulo.jpg",
                Rate = 4.3f
            };
            m28.Categories = new List<Category>() { categories[0] };
            m28.Directors = new List<Director>() { directors[15] };
            m28.Actors = new List<Actor>() { actors[44], actors[45], actors[46] };
            context.Movies.Add(m28);


            Movie m29 = new Movie()
            {
                Title = "Lion",
                Duration = 118,
                ReleaseDate = new DateTime(2017, 01, 06),
                Description = "In 1986, Saroo was a five-year-old child in India of a poor but happy rural family. On a trip with his brother, Saroo soon finds himself alone and trapped in a moving decommissioned passenger train that takes him to Calcutta, 1500 miles away from home. Now totally lost in an alien urban environment and too young to identify either himself or his home to the authorities, Saroo struggles to survive as a street child until he is sent to an orphanage. Soon, Saroo is selected to be adopted by the Brierley family in Tasmania, where he grows up in a loving, prosperous home. However, for all his material good fortune, Saroo finds himself plagued by his memories of his lost family in his adulthood and tries to search for them even as his guilt drives him to hide this quest from his adoptive parents and his girlfriend. Only when he has an epiphany does he realize not only the answers he needs, but also the steadfast love that he has always had with all his loved ones in both worlds.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/02/Sem_t%C3%ADtulo.jpg",
                Rate = 4.3f
            };
            m29.Categories = new List<Category>() { categories[0] };
            m29.Directors = new List<Director>() { directors[15] };
            m29.Actors = new List<Actor>() { actors[44], actors[45], actors[46] };
            context.Movies.Add(m29);

            Movie m30 = new Movie()
            {
                Title = "Moonlight",
                Duration = 111,
                ReleaseDate = new DateTime(2017, 12, 22),
                Description = "Three time periods - young adolescence, mid-teen and young adult - in the life of black-American Chiron is presented. When a child, Chiron lives with his single, crack addict mother Paula in a crime ridden neighborhood in Miami. Chiron is a shy, withdrawn child largely due to his small size and being neglected by his mother, who is more concerned about getting her fixes and satisfying her carnal needs than taking care of him. Because of these issues, Chiron is bullied, the slurs hurled at him which he doesn't understand beyond knowing that they are meant to be hurtful. Besides his same aged Cuban-American friend Kevin, Chiron is given what little guidance he has in life from a neighborhood drug dealer named Juan, who can see that he is neglected, and Juan's caring girlfriend Teresa, whose home acts as a sanctuary away from the bullies and away from Paula's abuse. ",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/06/moonlight_ver2_xxlg.jpg",
                Rate = 4.1f
            };
            m30.Categories = new List<Category>() { categories[0] };
            m30.Directors = new List<Director>() { directors[12] };
            m30.Actors = new List<Actor>() { actors[36], actors[37], actors[38] };
            context.Movies.Add(m30);

            Movie m31 = new Movie()
            {
                Title = "Moonlight",
                Duration = 111,
                ReleaseDate = new DateTime(2017, 12, 22),
                Description = "Three time periods - young adolescence, mid-teen and young adult - in the life of black-American Chiron is presented. When a child, Chiron lives with his single, crack addict mother Paula in a crime ridden neighborhood in Miami. Chiron is a shy, withdrawn child largely due to his small size and being neglected by his mother, who is more concerned about getting her fixes and satisfying her carnal needs than taking care of him. Because of these issues, Chiron is bullied, the slurs hurled at him which he doesn't understand beyond knowing that they are meant to be hurtful. Besides his same aged Cuban-American friend Kevin, Chiron is given what little guidance he has in life from a neighborhood drug dealer named Juan, who can see that he is neglected, and Juan's caring girlfriend Teresa, whose home acts as a sanctuary away from the bullies and away from Paula's abuse. ",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/06/moonlight_ver2_xxlg.jpg",
                Rate = 4.1f
            };
            m31.Categories = new List<Category>() { categories[0] };
            m31.Directors = new List<Director>() { directors[12] };
            m31.Actors = new List<Actor>() { actors[36], actors[37], actors[38] };
            context.Movies.Add(m31);

            Movie m32 = new Movie()
            {
                Title = "Moonlight",
                Duration = 111,
                ReleaseDate = new DateTime(2017, 12, 22),
                Description = "Three time periods - young adolescence, mid-teen and young adult - in the life of black-American Chiron is presented. When a child, Chiron lives with his single, crack addict mother Paula in a crime ridden neighborhood in Miami. Chiron is a shy, withdrawn child largely due to his small size and being neglected by his mother, who is more concerned about getting her fixes and satisfying her carnal needs than taking care of him. Because of these issues, Chiron is bullied, the slurs hurled at him which he doesn't understand beyond knowing that they are meant to be hurtful. Besides his same aged Cuban-American friend Kevin, Chiron is given what little guidance he has in life from a neighborhood drug dealer named Juan, who can see that he is neglected, and Juan's caring girlfriend Teresa, whose home acts as a sanctuary away from the bullies and away from Paula's abuse. ",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/06/moonlight_ver2_xxlg.jpg",
                Rate = 4.1f
            };
            m32.Categories = new List<Category>() { categories[0] };
            m32.Directors = new List<Director>() { directors[12] };
            m32.Actors = new List<Actor>() { actors[36], actors[37], actors[38] };
            context.Movies.Add(m32);

            Movie m33 = new Movie()
            {
                Title = "Moonlight",
                Duration = 111,
                ReleaseDate = new DateTime(2017, 12, 22),
                Description = "Three time periods - young adolescence, mid-teen and young adult - in the life of black-American Chiron is presented. When a child, Chiron lives with his single, crack addict mother Paula in a crime ridden neighborhood in Miami. Chiron is a shy, withdrawn child largely due to his small size and being neglected by his mother, who is more concerned about getting her fixes and satisfying her carnal needs than taking care of him. Because of these issues, Chiron is bullied, the slurs hurled at him which he doesn't understand beyond knowing that they are meant to be hurtful. Besides his same aged Cuban-American friend Kevin, Chiron is given what little guidance he has in life from a neighborhood drug dealer named Juan, who can see that he is neglected, and Juan's caring girlfriend Teresa, whose home acts as a sanctuary away from the bullies and away from Paula's abuse. ",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/06/moonlight_ver2_xxlg.jpg",
                Rate = 4.1f
            };
            m33.Categories = new List<Category>() { categories[0] };
            m33.Directors = new List<Director>() { directors[12] };
            m33.Actors = new List<Actor>() { actors[36], actors[37], actors[38] };
            context.Movies.Add(m33);

            //create movie watched
            context.MoviesWatched.Add(new MovieWatched() { User = users[1], Movie = m1, Rate = 4.5f });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m1, Rate = 5f, Favorite = true });
            context.MoviesWatched.Add(new MovieWatched() { User = users[3], Movie = m1, Rate = 4f });
            context.MoviesWatched.Add(new MovieWatched() { User = users[3], Movie = m2, Rate = 4.5f });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m2, Rate = 5f });


            //create reviews
            context.Reviews.Add(new Review() { User= users[1], Movie = m1, Content= "This movie is strong, good script, great casting, excellent acting, and over the top directing. It is hard to fine a movie done this well, it is 29 years old and has aged well. Even if the viewer does not like mafia type of movies, he or she will watch the entire film, the audiences is glued to what will happen next as the film progresses. Its about, family, loyalty, greed, relationships, and real life. This is a great mix, and the artistic style make the film memorable.", Date= new DateTime(2018,02,20)  });
            context.Reviews.Add(new Review() { User = users[2], Movie = m1, Content = "Shorn of its gangster trappings, The Godfather is sprawling and soap-operatic in tone. The sprawl is appropriate to its origins as a novel by Mario Puzo, who also co-wrote the screenplay with Coppola. There is a large cast of characters--maybe too large, as it can be difficult to keep track of just who everyone is. Even after you've watched the film a couple times you may find scenes where mobsters seem to spontaneously appear and you catch yourself saying, 'Wait, who is that guy supposed to be again ? ' The soap opera angle can be a positive or negative depending on your tastes. I tend to not like soap-operatic stories, but of course Coppola put yummy gangster topping on this one to make it palatable for guys like me. At root, though, The Godfather is concerned with realistic depictions of a very dysfunctional family as they try to make it through life--including marriages, births, adultery, spats between family members, tiffs with others in their community, and so on. My theory is that the soap opera angle accounts for much of the film's appeal. For me, it (and the slight lack of focus from the sprawl) accounts for much of the reason that I barely gave the film a 10.", Date = new DateTime(2018, 02, 21) });
            context.Reviews.Add(new Review() { User = users[3], Movie = m1, Content = "I love this movie and all of the GF movies. I see something new every time I have seen it (countless, truly). The story of tragedy and (little) comedy that exists in this film is easily understood by people all over the world. This film has been called an American story however I have met others who have seen this movie in other languages and they seem to have the same love and appreciation for it that I do. I love the characters and all of the different personalities that they represent not just in families but in society itself. It seems like the entire cast is part of every other movie that I love as well. The sounds, music, color and light in the film are just as much a part of the film as the people. This could be attributed to the method in which it was filmed. At many parts of the film I can still find myself feeling the emotions conveyed in the film. I never tire of appreciating this film. I thank God that FFC is an American treasure. We are fortunate to have him.", Date = new DateTime(2018, 02, 20) });
            context.Reviews.Add(new Review() { User = users[0], Movie = m2, Content = "After watching this movie I was totally filled with enthusiasm. Fight Club is definitly Fincher's best movie even better than se7en. It's not only the story but the optics which fascinated me. When I had seen it for the second time I could see this movie with the knowledge of the conclusion which is really fascinating as you'll see Fight Club in a totally different perspective. Also great about Fight Club is its soundtrack performed by the Dust Brothers and especially the song 'Where is my mind' by the Pixies which really fit to the end of the movie. Unfortunately Fight Club didn't have much success in Germany but anyway the movie got best reviews of the German press. I also have to mention the brilliance of Ed Norton and Brad Pitt who plays best in roles in which he performs the villain. But it's quiet amazing what Edward Norton is able to do - he is just overwhelming. For that role he has to get the oscar.", Date = new DateTime(2018, 02, 20) });
            context.Reviews.Add(new Review() { User = users[0], Movie = m1, Content = "This must rank as the best film (along with part 2)of all time.An ensemble performance that has no weak spot. Particularly, John Cazale(Fredo) and Richard Castellano(Clemenza) give wonderfully understated performances.You just have to believe that Castellano WAS Clemenza, he brings a real touch to his role. John Cazale brings the troubled Fredo to life, and you can see the weak Fredo desperately trying to live up to the family reputation but knowing that he can never be what his father wants. The story of one man's reluctance to be drawn into the murky family business,and his gradual change through circumstance, paints a vivid picture of this violent period of US history.", Date = new DateTime(2017, 07, 24) });
            base.Seed(context);
        }
    }
}
