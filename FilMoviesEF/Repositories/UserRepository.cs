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
