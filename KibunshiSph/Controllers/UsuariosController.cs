using KibunshiSph.Models;
using KibunshiSph.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KibunshiSph.Controllers
{
    public class UsuariosController : Controller
    {
        private RepositorySuperheroes repo;

        public UsuariosController(RepositorySuperheroes repo)
        {
            this.repo = repo;
        }
        public IActionResult LogIn()
        {
            
            return View();
        }

        [HttpPost]

        public IActionResult LogIn(Usuarios usr)
        {
            this.repo.InsertarUsuario(usr.Nombres, usr.Apellidos, usr.Correo, usr.Contrasena, usr.FechaRegistro);
            return RedirectToAction("Index", "Home");
        }
    }
}
