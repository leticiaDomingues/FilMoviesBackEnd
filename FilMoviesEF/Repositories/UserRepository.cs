using FilMoviesAPI;
using FilMoviesAPI.Model;
using FilMoviesAPI.Repositories.Interfaces;
using FilMoviesEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesAPI.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(FilMoviesContext context) : base(context)
        {
        }

        public FilMoviesContext FilMoviesContext
        {
            get { return Context as FilMoviesContext; }
        }

        public User Get(string username)
        {
            return FilMoviesContext.Users.Where(u => u.Username.Equals(username)).FirstOrDefault();
        }

        public int GetTotalFavoriteMovies(string username)
        {
            return FilMoviesContext.MoviesWatched
                .Where(mw => mw.Username.Equals(username) && mw.Favorite==true)
                .ToList().Count();
        }

        public int GetTotalRatedMovies(string username)
        {
            return FilMoviesContext.MoviesWatched
                .Where(mw => mw.Username.Equals(username) && mw.Rate > 0)
                .ToList().Count();
        }

        public int GetTotalReviewsMovies(string username)
        {
            return FilMoviesContext.Reviews
                .Where(r => r.Username.Equals(username))
                .ToList().Count();
        }

        public int GetTotalWatchedMovies(string username)
        {
            return FilMoviesContext.MoviesWatched.Where(u => u.Username.Equals(username)).ToList().Count();
        }

        public int GetTotalWatchedMoviesDuration(string username)
        {
            try
            {
                var total = FilMoviesContext.Database.SqlQuery<int>("SELECT SUM(m.Duration) FROM MoviesWatched mw " +
                                                                    "JOIN Movies m " +
                                                                    "ON m.MovieID = mw.MovieID " +
                                                                    "WHERE username = '" + username + "' " +
                                                                    "GROUP BY mw.Username").FirstOrDefault();

                return (int)total;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        public User Login(User user)
        {
            var password = Encryption.sha256(user.Password);
            User userDB = FilMoviesContext.Users.Where(u => 
                u.Username.Equals(user.Username) && 
                u.Password.Equals(password)).FirstOrDefault();
            if(userDB != null )userDB.Password = null;
            return userDB;
        }

        User IUserRepository.Add(User user)
        {
            return FilMoviesContext.Users.Add(user);
        }
    }
}
