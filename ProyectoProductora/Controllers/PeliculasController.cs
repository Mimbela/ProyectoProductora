using ProyectoProductora.Models;
using ProyectoProductora.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoProductora.Controllers
{
    public class PeliculasController : Controller
    {

        //Creamos el repositorio
        RepositoryPeliculas repo;
        public PeliculasController()
        {
            this.repo = new RepositoryPeliculas();
        }



        // GET: Index
        public ActionResult Index()
        {
            //en Index vamos a devolver doctores
            return View(this.repo.GetPeliculas());
            
        }

        //Hacemos una vista para crear películas
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        //Hacemos un post para CREAR
        public ActionResult Create(Peliculas p)
        {
            //vamos a incluir excepciones:
           
             if (p.Tipo.ToLower()=="serie" && p.Coste>100000)
            {
                throw new Exception("Una serie no puede superar los 100000 €");
            }
            else if (p.Tipo.ToLower()=="pelicula" && p.Capitulos>1)
            {
                throw new Exception("Una película no puede tener más de 1 capítulo");
            }
           


            this.repo.InsertarPelicula(p);
            return RedirectToAction("Index");
        }
    }
}