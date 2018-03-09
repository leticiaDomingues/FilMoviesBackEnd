using FilMoviesAPI;
using FilMoviesAPI.Model;
using FilMoviesAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FilMoviesAPI.Repositories
{
    public class ReviewRepository : Repository<Review>, IReviewRepository
    {
        public ReviewRepository(FilMoviesContext context) : base(context)
        {
        }

        public FilMoviesContext FilMoviesContext
        {
            get { return Context as FilMoviesContext; }
        }

        public IEnumerable<CompleteReview> GetReviewsByMovie(int MovieID, int page)
        {
            IEnumerable<CompleteReview> reviews = FilMoviesContext.Reviews
                .Where(r => r.MovieID == MovieID).Select(r=> new CompleteReview
                {
                    Review = r,
                    Favorite = null,
                    Rate = null,
                    User = null
                })
                .OrderByDescending(r=> r.Review.Date)
                .Skip((page - 1) * 3).Take(3).ToList();

            foreach (CompleteReview review in reviews)
            {
                var movieWatched = FilMoviesContext.MoviesWatched.FirstOrDefault(
                    mw => mw.Username == review.Review.Username &&
                          mw.MovieID == review.Review.MovieID);
                review.User = FilMoviesContext.Users.Find(review.Review.Username);
                if (movieWatched != null)
                {
                    review.Rate = movieWatched.Rate;
                    review.Favorite = movieWatched.Favorite;
                }
            }

            return reviews;
        }

        public int countReviewsByMovie(int MovieID)
        {
            return FilMoviesContext.Reviews.Where(r => r.MovieID == MovieID).Count();
        }
    }
}


public class CompleteReview
{
    public Review Review { get; set; }
    public bool? Favorite { get; set; }
    public float? Rate { get; set; }
    public User User { get; set; }
}
