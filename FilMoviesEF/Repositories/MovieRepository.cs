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

        public IEnumerable<Movie> GetBestMovies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetFavoriteMovies(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetMoviesByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetNewMovies()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetRandomMovies()
        {
            return FilMoviesContext.Movies.ToList().OrderBy(_ => Guid.NewGuid());
        }

        public IEnumerable<Movie> GetWatchedMovies(User user)
        {
            throw new NotImplementedException();
        }
    }
}