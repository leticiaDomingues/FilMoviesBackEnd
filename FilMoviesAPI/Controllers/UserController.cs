using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using FilMoviesAPI.Model;
using FilMoviesAPI.Repositories;

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
    }
}
