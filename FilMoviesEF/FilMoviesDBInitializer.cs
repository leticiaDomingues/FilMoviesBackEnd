using FilMoviesAPI.Model;
using FilMoviesEF;
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
                new User() { Username = "let", Password =  Encryption.sha256("123"), Name = "Leticia Domingues" }, //users[0]
                new User() { Username = "maria", Password = Encryption.sha256("123"), Name = "Maria Rodrigues" }, //users[1]
                new User() { Username = "isa", Password = Encryption.sha256("123"), Name = "Isabela Sato" },      //users[2]
                new User() { Username = "alex", Password = Encryption.sha256("123"), Name = "Alexsander Baldin" } //users[3]
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
                new Director() { Name = "Stephen Chbosky" },      //directors[17]
                new Director() { Name = "Frank Darabont" },       //directors[18]
                new Director() { Name = "Quentin Tarantino" },    //directors[19]
                new Director() { Name = "Robert Zemeckis" },        //directors[20]
                new Director() { Name = "Tony Kaye" },        //directors[21]
                new Director() { Name = "Alfred Hitchcock" },        //directors[22]
                new Director() { Name = "Roman Polanski" },        //directors[23]
                new Director() { Name = "Martin Scorsese" },       //directors[24]
                new Director() { Name = "Damien Chazelle" },        //directors[25]
                new Director() { Name = "Sam Mendes" },        //directors[26]
                new Director() { Name = "Sam Mendes" }        //directors[27]
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
                new Actor() { Name = "Izabela Vidovic" },          //actors[52]
                new Actor() { Name = "Tim Robbins" },             //actors[53]
                new Actor() { Name = "Morgan Freeman" },          //actors[54]
                new Actor() { Name = "Bob Gunton" },              //actors[55]
                new Actor() { Name = "Liam Neeson" },             //actors[53]
                new Actor() { Name = "Ralph Fiennes" },           //actors[54]
                new Actor() { Name = "Ben Kingsley" },            //actors[55]
                new Actor() { Name = "Liam Neeson" },             //actors[56]
                new Actor() { Name = "Ralph Fiennes" },           //actors[57]
                new Actor() { Name = "Ben Kingsley" },            //actors[58]
                new Actor() { Name = "John Travolta" },           //actors[59]
                new Actor() { Name = "Uma Thurman" },             //actors[60]
                new Actor() { Name = "Samuel L. Jackson" },       //actors[61]
                new Actor() { Name = "Robin Wright" },            //actors[62]
                new Actor() { Name = "Gary Sinise" },             //actors[63]
                new Actor() { Name = "Leonardo DiCaprio" },       //actors[64]
                new Actor() { Name = "Joseph Gordon-Levitt" },    //actors[65]
                new Actor() { Name = "Ellen Page" },              //actors[66]
                new Actor() { Name = "Kevin Spacey" },            //actors[67]
                new Actor() { Name = "Matthew McConaughey" },     //actors[68]
                new Actor() { Name = "Anne Hathaway" },           //actors[69]
                new Actor() { Name = "Jessica Chastain" },        //actors[70]
                new Actor() { Name = "Edward Furlong" },             //actors[71]
                new Actor() { Name = "Beverly D'Angelo" },           //actors[72]
                new Actor() { Name = "Anthony Perkins" },             //actors[73]
                new Actor() { Name = "Janet Leigh" },             //actors[74]
                new Actor() { Name = "Vera Miles" },           //actors[75]
                new Actor() { Name = "James Stewart" },             //actors[76]
                new Actor() { Name = "Grace Kelly" },             //actors[77]
                new Actor() { Name = "Wendell Corey" },           //actors[78]
                new Actor() { Name = "Adrien Brody" },             //actors[79]
                new Actor() { Name = "Thomas Kretschmann" },             //actors[80]
                new Actor() { Name = "Frank Finlay" },           //actors[81]
                new Actor() { Name = "Matt Damon" },             //actors[82]
                new Actor() { Name = "Jack Nicholson" },             //actors[83]
                new Actor() { Name = "Miles Teller" },           //actors[84]
                new Actor() { Name = "J.K. Simmons" },             //actors[85]
                new Actor() { Name = "Melissa Benoist" },             //actors[86]
                new Actor() { Name = "Guy Pearce" },           //actors[87]
                new Actor() { Name = "Carrie-Anne Moss" },             //actors[88]
                new Actor() { Name = "Joe Pantoliano" },             //actors[89]
                new Actor() { Name = "Christian Bale" },           //actors[90]
                new Actor() { Name = "Scarlett Johansson" },             //actors[91]
                new Actor() { Name = "Shelley Duvall" },             //actors[92]
                new Actor() { Name = "Danny Lloyd" },           //actors[93]
                new Actor() { Name = "Annette Bening" },             //actors[94]
                new Actor() { Name = "Thora Birch" }             //actors[95]
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
                Title = "The Shawshank Redemption",
                Duration = 142,
                ReleaseDate = new DateTime(1995, 03, 17),
                Description = "Chronicles the experiences of a formerly successful banker as a prisoner in the gloomy jailhouse of Shawshank after being found guilty of a crime he did not commit. The film portrays the man's unique way of dealing with his new, torturous life; along the way he befriends a number of fellow prisoners, most notably a wise long-term inmate named Red.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2011/06/eb836f6c8e5eeb9242621a42227b21b3.jpg",
                Rate = 4.6f
            };
            m19.Categories = new List<Category>() { categories[0] };
            m19.Directors = new List<Director>() { directors[18] };
            m19.Actors = new List<Actor>() { actors[53], actors[54], actors[55] };
            context.Movies.Add(m19);

            Movie m20 = new Movie()
            {
                Title = "Schindler's List",
                Duration = 195,
                ReleaseDate = new DateTime(1993, 11, 13),
                Description = "Oskar Schindler is a vainglorious and greedy German businessman who becomes an unlikely humanitarian amid the barbaric German Nazi reign when he feels compelled to turn his factory into a refuge for Jews. Based on the true story of Oskar Schindler who managed to save about 1100 Jews from being gassed at the Auschwitz concentration camp, it is a testament to the good in all of us.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2011/10/7051400748567488a5f0e28b02a0ff5c.jpg",
                Rate = 4.6f
            };
            m20.Categories = new List<Category>() { categories[0] };
            m20.Directors = new List<Director>() { directors[10] };
            m20.Actors = new List<Actor>() { actors[56], actors[57], actors[58] };
            context.Movies.Add(m20);

            Movie m21 = new Movie()
            {
                Title = "Pulp Fiction",
                Duration = 154,
                ReleaseDate = new DateTime(1994, 12, 14),
                Description = "Jules Winnfield (Samuel L. Jackson) and Vincent Vega (John Travolta) are two hit men who are out to retrieve a suitcase stolen from their employer, mob boss Marsellus Wallace (Ving Rhames). Wallace has also asked Vincent to take his wife Mia (Uma Thurman) out a few days later when Wallace himself will be out of town. Butch Coolidge (Bruce Willis) is an aging boxer who is paid by Wallace to lose his fight. The lives of these seemingly unrelated people are woven together comprising of a series of funny, bizarre and uncalled-for incidents.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2011/08/cc1cac6d34dcc8b321b0f352c550262c.jpg",
                Rate = 4.5f
            };
            m21.Categories = new List<Category>() { categories[0] };
            m21.Directors = new List<Director>() { directors[19] };
            m21.Actors = new List<Actor>() { actors[59], actors[60], actors[61] };
            context.Movies.Add(m21);

            Movie m22 = new Movie()
            {
                Title = "Forrest Gump",
                Duration = 142,
                ReleaseDate = new DateTime(1994, 06, 23),
                Description = "Forrest Gump is a simple man with a low I.Q. but good intentions. He is running through childhood with his best and only friend Jenny. His 'mama' teaches him the ways of life and leaves him to choose his destiny. Forrest joins the army for service in Vietnam, finding new friends called Dan and Bubba, he wins medals, creates a famous shrimp fishing fleet, inspires people to jog, starts a ping-pong craze, creates the smiley, writes bumper stickers and songs, donates to people and meets the president several times.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2012/08/37c12d5ed409f8f9966234e3659f8785.jpg",
                Rate = 4.5f
            };
            m22.Categories = new List<Category>() { categories[0], categories[8] };
            m22.Directors = new List<Director>() { directors[20] };
            m22.Actors = new List<Actor>() { actors[31], actors[62], actors[63] };
            context.Movies.Add(m22);

            Movie m23 = new Movie()
            {
                Title = "Inception",
                Duration = 148,
                ReleaseDate = new DateTime(2010, 08, 06),
                Description = "Dom Cobb is a skilled thief, the absolute best in the dangerous art of extraction, stealing valuable secrets from deep within the subconscious during the dream state, when the mind is at its most vulnerable. Cobb's rare ability has made him a coveted player in this treacherous new world of corporate espionage, but it has also made him an international fugitive and cost him everything he has ever loved. ",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2011/06/7c49092a6e7223cebd5bd8dfd579b6e6.jpg",
                Rate = 4.4f
            };
            m23.Categories = new List<Category>() { categories[1], categories[3], categories[6] };
            m23.Directors = new List<Director>() { directors[7] };
            m23.Actors = new List<Actor>() { actors[64], actors[65], actors[66] };
            context.Movies.Add(m23);

            Movie m24 = new Movie()
            {
                Title = "Seven",
                Duration = 126,
                ReleaseDate = new DateTime(1995, 12, 15),
                Description = "A film about two homicide detectives' (Morgan Freeman and (Brad Pitt desperate hunt for a serial killer who justifies his crimes as absolution for the world's ignorance of the Seven Deadly Sins. The movie takes us from the tortured remains of one victim to the next as the sociopathic 'John Doe' (Kevin Spacey) sermonizes to Detectives Somerset and Mills -- one sin at a time. The sin of Gluttony comes first and the murderer's terrible capacity is graphically demonstrated in the dark and subdued tones characteristic of film noir.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2011/06/17bad8ab7431afe2d5fe32b8ebbfccc6.jpg",
                Rate = 4.3f
            };
            m24.Categories = new List<Category>() { categories[0] };
            m24.Directors = new List<Director>() { directors[1] };
            m24.Actors = new List<Actor>() { actors[3], actors[54], actors[67] };
            context.Movies.Add(m24);

            Movie m25 = new Movie()
            {
                Title = "Interstellar",
                Duration = 168,
                ReleaseDate = new DateTime(2014, 11, 06),
                Description = "Earth's future has been riddled by disasters, famines, and droughts. There is only one way to ensure mankind's survival: Interstellar travel. A newly discovered wormhole in the far reaches of our solar system allows a team of astronauts to go where no man has gone before, a planet that may have the right environment to sustain human life.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2014/09/interestelar_t27814_14.jpg",
                Rate = 4.3f
            };
            m25.Categories = new List<Category>() { categories[0], categories[3], categories[6] };
            m25.Directors = new List<Director>() { directors[7] };
            m25.Actors = new List<Actor>() { actors[68], actors[69], actors[70] };
            context.Movies.Add(m25);

            Movie m26 = new Movie()
            {
                Title = "American History X",
                Duration = 119,
                ReleaseDate = new DateTime(1998, 10, 30),
                Description = "Derek Vineyard is paroled after serving 3 years in prison for brutally killing two black men who tried to break into/steal his truck. Through his brother, Danny Vineyard's narration, we learn that before going to prison, Derek was a skinhead and the leader of a violent white supremacist gang that committed acts of racial crime throughout L.A. and his actions greatly influenced Danny.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2017/08/MPW-48008.jpg",
                Rate = 4.4f
            };
            m26.Categories = new List<Category>() { categories[0] };
            m26.Directors = new List<Director>() { directors[21] };
            m26.Actors = new List<Actor>() { actors[4], actors[71], actors[72] };
            context.Movies.Add(m26);

            Movie m27 = new Movie()
            {
                Title = "Psycho",
                Duration = 109,
                ReleaseDate = new DateTime(1960, 08, 25),
                Description = "Phoenix officeworker Marion Crane is fed up with the way life has treated her. She has to meet her lover Sam in lunch breaks and they cannot get married because Sam has to give most of his money away in alimony. One Friday Marion is trusted to bank $40,000 by her employer. Seeing the opportunity to take the money and start a new life, Marion leaves town and heads towards Sam's California store. Tired after the long drive and caught in a storm, she gets off the main highway and pulls into The Bates Motel.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2010/08/428e08aedd545846abd1a20271a163e3.jpg",
                Rate = 4.4f
            };
            m27.Categories = new List<Category>() { categories[9], categories[10] };
            m27.Directors = new List<Director>() { directors[22] };
            m27.Actors = new List<Actor>() { actors[73], actors[74], actors[75] };
            context.Movies.Add(m27);

            Movie m28 = new Movie()
            {
                Title = "Rear Window",
                Duration = 112,
                ReleaseDate = new DateTime(1954, 08, 25),
                Description = "Professional photographer L.B. 'Jeff' Jefferies breaks his leg while getting an action shot at an auto race. Confined to his New York apartment, he spends his time looking out of the rear window observing the neighbors. He begins to suspect that a man across the courtyard may have murdered his wife. Jeff enlists the help of his high society fashion-consultant girlfriend Lisa Freemont and his visiting nurse Stella to investigate.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2011/06/bee14bde4cbb7e1aa20d92c106d5f230.jpg",
                Rate = 4.3f
            };
            m28.Categories = new List<Category>() { categories[9] };
            m28.Directors = new List<Director>() { directors[22] };
            m28.Actors = new List<Actor>() { actors[76], actors[77], actors[78] };
            context.Movies.Add(m28);

            Movie m29 = new Movie()
            {
                Title = "The Pianist",
                Duration = 150,
                ReleaseDate = new DateTime(2002, 03, 07),
                Description = "In this adaptation of the autobiography 'The Pianist: The Extraordinary True Story of One Man's Survival in Warsaw, 1939-1945, Wladyslaw Szpilman, a Polish Jewish radio station pianist, sees Warsaw change gradually as World War II begins. Szpilman is forced into the Warsaw Ghetto, but is later separated from his family during Operation Reinhard. From this time until the concentration camp prisoners are released, Szpilman hides in various locations among the ruins of Warsaw.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2011/06/4c1987a96becd394e5394b06f09d8e0d_1.jpg",
                Rate = 4.3f
            };
            m29.Categories = new List<Category>() { categories[0] };
            m29.Directors = new List<Director>() { directors[23] };
            m29.Actors = new List<Actor>() { actors[79], actors[80], actors[81] };
            context.Movies.Add(m29);

            Movie m30 = new Movie()
            {
                Title = "The Departed",
                Duration = 151,
                ReleaseDate = new DateTime(2006, 11, 10),
                Description = "In South Boston, the state police force is waging war on Irish-American organized crime. Young undercover cop Billy Costigan is assigned to infiltrate the mob syndicate run by gangland chief Frank Costello. While Billy quickly gains Costello's confidence, Colin Sullivan, a hardened young criminal who has infiltrated the state police as an informer for the syndicate is rising to a position of power in the Special Investigation Unit.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2011/06/d8a4b6c4b558f32558a77102ce580338.jpg",
                Rate = 4.2f
            };
            m30.Categories = new List<Category>() { categories[0] };
            m30.Directors = new List<Director>() { directors[24] };
            m30.Actors = new List<Actor>() { actors[64], actors[82], actors[83] };
            context.Movies.Add(m30);

            Movie m31 = new Movie()
            {
                Title = "Whiplash",
                Duration = 106,
                ReleaseDate = new DateTime(2014, 01, 08),
                Description = "A young and talented drummer attending a prestigious music academy finds himself under the wing of the most respected professor at the school, one who does not hold back on abuse towards his students. The two form an odd relationship as the student wants to achieve greatness, and the professor pushes him.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2014/08/whiplash_t90046.jpg",
                Rate = 4.4f
            };
            m31.Categories = new List<Category>() { categories[0] };
            m31.Directors = new List<Director>() { directors[25] };
            m31.Actors = new List<Actor>() { actors[84], actors[85], actors[86] };
            context.Movies.Add(m31);

            Movie m32 = new Movie()
            {
                Title = "Memento",
                Duration = 113,
                ReleaseDate = new DateTime(2000, 08, 31),
                Description = "Memento chronicles two separate stories of Leonard, an ex-insurance investigator who can no longer build new memories, as he attempts to find the murderer of his wife, which is the last thing he remembers. One story line moves forward in time while the other tells the story backwards revealing more each time.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2011/09/1deef33fa858cc141e7a4f954f9c1fdd.jpg",
                Rate = 4.2f
            };
            m32.Categories = new List<Category>() { categories[9] };
            m32.Directors = new List<Director>() { directors[7] };
            m32.Actors = new List<Actor>() { actors[87], actors[88], actors[89] };
            context.Movies.Add(m32);

            Movie m33 = new Movie()
            {
                Title = "The Prestige",
                Duration = 130,
                ReleaseDate = new DateTime(2006, 11, 02),
                Description = "In the end of the Nineteenth Century, in London, Robert Angier, his beloved wife Julia McCullough and Alfred Borden are friends and assistants of a magician. When Julia accidentally dies during a performance, Robert blames Alfred for her death and they become enemies. Both become famous and rival magicians, sabotaging the performance of the other on the stage. ",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2011/06/183439621abd3d5d8dc791956715397b.jpg",
                Rate = 4.2f
            };
            m33.Categories = new List<Category>() { categories[0] };
            m33.Directors = new List<Director>() { directors[7] };
            m33.Actors = new List<Actor>() { actors[90], actors[18], actors[91] };
            context.Movies.Add(m33);

            Movie m34 = new Movie()
            {
                Title = "The Shining",
                Duration = 146,
                ReleaseDate = new DateTime(1980, 12, 25),
                Description = "Signing a contract, Jack Torrance, a normal writer and former teacher agrees to take care of a hotel which has a long, violent past that puts everyone in the hotel in a nervous situation. While Jack slowly gets more violent and angry of his life, his son, Danny, tries to use a special talent.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2010/12/5ecbe41ded5098d2dc80abdf835dfba0.jpg",
                Rate = 4.3f
            };
            m34.Categories = new List<Category>() { categories[0],categories[10] };
            m34.Directors = new List<Director>() { directors[26] };
            m34.Actors = new List<Actor>() { actors[83], actors[92], actors[93] };
            context.Movies.Add(m34);

            Movie m35 = new Movie()
            {
                Title = "American Beauty",
                Duration = 121,
                ReleaseDate = new DateTime(1999, 12, 02),
                Description = "After his death sometime in his forty-third year, suburbanite Lester Burnham tells of the last few weeks of his life, during which he had no idea of his imminent passing. He is a husband to real estate agent Carolyn Burnham and father to high school student Janie Burnham. Although Lester and Carolyn once loved each other, they now merely tolerate each other.",
                ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2011/07/a7a2b44a16026c798c23af225a2b74d4.jpg",
                Rate = 4.1f
            };
            m35.Categories = new List<Category>() { categories[0] };
            m35.Directors = new List<Director>() { directors[27] };
            m35.Actors = new List<Actor>() { actors[67], actors[94], actors[95] };
            context.Movies.Add(m35);

            

            //create movie watched
            context.MoviesWatched.Add(new MovieWatched() { User = users[1], Movie = m1, Rate = 4.5f, Date = new DateTime(2018, 03, 06) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m1, Rate = 5f, Favorite = true, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[3], Movie = m1, Rate = 4.4f, Date = new DateTime(2018, 03, 04) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[3], Movie = m2, Rate = 4.5f, Date = new DateTime(2018, 03, 03) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m2, Rate = 5f, Date = new DateTime(2018, 03, 02) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m4, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m6, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m30, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m25, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m23, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m21, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m19, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m17, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m15, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m13, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m11, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m9, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m8, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m7, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m16, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m33, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m32, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m28, Favorite = true, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m5, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[2], Movie = m22, Favorite = false, Date = new DateTime(2018, 03, 05) });

            //watched movies - let
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m16, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m17, Favorite = true, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m18, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m19, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m20, Favorite = true, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m21, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m22, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m23, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m24, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m25, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m26, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m27, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m28, Favorite = true, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m29, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m30, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m31, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m32, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m33, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m5, Favorite = false, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[0], Movie = m6, Favorite = false, Date = new DateTime(2018, 03, 05) });

            //watched movies - alex
            context.MoviesWatched.Add(new MovieWatched() { User = users[3], Movie = m20, Favorite = true, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[3], Movie = m18, Favorite = true, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[3], Movie = m33, Favorite = true, Date = new DateTime(2018, 03, 05) });
            context.MoviesWatched.Add(new MovieWatched() { User = users[3], Movie = m35, Favorite = true, Date = new DateTime(2018, 03, 05) });


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
