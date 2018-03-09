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
    public class MovieWatchedBLL
    {
        public static void Create(MovieWatched mw)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                unityOfWork.MoviesWatched.Add(mw);
                unityOfWork.Complete();

                updateMovieRate(unityOfWork, mw.MovieID);
            }
        }

        public static MovieWatched GetMovieWatched(int MovieID, string username)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                return unityOfWork.MoviesWatched.Get(MovieID, username);
            }
        }

        public static MovieWatched Delete(int MovieID, string username)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                MovieWatched mw = unityOfWork.MoviesWatched.Get(MovieID, username);
                var response = unityOfWork.MoviesWatched.Remove(mw);
                unityOfWork.Complete();
                updateMovieRate(unityOfWork, mw.MovieID);

                return response;
            }
        }

        public static void Update(MovieWatched mw)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                var mwBD = unityOfWork.MoviesWatched.Get(mw.MovieID, mw.Username);
                mwBD.Favorite = mw.Favorite;
                mwBD.Rate = mw.Rate;
                unityOfWork.Complete();

                updateMovieRate(unityOfWork, mw.MovieID);
            }
        }

        private static void updateMovieRate(UnitOfWork unityOfWork, int MovieID)
        {
            float newRate = unityOfWork.Movies.CalculateMovieRate(MovieID);
            if (newRate != -1)
            {
                Movie m = unityOfWork.Movies.Get(MovieID);
                m.Rate = newRate;
                unityOfWork.Complete();
            }
        }
    }
}
