using ProyectoProductora.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoProductora.Repositories
{
    public class RepositoryPeliculas
    {
        PeliculasContext context; //creamos un atributo context que será utilizado 
        //para llamarlo en las consultas.

        public RepositoryPeliculas()
        {
            this.context = new PeliculasContext();//instanciamos context de PeliculasContext
        }

        //hacemos las consultas:
        //método para ver todos los datos:
        public List<Peliculas> GetPeliculas()
        {
            return this.context.Peliculas.ToList();
        }

        //método para crear nuevos datos:
        public void InsertarPelicula(Peliculas p)
        {
            Peliculas peli = new Peliculas();
            peli.Capitulos = p.Capitulos;
            peli.Codigo = p.Codigo;
            peli.Coste = p.Coste;
            peli.Descripcion = p.Descripcion;
            peli.Nombre = p.Nombre;
            peli.Prota = p.Prota;
            peli.Tipo = p.Tipo;

            this.context.Peliculas.Add(peli);
            this.context.SaveChanges();
        }
    }
}