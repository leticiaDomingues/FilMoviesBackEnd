using FilMoviesAPI;
using FilMoviesAPI.Model;
using FilMoviesAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesAPI.Repositories
{
    public class ActorRepository : Repository<Actor>, IActorRepository
    {
        public ActorRepository(FilMoviesContext context) : base(context)
        {
        }

        public FilMoviesContext FilMoviesContext
        {
            get { return Context as FilMoviesContext; }
        }
    }
}
