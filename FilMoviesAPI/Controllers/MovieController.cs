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
    public class MovieController : ApiController
    {
        public HttpResponseMessage Get(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, MovieBLL.Get(id));
            }
            catch (KeyNotFoundException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        public HttpResponseMessage Get()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, MovieBLL.GetAll());
            }
            catch (KeyNotFoundException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        [Route("api/movie/random")]
        public HttpResponseMessage GetRandom()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, MovieBLL.GetRandom());
            }
            catch (KeyNotFoundException)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        [Route("api/movie/random")]
        public HttpResponseMessage GetRandom([FromUri] int qty)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, MovieBLL.GetRandom(qty));
            }
            catch (KeyNotFoundException)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        [Route("api/movie/best/rate")]
        public HttpResponseMessage GetBestRated([FromUri] int page)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new
                {
                    movies = MovieBLL.GetBestRated(page),
                    page,
                    count = MovieBLL.howManyMovies()
                });
            }
            catch (KeyNotFoundException)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        [Route("api/movie/new")]
        public HttpResponseMessage GetNewMovies([FromUri] int page)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new
                {
                    movies = MovieBLL.GetNewMovies(page),
                    page,
                    count = MovieBLL.howManyMovies()
                });
            }
            catch (KeyNotFoundException)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        [Route("api/movie/category")]
        public HttpResponseMessage GetByCategory([FromUri] int categoryId, [FromUri] int page)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new {
                    movies = MovieBLL.GetByCategory(categoryId, page).Select(m => new {
                        m.MovieID,
                        m.Title,
                        m.ReleaseDate,
                        m.ImageUrl,
                        m.Rate
                    }),
                    page,
                    count = MovieBLL.CountMoviesByCategory(categoryId),
                    category = CategoryBLL.Get(categoryId).Name
                });
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        [Route("api/movie/query")]
        public HttpResponseMessage GetByQuery([FromUri] string query, [FromUri] int page)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new {
                    movies = MovieBLL.GetByQuery(query,page).Select(m => new {
                        m.MovieID,
                        m.Title,
                        m.ReleaseDate,
                        m.ImageUrl,
                        m.Rate
                    }),
                    page,
                    count = MovieBLL.CountMoviesByQuery(query),
                    query
                });
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        [Route("api/movie/user")]
        public HttpResponseMessage GetWatchedByUsername([FromUri] string username, [FromUri] int page)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new {
                    movies = MovieBLL.GetWatchedByUsername(username, page),
                    page,
                    count = MovieBLL.CountWatchedMoviesByUser(username),
                    username
                });
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        [Route("api/movie/favorite")]
        public HttpResponseMessage GetFavoriteByUser([FromUri] string username, [FromUri] int page)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new {
                    movies = MovieBLL.GetFavoriteByUser(username,page),
                    page,
                    count = MovieBLL.CountFavoriteMoviesByUser(username),
                    username
                });
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        [Route("api/movie/mostWatched")]
        public HttpResponseMessage GetMostWatchedMovies()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, MovieBLL.GetMostWatchedMovies());
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        [Route("api/movie/mostFavorite")]
        public HttpResponseMessage GetMostFavoriteMovies()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, MovieBLL.GetMostFavoriteMovies());
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }
    }
}
