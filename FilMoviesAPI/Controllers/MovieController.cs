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
        public HttpResponseMessage GetRandom()
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

        [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
        [Route("api/movie/best/rate")]
        public HttpResponseMessage GetBestRated([FromUri] int page)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    IEnumerable<Movie> movies = unityOfWork.Movies.GetBestMovies(page);
                    int howMany = unityOfWork.Movies.CountMovies();
                    var result = new
                    {
                        movies,
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

        [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
        [Route("api/movie/new")]
        public HttpResponseMessage GetNewMovies([FromUri] int page)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    IEnumerable<Movie> movies = unityOfWork.Movies.GetNewMovies(page);
                    int howMany = unityOfWork.Movies.CountMovies();
                    var result = new
                    {
                        movies,
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


        [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
        [Route("api/movie/category")]
        public HttpResponseMessage GetByCategory([FromUri] int categoryId, [FromUri] int page)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    IEnumerable<Movie> movies = unityOfWork.Movies.GetMoviesByCategory(categoryId, page);
                    int howMany = movies.Count();
                    var c = unityOfWork.Categories.Get(categoryId);
                    var result = new
                    {
                        movies = movies.Skip((page - 1) * 18).Take(18).Select(m => new {
                            m.MovieID,
                            m.Title,
                            m.ReleaseDate,
                            m.ImageUrl,
                            m.Rate
                        }),
                        page,
                        count = howMany,
                        category = c.Name
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

        [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
        [Route("api/movie/query")]
        public HttpResponseMessage GetByQuery([FromUri] string query, [FromUri] int page)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    IEnumerable<Movie> movies = unityOfWork.Movies.GetMoviesByQuery(query, page);
                    int howMany = movies.Count();
                    var result = new
                    {
                        movies = movies.Skip((page - 1) * 18).Take(18).Select(m => new {
                            m.MovieID,
                            m.Title,
                            m.ReleaseDate,
                            m.ImageUrl,
                            m.Rate
                        }),
                        page,
                        count = howMany,
                        query
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

        [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
        [Route("api/movie/user")]
        public HttpResponseMessage GetWatchedByUsername([FromUri] string username, [FromUri] int page)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    ICollection<MovieWatched> movies = (ICollection<MovieWatched>)unityOfWork.Movies.GetWatchedMovies(username, page);
                    int howMany = movies.Count();
                    var result = new
                    {
                        movies = movies.Skip((page - 1) * 18).Take(18),
                        page,
                        count = howMany,
                        username
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

        [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
        [Route("api/movie/favorite")]
        public HttpResponseMessage GetFavoriteByUser([FromUri] string username, [FromUri] int page)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    ICollection<MovieWatched> movies = (ICollection<MovieWatched>)unityOfWork.Movies.GetFavoriteMovies(username);
                    int howMany = movies.Count();
                    var result = new
                    {
                        movies = movies.Skip((page - 1) * 18).Take(18),
                        page,
                        count = howMany,
                        username
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
