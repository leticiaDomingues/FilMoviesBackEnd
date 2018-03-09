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
    public class MovieWatchedController : ApiController
    {
        public HttpResponseMessage Post([FromBody] MovieWatched mw)
        {
            try
            {
                MovieWatchedBLL.Create(mw);
                return Request.CreateResponse(HttpStatusCode.Created);
            } 
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        public HttpResponseMessage Get([FromUri] int MovieID, [FromUri] string username)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.Created, MovieWatchedBLL.GetMovieWatched(MovieID, username));
            }
            catch (KeyNotFoundException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        public HttpResponseMessage Delete([FromUri] int MovieID, [FromUri] string username)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, MovieWatchedBLL.Delete(MovieID, username));
            }
            catch (KeyNotFoundException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        public HttpResponseMessage Put([FromBody] MovieWatched mw)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    MovieWatchedBLL.Update(mw);
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                catch (KeyNotFoundException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }
            }
        }
    }
}
