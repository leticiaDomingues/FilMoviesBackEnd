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
    public class ReviewBLL
    {
        public int howManyReviewsByMovie { get; set; }

        public ICollection<CompleteReview> GetReviewsByMovie(int MovieId, int page)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                ICollection<CompleteReview> reviews = (ICollection<CompleteReview>) unityOfWork.Reviews.GetReviewsByMovie(MovieId, page);
                howManyReviewsByMovie = unityOfWork.Reviews.countReviewsByMovie(MovieId);

                return reviews;
            }
        }

        public void createReview(Review review)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                unityOfWork.Reviews.Add(review);
                unityOfWork.Complete();
            }
        }
    }
}
