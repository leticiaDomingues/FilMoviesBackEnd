using FilMoviesAPI;
using FilMoviesAPI.Model;
using FilMoviesEF.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesEF.Repositories
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
    }
}
