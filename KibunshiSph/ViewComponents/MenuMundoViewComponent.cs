using KibunshiSph.Models;
using KibunshiSph.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KibunshiSph.ViewComponents
{
    public class MenuMundoViewComponent:ViewComponent
    {
        RepositorySuperheroes repo;

        public MenuMundoViewComponent(RepositorySuperheroes repo)
        {
            this.repo = repo;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Mundo> mun = this.repo.GetMundos();
            return View(mun);
        }
    }
}
