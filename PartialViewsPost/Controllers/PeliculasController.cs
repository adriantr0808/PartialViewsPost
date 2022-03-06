using Microsoft.AspNetCore.Mvc;
using PartialViewsPost.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialViewsPost.Controllers
{
    public class PeliculasController : Controller
    {

        private List<Pelicula> peliculas;

        public PeliculasController()
        {
            this.peliculas = new List<Pelicula>
            {
                new Pelicula{ IdPelicula=1, Nombre="Alien",Genero="Ciencia ficcion"},
                 new Pelicula{ IdPelicula=2, Nombre="Avatar",Genero="Ciencia ficcion"},
                  new Pelicula{ IdPelicula=3, Nombre="Le Mans '66",Genero="Accion"},
            };
        }
        public IActionResult Index()
        {

            
            return View();
        }

        public IActionResult _PeliculasPartial()
        {
            return PartialView("_PeliculasPartial", this.peliculas);
        }
    }
}
