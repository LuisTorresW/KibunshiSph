using KibunshiSph.Data;
using KibunshiSph.Models;
using KibunshiSph.Repositories;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KibunshiSph.Controllers
{
    public class PelisController : Controller
    {
        private RepositorySuperheroes repo;
     

        public PelisController(RepositorySuperheroes repo)
        {
            this.repo = repo;
            
        }


        public IActionResult BuscadorPelis()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BuscadorPelis(string titulos)
        {
            List<Pelis> peli = this.repo.GetTitulo(titulos);
          
            return View(peli);
        }






    }
}
