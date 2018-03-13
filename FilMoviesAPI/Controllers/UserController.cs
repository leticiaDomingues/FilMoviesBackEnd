using FilMoviesAPI.Model;
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
    public class UserController : ApiController
    {
        [Route("api/user/login")]
        public HttpResponseMessage Login([FromBody] User user)
        {
            UserBLL userBLL = new UserBLL();
            User loggedUser = userBLL.Login(user);
            bool correctCredentials = (loggedUser == null) ? false : true;

            var result = new
            {
                user = loggedUser,
                correctCredentials
            };
            return Request.CreateResponse(HttpStatusCode.OK, result);
        }


        public HttpResponseMessage Get(string username)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, UserBLL.GetUser(username));
            }
            catch (KeyNotFoundException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }


        public HttpResponseMessage Post([FromBody] User user)
        {
            try
            {
                bool usernameTaken = true;
                User createdUser = null;

                UserBLL userBLL = new UserBLL();
                if (!userBLL.UsernameTaken(user.Username)) {
                    usernameTaken = false;
                    createdUser = userBLL.CreateUser(user);
                }

                return Request.CreateResponse(HttpStatusCode.Created, new {
                    user = createdUser,
                    usernameTaken
                });
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }

        [Route("api/user/totalWatched")]
        public HttpResponseMessage GetStats(string username)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, new
                {
                    totalTime = UserBLL.GetTotalWatchedTime(username),
                    totalWatched = UserBLL.GetTotalWatched(username),
                    totalFavorite = UserBLL.GetTotalFavorite(username),
                    totalRated = UserBLL.GetTotalRated(username),
                    totalReviews = UserBLL.GetTotalReviews(username)
                });
            }
            catch (KeyNotFoundException)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }
    }
}
