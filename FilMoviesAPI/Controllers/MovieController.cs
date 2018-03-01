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
    public class MovieController : ApiController
    {
        [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
        public HttpResponseMessage Get(int id)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    Movie movie = unityOfWork.Movies.Get(id);
                    return Request.CreateResponse(HttpStatusCode.OK, movie);
                }
                catch (KeyNotFoundException)
                {
                    var mensagem = string.Format("O filme {0} não foi encontrado.", id);
                    var error = new HttpError(mensagem);
                    return Request.CreateResponse(HttpStatusCode.NotFound, error);
                }
            }
        }

        [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
        public HttpResponseMessage Get()
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    ICollection<Movie> movies = (ICollection<Movie>) unityOfWork.Movies.GetAll();
                    return Request.CreateResponse(HttpStatusCode.OK, movies);
                }
                catch (KeyNotFoundException)
                {
                    var mensagem = string.Format("Erro");
                    var error = new HttpError(mensagem);
                    return Request.CreateResponse(HttpStatusCode.NotFound, error);
                }
            }
        }

        [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
        [Route("api/movie/random")]
        public HttpResponseMessage GetAll()
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    IEnumerable<Movie> movies = unityOfWork.Movies.GetRandomMovies();
                    return Request.CreateResponse(HttpStatusCode.OK, movies);
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
