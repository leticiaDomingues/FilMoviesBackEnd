using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using FilMoviesAPI.Model;
using FilMoviesAPI.Repositories;
using FilMoviesEF;

namespace FilMoviesAPI.Controllers
{
    public class UserController : ApiController
    {
        [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
        [Route("api/user/login")]
        public HttpResponseMessage Login([FromBody] User user)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    User loggedUser = unityOfWork.Users.Login(user);
                    bool correctCredentials = (loggedUser == null) ? false : true;
                    var result = new
                    {
                        user = loggedUser,
                        correctCredentials
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
        public HttpResponseMessage Post([FromBody] User user)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    bool usernameTaken = false;
                    User createdUser = null;

                    if (unityOfWork.Users.Get(user.Username) != null)
                        usernameTaken = true;
                    else
                    {
                        user.Password = Encryption.sha256(user.Password);
                        createdUser = unityOfWork.Users.Add(user);
                        unityOfWork.Complete();
                        createdUser.Password = null;
                    }

                    var msg = new
                    {
                        user = createdUser,
                        usernameTaken
                    };

                    return Request.CreateResponse(HttpStatusCode.Created, msg);
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
