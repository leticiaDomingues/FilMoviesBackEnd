using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesAPI.Repositories.Interfaces
{
    public interface IUnityOfWork : IDisposable
    {
        IActorRepository Actors { get; }
        ICategoryRepository Categories { get; }
        IDirectorRepository Directors { get; }
        IMovieRepository Movies { get; }
        IMovieWatchedRepository MoviesWatched { get; }
        IReviewRepository Reviews { get; }
        IUserRepository Users { get; }
        int Complete();
    }
}
