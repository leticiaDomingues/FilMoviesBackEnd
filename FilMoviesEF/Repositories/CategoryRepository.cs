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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        public CategoryRepository(FilMoviesContext context) : base(context)
        {
        }

        public FilMoviesContext FilMoviesContext
        {
            get { return Context as FilMoviesContext; }
        }
    }
}