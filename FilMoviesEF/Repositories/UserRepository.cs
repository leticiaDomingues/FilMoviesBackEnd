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

        public User Login(User user)
        {
            try {
                var password = Encryption.sha256(user.Password);
                User userDB = FilMoviesContext.Users.Where(u => 
                    u.Username.Equals(user.Username) && 
                    u.Password.Equals(password)).First();
                userDB.Password = null;
                return userDB;
            } catch (Exception e)
            {
                return null;
            }
        }

        User IUserRepository.Add(User user)
        {
            return FilMoviesContext.Users.Add(user);
        }
    }
}
