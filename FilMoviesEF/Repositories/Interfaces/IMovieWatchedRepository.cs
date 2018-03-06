using FilMoviesAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesAPI.Repositories.Interfaces
{
    public interface IMovieWatchedRepository : IRepository<MovieWatched>
    {
        MovieWatched Get(int MovieID, string username);
        MovieWatched Remove(MovieWatched movieWatched);
    }
}
