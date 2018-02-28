using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FilMoviesAPI.Repositories;

namespace FilMoviesAPI.Controllers
{
    public class UserController : ApiController
    {
        public HttpResponseMessage Get(int id)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    var user = unityOfWork.Users.Get(id);
                    return Request.CreateResponse(HttpStatusCode.OK, user);
                }
                catch (KeyNotFoundException)
                {
                    var mensagem = string.Format("O usuario {0} não foi encontrado.", id);
                    var error = new HttpError(mensagem);
                    return Request.CreateResponse(HttpStatusCode.NotFound, error);
                }
            }
        }

        /*
        public HttpResponseMessage Post([FromBody] Cliente c)
        {
            var dao = new ClienteDAO();
            dao.Add(c);

            var response = Request.CreateResponse(HttpStatusCode.Created);
            var location = Url.Link("DefaultApi", new { controller = "cliente", nome = c.Nome });
            response.Headers.Location = new Uri(location);

            return response;
        }
        public HttpResponseMessage Delete([FromUri] string nome)
        {
            var dao = new ClienteDAO();
            var cliente = dao.getCliente(nome);
            ClienteDAO.clientes.Remove(cliente);

            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/cliente/{nome}/cpf")]
        public HttpResponseMessage Put([FromBody] Cliente cliente, [FromUri] string nome)
        {
            ClienteDAO.clientes.Where(c => c.Nome.Equals(nome)).FirstOrDefault().Cpf = cliente.Cpf;

            return Request.CreateResponse(HttpStatusCode.OK);
        }
        */
    }
}
