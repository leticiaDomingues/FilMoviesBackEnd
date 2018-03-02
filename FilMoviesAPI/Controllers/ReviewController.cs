using FilMoviesAPI.Model;
using FilMoviesAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace FilMoviesAPI.Controllers
{
    public class ReviewController : ApiController
    {
        [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
        [Route("api/review/movie")]
        public HttpResponseMessage GetReviewsByMovie([FromUri] int MovieId, [FromUri] int page)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    IEnumerable<CompleteReview> reviews = unityOfWork.Reviews.GetReviewsByMovie(MovieId, page);
                    int howMany = unityOfWork.Reviews.countReviewsByMovie(MovieId);
                    var result = new
                    {
                        reviews,
                        page,
                        count = howMany
                    };
                    return Request.CreateResponse(HttpStatusCode.OK, result);
                }
                catch (KeyNotFoundException)
                {
                    var mensagem = string.Format("Erro");
                    var error = new HttpError(mensagem);
                    return Request.CreateResponse(HttpStatusCode.NotFound, error);
                }
            }
        }
    }
}
