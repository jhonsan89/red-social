using Redsocial.dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace redsocial.api.Models
{
    public class PublicacionContext : DbContext
    {
        public PublicacionContext() : base("PublicacionConnection")
        {

        }

        public DbSet<Publicacion> Publicaciones { get; set; }
    }
}