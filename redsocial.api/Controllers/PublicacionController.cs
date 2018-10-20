using redsocial.api.Models;
using Redsocial.dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace redsocial.api.Controllers
{
    public class PublicacionController : ApiController
    {
        [HttpGet]
        public IEnumerable<Publicacion> Get()
        {
            using (PublicacionContext context = new PublicacionContext())
            {
                return context.Publicaciones.ToList();
            }
        }
    }
}
