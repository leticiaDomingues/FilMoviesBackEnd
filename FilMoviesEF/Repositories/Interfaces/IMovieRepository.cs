using FilMoviesAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesEF.Repositories.Interfaces
{
    public interface IMovieRepository : IRepository<Movie>
    {
        IEnumerable<Movie> GetMoviesByCategory(Category category);
        IEnumerable<Movie> GetNewMovies();
        IEnumerable<Movie> GetBestMovies();
        IEnumerable<Movie> GetRandomMovies();
        IEnumerable<Movie> GetWatchedMovies(User user);
        IEnumerable<Movie> GetFavoriteMovies(User user);
    }
}
