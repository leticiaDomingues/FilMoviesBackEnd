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
    public class MovieWatchedController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage Post([FromBody] MovieWatched mw)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                unityOfWork.MoviesWatched.Add(mw);
                unityOfWork.Complete();

                updateMovieRate(unityOfWork, mw.MovieID);

                return Request.CreateResponse(HttpStatusCode.Created);
            }
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage Get([FromUri] int MovieID, [FromUri] string username)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    MovieWatched mw = unityOfWork.MoviesWatched.Get(MovieID, username);
                    return Request.CreateResponse(HttpStatusCode.Created, mw);
                }
                catch (KeyNotFoundException)
                {
                    var mensagem = string.Format("Erro");
                    var error = new HttpError(mensagem);
                    return Request.CreateResponse(HttpStatusCode.NotFound, error);
                }
            }
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage Delete([FromUri] int MovieID, [FromUri] string username)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    MovieWatched mw = unityOfWork.MoviesWatched.Get(MovieID, username);
                    var response = unityOfWork.MoviesWatched.Remove(mw);
                    unityOfWork.Complete();
                    updateMovieRate(unityOfWork, mw.MovieID);

                    return Request.CreateResponse(HttpStatusCode.OK, response);
                }
                catch (KeyNotFoundException)
                {
                    var mensagem = string.Format("Erro");
                    var error = new HttpError(mensagem);
                    return Request.CreateResponse(HttpStatusCode.NotFound, error);
                }
            }  
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public HttpResponseMessage Put([FromBody] MovieWatched mw)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    var mwBD = unityOfWork.MoviesWatched.Get(mw.MovieID, mw.Username);
                    mwBD.Favorite = mw.Favorite;
                    mwBD.Rate = mw.Rate;
                    unityOfWork.Complete();

                    updateMovieRate(unityOfWork, mw.MovieID);

                    return Request.CreateResponse(HttpStatusCode.OK);
                }
                catch (KeyNotFoundException)
                {
                    var mensagem = string.Format("Erro");
                    var error = new HttpError(mensagem);
                    return Request.CreateResponse(HttpStatusCode.NotFound, error);
                }
            }
        }

        private void updateMovieRate(UnitOfWork unityOfWork, int MovieID)
        {
            float newRate = unityOfWork.Movies.CalculateMovieRate(MovieID);
            if (newRate != -1)
            {
                Movie m = unityOfWork.Movies.Get(MovieID);
                m.Rate = newRate;
                unityOfWork.Complete();
            }
        }
    }
}
