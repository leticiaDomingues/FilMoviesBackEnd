using FilMoviesAPI.Model;
using FilMoviesAPI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FilMoviesAPI.Controllers
{
    public class CategoryController : ApiController
    {
        public HttpResponseMessage Get(int id)
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    Category category = unityOfWork.Categories.Get(id);
                    return Request.CreateResponse(HttpStatusCode.OK, category);
                }
                catch (KeyNotFoundException)
                {
                    var mensagem = string.Format("A categoria {0} não foi encontrado.", id);
                    var error = new HttpError(mensagem);
                    return Request.CreateResponse(HttpStatusCode.NotFound, error);
                }
            }
        }

        public HttpResponseMessage Get()
        {
            using (var unityOfWork = new UnitOfWork(new FilMoviesContext()))
            {
                try
                {
                    ICollection<Category> categories = (ICollection<Category>)unityOfWork.Categories.GetAll();
                    return Request.CreateResponse(HttpStatusCode.OK, categories);
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
