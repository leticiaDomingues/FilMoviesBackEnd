using FilMoviesAPI;
using FilMoviesEF.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesEF.Repositories
{
    public class UnitOfWork : IUnityOfWork
    {
        private readonly FilMoviesContext _context;

        public UnitOfWork(FilMoviesContext context)
        {
            _context = context;
            Actors = new ActorRepository(_context);
            Categories = new CategoryRepository(_context);
            Directors = new DirectorRepository(_context);
            Movies = new MovieRepository(_context);
            MoviesWatched = new MovieWatchedRepository(_context);
            Reviews = new ReviewRepository(_context);
            Users = new UserRepository(_context);
        }

        public IActorRepository Actors { get; private set; }
        public ICategoryRepository Categories { get; private set; }
        public IDirectorRepository Directors { get; private set; }
        public IMovieRepository Movies { get; private set; }
        public IMovieWatchedRepository MoviesWatched { get; private set; }
        public IReviewRepository Reviews { get; private set; }
        public IUserRepository Users { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
