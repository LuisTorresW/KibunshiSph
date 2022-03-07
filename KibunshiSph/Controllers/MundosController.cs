using KibunshiSph.Models;
using KibunshiSph.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KibunshiSph.Controllers
{
    public class MundosController : Controller
    {
        private RepositorySuperheroes repo;
    
        public MundosController(RepositorySuperheroes repo)
        {
            this.repo = repo;
        }
        public IActionResult MundosId(int id)
        {
           Mundo mun = this.repo.GetMundoId(id);
            return View(mun);
        }

        public IActionResult MundoNombre()
        {
            List<string> mun = this.repo.GetMundoNombre();
            ViewData["Mundo"] = mun;
            
            return View();
        }

        [HttpPost]

        public IActionResult MundoNombre(string nombre)
        {
            Mundo mundo = this.repo.GetMundoNombreS(nombre);
            List<string> mun = this.repo.GetMundoNombre();
            ViewData["Mundo"] = mun;
            return View(mundo);
        }
    }
}
