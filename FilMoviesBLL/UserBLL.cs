using FilMoviesAPI;
using FilMoviesAPI.Model;
using FilMoviesAPI.Repositories;
using FilMoviesEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesBLL
{
    public class UserBLL
    {
        public User Login(User user)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                return unityOfWork.Users.Login(user);    
            }
        }

        public Boolean UsernameTaken(string username)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                if (unityOfWork.Users.Get(username) != null)
                    return true;

                return false;
            }
        }

        public User CreateUser(User user)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                user.Password = Encryption.sha256(user.Password);
                User createdUser = unityOfWork.Users.Add(user);
                unityOfWork.Complete();
                createdUser.Password = null;
                return createdUser;
            }
        }

        public static User GetUser(string username)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                User user = unityOfWork.Users.Get(username);
                user.Password = null;
                return user;
            }
        }

        public static int GetTotalWatchedTime(string username)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                return unityOfWork.Users.GetTotalWatchedMoviesDuration(username);
            }
        }

        public static int GetTotalWatched(string username)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                return unityOfWork.Users.GetTotalWatchedMovies(username);
            }
        }

        public static int GetTotalFavorite(string username)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                return unityOfWork.Users.GetTotalFavoriteMovies(username);
            }
        }

        public static int GetTotalRated(string username)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                return unityOfWork.Users.GetTotalRatedMovies(username);
            }
        }

        public static int GetTotalReviews(string username)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                return unityOfWork.Users.GetTotalReviewsMovies(username);
            }
        }
    }
}
