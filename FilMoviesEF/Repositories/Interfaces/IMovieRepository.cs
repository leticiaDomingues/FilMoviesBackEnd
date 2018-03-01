using FilMoviesAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesAPI.Repositories.Interfaces
{
    public interface IMovieRepository : IRepository<Movie>
    {
        IEnumerable<Movie> GetMoviesByCategory(int CategoryId, int page);
        IEnumerable<Movie> GetNewMovies(int page);
        IEnumerable<Movie> GetBestMovies(int page);
        IEnumerable<Movie> GetRandomMovies();
        IEnumerable<Movie> GetMoviesByQuery(string query, int page);
        IEnumerable<Movie> GetWatchedMovies(User user);
        IEnumerable<Movie> GetFavoriteMovies(User user);
        int CountMovies();
    }
}
