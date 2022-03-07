using KibunshiSph.Models;
using KibunshiSph.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KibunshiSph.Controllers
{
    public class SuperheroesController : Controller
    {
        private RepositorySuperheroes repo;

        public SuperheroesController(RepositorySuperheroes repo)
        {
            this.repo = repo;
        }
        public IActionResult ListadoSuper()
        {
            List<Superheroes> super = this.repo.GetSuperheroes();
            return View(super);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Superheroes super)
        {
            this.repo.InsertarPersonajes(super.NombreSuperhero, super.DescripcionSuperheroe, super.FuerzaSuperheroe, super.DefensaSuperhero, super.EspecialSuperheroe, super.VidaSuperheroe, super.PoderesSuperhero, super.UltimateSuperheroe, super.MundoSuperheroe, super.ImagenSuperheroe);

            return RedirectToAction("ListadoSuper");
        }


        public IActionResult Delete(int ids)
        {
            this.repo.DeleteSuperheroe(ids);
            return RedirectToAction("ListadoSuper");
        }


        public IActionResult Details(int id)
        {
           Superheroes super =  this.repo.GetSuperheroesId(id);
            return View(super);
        }

        public IActionResult PersonajesMundo(int idmundo)
        {
            List<Superheroes> sup = this.repo.GetSuperheroesIdmundo(idmundo);
            return View(sup);
        }


        public IActionResult SuperheroesMundo()
        {
            List<int> mund = this.repo.GetSuperheroesMundoId();
            ViewData["MUNDO"] = mund;
            return View();

        }

        [HttpPost]


        public IActionResult SuperheroesMundo(int idmundo)
        {
            List<Superheroes> sup = this.repo.GetSuperheroesIdmundo(idmundo);
            List<int> mund = this.repo.GetSuperheroesMundoId();
            ViewData["MUNDO"] = mund;
            return View(sup);

        }


    }
}
