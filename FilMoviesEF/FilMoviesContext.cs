using FilMoviesAPI.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesAPI
{
    public class FilMoviesContext : DbContext
    {
        public FilMoviesContext() : base("name=FilMoviesDBConnectionString")
        {
            Database.SetInitializer(new FilMoviesDBInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /******* User configuration ********/
            modelBuilder.Entity<User>().HasKey<String>(s => s.Username);
            modelBuilder.Entity<User>().Property(p => p.Username).HasMaxLength(30);
            modelBuilder.Entity<User>().Property(p => p.Password).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<User>().Property(p => p.Name).HasMaxLength(50).IsRequired();


            /******* Movie configuration ********/
            modelBuilder.Entity<Movie>().Property(p => p.Title).HasMaxLength(30).IsRequired();
            modelBuilder.Entity<Movie>().Property(p => p.ReleaseDate).IsRequired();
            modelBuilder.Entity<Movie>().Property(p => p.Rate).IsOptional();
            modelBuilder.Entity<Movie>().Property(p => p.Description).IsRequired();
            modelBuilder.Entity<Movie>().Property(p => p.ImageUrl).HasMaxLength(500).IsRequired();

            /******* Category configuration ********/
            modelBuilder.Entity<Category>().Property(p => p.Name).HasMaxLength(30).IsRequired(); ;

            /******* Director configuration ********/
            modelBuilder.Entity<Director>().Property(p => p.Name).HasMaxLength(50).IsRequired(); ;

            /******* Actor configuration ********/
            modelBuilder.Entity<Actor>().Property(p => p.Name).HasMaxLength(50).IsRequired(); ;

            /******* Review configuration ********/
            modelBuilder.Entity<Review>().Property(p => p.Content).IsRequired();
            modelBuilder.Entity<Review>().Property(p => p.Date).IsRequired();

            /******* MovieWatched configuration ********/
            modelBuilder.Entity<MovieWatched>().ToTable("MoviesWatched");
            modelBuilder.Entity<MovieWatched>().HasKey(mw => new { mw.Username, mw.MovieID});


            /******* Relationships configuration ********/
            //User-Review (1..n)
            modelBuilder.Entity<User>()
                    .HasMany<Review>(u => u.Reviews)
                    .WithRequired(r => r.User)
                    .HasForeignKey<String>(r => r.Username);
            //Movie-Review (1..n)
            modelBuilder.Entity<Movie>()
                    .HasMany<Review>(m => m.Reviews)
                    .WithRequired(r => r.Movie)
                    .HasForeignKey<int>(r => r.MovieID);
            //Movie-Category(n..n)
            modelBuilder.Entity<Movie>()
               .HasMany<Category>(m => m.Categories)
               .WithMany(c => c.Movies)
               .Map(mc =>
               {
                   mc.MapLeftKey("MovieID");
                   mc.MapRightKey("CategoryID");
                   mc.ToTable("MovieCategory");
               });
            //Movie-Director(n..n)
            modelBuilder.Entity<Movie>()
               .HasMany<Director>(m => m.Directors)
               .WithMany(d => d.Movies)
               .Map(md =>
               {
                   md.MapLeftKey("MovieID");
                   md.MapRightKey("DirectorID");
                   md.ToTable("MovieDirector");
               });
            //Movie-Actor(n..n)
            modelBuilder.Entity<Movie>()
               .HasMany<Actor>(m => m.Actors)
               .WithMany(a => a.Movies)
               .Map(ma =>
               {
                   ma.MapLeftKey("MovieID");
                   ma.MapRightKey("ActorID");
                   ma.ToTable("MovieActor");
               });

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<MovieWatched> MoviesWatched { get; set; }
    }
}
