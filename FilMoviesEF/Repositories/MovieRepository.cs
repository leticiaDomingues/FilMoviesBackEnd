using FilMoviesAPI;
using FilMoviesAPI.Model;
using FilMoviesAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesAPI.Repositories
{
    public class MovieRepository : Repository<Movie>, IMovieRepository
    {
        public MovieRepository(FilMoviesContext context) : base(context)
        {
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

        public IEnumerable<Movie> GetFavoriteMovies(User user)
        {
            /*  SELECT COUNT(mw.Favorite) as fav, mw.MovieID FROM Movies m
	            INNER JOIN MoviesWatched mw
		            ON m.MovieID = mw.MovieID
		            AND mw.Favorite IS NOT NULL
	            GROUP BY mw.MovieID
	            ORDER BY fav DESC*/


            throw new NotImplementedException();

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

        public IEnumerable<Movie> GetWatchedMovies(User user)
        {
            throw new NotImplementedException();
        }
    }
}