using FilMoviesAPI.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesAPI
{
    class FilMoviesDBInitializer : DropCreateDatabaseAlways<FilMoviesContext>
    {
        protected override void Seed(FilMoviesContext context)
        {
            //Create users
            User let = new User() { Username = "let", Password = "123", Name = "Leticia Domingues" };
            context.Users.Add(let);
            User maria = new User() { Username = "maria", Password = "123", Name = "Maria Rodrigues" };
            context.Users.Add(maria);
            User isa = new User() { Username = "isa", Password = "123", Name = "Isabela Sato" };
            context.Users.Add(isa);
            User alex = new User() { Username = "alex", Password = "123", Name = "Alexsander Baldin" };
            context.Users.Add(alex);

            //Create categories
            Category drama = new Category() { Name = "Drama" };
            context.Categories.Add(drama);
            context.Categories.Add(new Category() { Name = "Ação" });
            context.Categories.Add(new Category() { Name = "Animação" });
            context.Categories.Add(new Category() { Name = "Aventura" });
            context.Categories.Add(new Category() { Name = "Comédia" });
            context.Categories.Add(new Category() { Name = "Documentário" });
            context.Categories.Add(new Category() { Name = "Ficção Científica" });
            context.Categories.Add(new Category() { Name = "Guerra" });
            context.Categories.Add(new Category() { Name = "Romance" });
            context.Categories.Add(new Category() { Name = "Suspense" });
            context.Categories.Add(new Category() { Name = "Terror" });

            //Create directors
            Director davidFincher = new Director() { Name = "David Fincher" };
            Director coppola = new Director() { Name = "Francis Ford Coppola" };
            context.Directors.Add(davidFincher);
            context.Directors.Add(coppola);

            //Create actors
            Actor marlonBrando = new Actor() { Name = "Marlon Brando" };
            context.Actors.Add(marlonBrando);
            Actor alPacino = new Actor() { Name = "Al Pacino" };
            context.Actors.Add(alPacino);
            Actor jamesCaan = new Actor() { Name = "James Caan" };
            context.Actors.Add(jamesCaan);
            Actor bradPitt = new Actor() { Name = "Brad Pitt" };
            context.Actors.Add(bradPitt);
            Actor edwardNorton = new Actor() { Name = "Edward Norton" };
            context.Actors.Add(edwardNorton);
            Actor helenaBohamCarter = new Actor() { Name = "Helena Bonham Carter" };
            context.Actors.Add(helenaBohamCarter);

            //Create movies
            Movie m1 = new Movie() { Title = "The Godfather", Duration = 117, ReleaseDate = new DateTime(1972, 03, 24), Description = "Widely regarded as one of the greatest films of all time, this mob drama, based on Mario Puzo's novel of the same name, focuses on the powerful Italian-American crime family of Don Vito Corleone (Marlon Brando). When the don's youngest son, Michael (Al Pacino), reluctantly joins the Mafia, he becomes involved in the inevitable cycle of violence and betrayal. Although Michael tries to maintain a normal relationship with his wife, Kay (Diane Keaton), he is drawn deeper into the family business.", ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2011/08/f623d26a6107a9cdbb2d805ed45675a6.jpg", Rate = 4.7f };
            m1.Categories = new List<Category>() { drama };
            m1.Directors = new List<Director>() { coppola };
            m1.Actors = new List<Actor>() { marlonBrando, alPacino, jamesCaan };
            context.Movies.Add(m1);

            Movie m2 = new Movie() { Title = "Fight Club", Duration = 139, ReleaseDate = new DateTime(1999, 10, 15), Description = "A nameless first person narrator (Edward Norton) attends support groups in attempt to subdue his emotional state and relieve his insomniac state. When he meets Marla (Helena Bonham Carter), another fake attendee of support groups, his life seems to become a little more bearable. However when he associates himself with Tyler (Brad Pitt) he is dragged into an underground fight club and soap making scheme. Together the two men spiral out of control and engage in competitive rivalry for love and power. When the narrator is exposed to the hidden agenda of Tyler's fight club, he must accept the awful truth that Tyler may not be who he says he is.", ImageUrl = "https://cdn.fstatic.com/media/movies/covers/2011/06/f61a417411a0b4369a10d044bf669acc.jpg", Rate = 4.5f };
            m2.Categories = new List<Category>() { drama };
            m2.Directors = new List<Director>() { davidFincher };
            m2.Actors = new List<Actor>() { bradPitt, edwardNorton, helenaBohamCarter };
            context.Movies.Add(m2);


            //create movie watched
            context.MoviesWatched.Add(new MovieWatched() { User = maria, Movie = m1, Rate = 4.5f });
            context.MoviesWatched.Add(new MovieWatched() { User = isa, Movie = m1, Rate = 5f, Favorite = true });
            context.MoviesWatched.Add(new MovieWatched() { User = alex, Movie = m1, Rate = 4f });
            context.MoviesWatched.Add(new MovieWatched() { User = alex, Movie = m2, Rate = 4.5f });
            context.MoviesWatched.Add(new MovieWatched() { User = let, Movie = m2, Rate = 5f });


            //create reviews
            context.Reviews.Add(new Review() { User=maria, Movie = m1, Content= "This movie is strong, good script, great casting, excellent acting, and over the top directing. It is hard to fine a movie done this well, it is 29 years old and has aged well. Even if the viewer does not like mafia type of movies, he or she will watch the entire film, the audiences is glued to what will happen next as the film progresses. Its about, family, loyalty, greed, relationships, and real life. This is a great mix, and the artistic style make the film memorable.", Date= new DateTime(2018,02,20)  });
            context.Reviews.Add(new Review() { User = isa, Movie = m1, Content = "Shorn of its gangster trappings, The Godfather is sprawling and soap-operatic in tone. The sprawl is appropriate to its origins as a novel by Mario Puzo, who also co-wrote the screenplay with Coppola. There is a large cast of characters--maybe too large, as it can be difficult to keep track of just who everyone is. Even after you've watched the film a couple times you may find scenes where mobsters seem to spontaneously appear and you catch yourself saying, 'Wait, who is that guy supposed to be again ? ' The soap opera angle can be a positive or negative depending on your tastes. I tend to not like soap-operatic stories, but of course Coppola put yummy gangster topping on this one to make it palatable for guys like me. At root, though, The Godfather is concerned with realistic depictions of a very dysfunctional family as they try to make it through life--including marriages, births, adultery, spats between family members, tiffs with others in their community, and so on. My theory is that the soap opera angle accounts for much of the film's appeal. For me, it (and the slight lack of focus from the sprawl) accounts for much of the reason that I barely gave the film a 10.", Date = new DateTime(2018, 02, 21) });
            context.Reviews.Add(new Review() { User = alex, Movie = m1, Content = "I love this movie and all of the GF movies. I see something new every time I have seen it (countless, truly). The story of tragedy and (little) comedy that exists in this film is easily understood by people all over the world. This film has been called an American story however I have met others who have seen this movie in other languages and they seem to have the same love and appreciation for it that I do. I love the characters and all of the different personalities that they represent not just in families but in society itself. It seems like the entire cast is part of every other movie that I love as well. The sounds, music, color and light in the film are just as much a part of the film as the people. This could be attributed to the method in which it was filmed. At many parts of the film I can still find myself feeling the emotions conveyed in the film. I never tire of appreciating this film. I thank God that FFC is an American treasure. We are fortunate to have him.", Date = new DateTime(2018, 02, 20) });
            context.Reviews.Add(new Review() { User = let, Movie = m2, Content = "After watching this movie I was totally filled with enthusiasm. Fight Club is definitly Fincher's best movie even better than se7en. It's not only the story but the optics which fascinated me. When I had seen it for the second time I could see this movie with the knowledge of the conclusion which is really fascinating as you'll see Fight Club in a totally different perspective. Also great about Fight Club is its soundtrack performed by the Dust Brothers and especially the song 'Where is my mind' by the Pixies which really fit to the end of the movie. Unfortunately Fight Club didn't have much success in Germany but anyway the movie got best reviews of the German press. I also have to mention the brilliance of Ed Norton and Brad Pitt who plays best in roles in which he performs the villain. But it's quiet amazing what Edward Norton is able to do - he is just overwhelming. For that role he has to get the oscar.", Date = new DateTime(2018, 02, 20) });


            base.Seed(context);
        }
    }
}
