using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoProductora.Models
{
    public class PeliculasContext : DbContext
    {
        public PeliculasContext() : base("name=cadenaconexion") { }
        
        //creamos el DbSet para películas:
        public DbSet<Peliculas> Peliculas { get; set; }

    }
}