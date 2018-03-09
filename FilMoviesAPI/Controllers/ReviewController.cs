using FilMoviesAPI.Model;
using FilMoviesAPI.Repositories;
using FilMoviesBLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace FilMoviesAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ReviewController : ApiController
    {
        [Route("api/review/movie")]
        public HttpResponseMessage GetReviewsByMovie([FromUri] int MovieId, [FromUri] int page)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    ReviewBLL reviewBLL = new ReviewBLL();
                    return Request.CreateResponse(HttpStatusCode.OK, new {
                        reviews = reviewBLL.GetReviewsByMovie(MovieId, page),
                        page,
                        count = reviewBLL.howManyReviewsByMovie
                    });
                }
                catch (Exception)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError);
                }
            }
        }

        public HttpResponseMessage Post([FromBody] Review r)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    ReviewBLL reviewBLL = new ReviewBLL();
                    reviewBLL.createReview(r);
                    return Request.CreateResponse(HttpStatusCode.Created);
                }
                catch (Exception)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError);
                }
            }               
        }


    }
}
