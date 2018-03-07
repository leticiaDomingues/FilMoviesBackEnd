using FilMoviesAPI;
using FilMoviesAPI.Model;
using FilMoviesAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Collections.ObjectModel;

namespace FilMoviesAPI.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(FilMoviesContext context) : base(context)
        {
        }

        public new Movie Get(int movieID) {
            return FilMoviesContext.Movies
                .Include(m => m.Categories)
                .Include(m => m.Actors)
                .Include(m => m.Directors)
                .FirstOrDefault(m=> m.MovieID == movieID);
        }

        public FilMoviesContext FilMoviesContext
        {
            get { return Context as FilMoviesContext; }
        }

        public int CountMovies()
        {
            return FilMoviesContext.Movies.Count();
        }

        public IEnumerable<Movie> GetBestMovies(int page)
        {
            return FilMoviesContext.Movies.OrderByDescending(m => m.Rate).Skip((page - 1) * 18).Take(18).ToList();
        }

        public IEnumerable<MovieWatched> GetFavoriteMovies(string username)
        {
            return FilMoviesContext.MoviesWatched
               .Include(mw => mw.Movie)
               .Where(mw => mw.Username == username && mw.Favorite == true)
               .OrderByDescending(mw => mw.Date)
               .ToList();
        }

        public IEnumerable<Movie> GetMoviesByCategory(int CategoryId, int page)
        {
            return FilMoviesContext.Categories.Include(c=>c.Movies).FirstOrDefault(c=> c.CategoryID == CategoryId).Movies.ToList();
        }

        public IEnumerable<Movie> GetMoviesByQuery(string query, int page)
        {
            query = query.ToUpper();
            return FilMoviesContext.Movies
                .Include(m => m.Categories)
                .Include(m => m.Actors)
                .Include(m => m.Directors)
                .Where(m => 
                    m.Title.ToUpper().Contains(query) ||
                    m.ReleaseDate.ToString().Contains(query) ||
                    m.Actors.Any(a => a.Name.ToUpper().Contains(query)) ||
                    m.Directors.Any(d => d.Name.ToUpper().Contains(query)) ||
                    m.Categories.Any(c => c.Name.ToUpper().Contains(query))
                ).ToList();
        }

        public IEnumerable<Movie> GetNewMovies(int page)
        {
            return FilMoviesContext.Movies.OrderByDescending(m => m.ReleaseDate).Skip((page - 1) * 18).Take(18).ToList();
        }

        public IEnumerable<Movie> GetRandomMovies()
        {
            return FilMoviesContext.Movies.Take<Movie>(32).ToList().OrderBy(_ => Guid.NewGuid());
        }

        public IEnumerable<MovieWatched> GetWatchedMovies(string username, int page)
        {
            return FilMoviesContext.MoviesWatched
                .Include(mw => mw.Movie)
                .Where(mw=>mw.Username == username)
                .OrderByDescending(mw=>mw.Date)
                .Take(6)
                .ToList();
        }

        public float CalculateMovieRate(int movieID)
        {
            try { 
                var updatedRate = FilMoviesContext.Database.SqlQuery<double>("DECLARE @return_value int,  @rate float " +
                                                    "EXEC @return_value = [dbo].[calculateRate] " +
                                                    "@movieId =  " + movieID + ", " +
                                                    "@rate = @rate OUTPUT " +
                                                    "SELECT  @rate as N'@rate' ").FirstOrDefault();

                return (float)updatedRate;
            } catch(Exception e)
            {
                return -1.0f;
            }
            
        }

        public IEnumerable<Movie> GetMostWatchedMovies()
        {
            try
            {
                var query = "SELECT COUNT(mw.MovieID) AS qts, mw.MovieID FROM movies m " +
                        "JOIN MoviesWatched mw " +
                        "ON mw.MovieID = m.MovieID " +
                        "GROUP BY mw.MovieID " +
                        "ORDER BY qts desc ";
                var aux = FilMoviesContext.Database.SqlQuery<AUXCLASS>(query).ToList().Take(6);

                ICollection<Movie> movies = new Collection<Movie>();
                foreach(AUXCLASS movieCount in aux)
                    movies.Add(FilMoviesContext.Movies.Where(m=>m.MovieID == movieCount.movieID).FirstOrDefault());

                return movies;

            }
            catch (Exception e)
            {
                return null;
            }

        }

        public IEnumerable<Movie> GetMostFavoriteMovies()
        {
            try
            {
                var query = "SELECT COUNT(mw.MovieID) AS qts, mw.MovieID FROM movies m " +
                        "JOIN MoviesWatched mw " +
                        "ON mw.MovieID = m.MovieID " +
                        "WHERE mw.Favorite=1" +
                        "GROUP BY mw.MovieID " +
                        "ORDER BY qts desc ";
                var aux = FilMoviesContext.Database.SqlQuery<AUXCLASS>(query).ToList().Take(6);

                ICollection<Movie> movies = new Collection<Movie>();
                foreach (AUXCLASS movieCount in aux)
                    movies.Add(FilMoviesContext.Movies.Where(m => m.MovieID == movieCount.movieID).FirstOrDefault());

                return movies;

            }
            catch (Exception e)
            {
                return null;
            }

        }

        private class AUXCLASS
        {
            public int qts { get; set; }
            public int movieID { get; set; }
        }
    }
}