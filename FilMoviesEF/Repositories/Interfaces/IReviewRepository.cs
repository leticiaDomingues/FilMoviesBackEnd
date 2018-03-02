using FilMoviesAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilMoviesAPI.Repositories.Interfaces
{
    public interface IReviewRepository : IRepository<Review>
    {
        IEnumerable<CompleteReview> GetReviewsByMovie(int MovieID, int page);
        int countReviewsByMovie(int MovieID);
    }
}
