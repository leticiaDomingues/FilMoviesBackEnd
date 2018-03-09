using FilMoviesAPI;
using FilMoviesAPI.Model;
using FilMoviesAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesBLL
{
    public class MovieBLL
    {
        public static Movie Get(int id)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
                return unityOfWork.Movies.Get(id);
        }

        public static IEnumerable<Movie> GetAll()
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
                return unityOfWork.Movies.GetAll();
        }

        public static IEnumerable<Movie> GetRandom()
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
                return unityOfWork.Movies.GetRandomMovies();
        }

        public static IEnumerable<Movie> GetRandom(int qty)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
                return unityOfWork.Movies.GetRandomMovies(qty);
        }

        public static int howManyMovies()
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
                return unityOfWork.Movies.CountMovies();
        }


        public static IEnumerable<Movie> GetBestRated(int page)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
                return unityOfWork.Movies.GetBestMovies(page);
        }

        public static IEnumerable<Movie> GetNewMovies(int page)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
                return unityOfWork.Movies.GetNewMovies(page);
        }

        public static IEnumerable<Movie> GetByCategory(int categoryId, int page)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
                return unityOfWork.Movies.GetMoviesByCategory(categoryId, page).Skip((page - 1) * 18).Take(18);
        }

        public static int CountMoviesByCategory(int categoryId)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
                return unityOfWork.Movies.GetMoviesByCategory(categoryId, 1).Count();
        }

        public static int CountMoviesByQuery(string query)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
                return unityOfWork.Movies.GetMoviesByQuery(query, 1).Count();
        }

        public static int CountWatchedMoviesByUser(string username)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
                return unityOfWork.Movies.GetWatchedMovies(username, 1).Count();
        }

        public static int CountFavoriteMoviesByUser(string username)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
                return unityOfWork.Movies.GetFavoriteMovies(username).Count();
        }

        public static IEnumerable<Movie> GetByQuery(string query, int page)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
                return unityOfWork.Movies.GetMoviesByQuery(query, page).Skip((page - 1) * 18).Take(18);
        }

        public static IEnumerable<MovieWatched> GetWatchedByUsername(string username, int page)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
                return unityOfWork.Movies.GetWatchedMovies(username, page).Skip((page - 1) * 18).Take(18);
        }

        public static IEnumerable<MovieWatched> GetFavoriteByUser(string username, int page)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
                return unityOfWork.Movies.GetFavoriteMovies(username).Skip((page - 1) * 18).Take(18);
        }

        public static IEnumerable<Movie> GetMostWatchedMovies()
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
                return unityOfWork.Movies.GetMostWatchedMovies();
        }

        public static IEnumerable<Movie> GetMostFavoriteMovies()
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
                return unityOfWork.Movies.GetMostFavoriteMovies();
        }
    }
}
