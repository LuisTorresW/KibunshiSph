using KibunshiSph.Models;
using KibunshiSph.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KibunshiSph.Controllers
{
    public class BlogController : Controller
    {
        private RepositorySuperheroes repo;

    public BlogController(RepositorySuperheroes repo)
        {
            this.repo = repo;
        }
        public IActionResult BlogVista()
        {
            List<Blog> blog = this.repo.GetBlogs();
            return View(blog);
        }

        public IActionResult Create(){

            return View();
        
        }

        [HttpPost]

        public IActionResult Create(Blog blog)
        {
            this.repo.InsertarBlog(blog.Titulo, blog.Nombre, blog.Texto);
            return RedirectToAction("BlogVista");
        }
    }
}
