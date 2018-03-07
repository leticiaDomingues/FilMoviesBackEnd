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
        new Movie Get(int movieID);
        IEnumerable<Movie> GetMoviesByCategory(int CategoryId, int page);
        IEnumerable<Movie> GetNewMovies(int page);
        IEnumerable<Movie> GetBestMovies(int page);
        IEnumerable<Movie> GetRandomMovies();
        IEnumerable<Movie> GetMoviesByQuery(string query, int page);
        IEnumerable<Movie> GetMostWatchedMovies();
        IEnumerable<MovieWatched> GetWatchedMovies(string username, int page);
        IEnumerable<MovieWatched> GetFavoriteMovies(string username);
        float CalculateMovieRate(int movieID);
        int CountMovies();
    }
}
