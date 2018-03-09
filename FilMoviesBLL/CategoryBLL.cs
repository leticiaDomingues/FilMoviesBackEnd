using FilMoviesAPI;
using FilMoviesAPI.Model;
using FilMoviesAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesBLL
{
    public class CategoryBLL
    {
        public static Category Get(int id)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                return unityOfWork.Categories.Get(id);
            }
        }

        public static ICollection<Category> GetAll()
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                return (ICollection<Category>)unityOfWork.Categories.GetAll();
            }
        }

    }
}
