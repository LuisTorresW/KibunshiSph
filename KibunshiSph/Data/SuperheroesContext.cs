using KibunshiSph.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KibunshiSph.Data
{
    public class SuperheroesContext:DbContext
    {
        public SuperheroesContext(DbContextOptions<SuperheroesContext> options) : base(options) { }

        public DbSet<Superheroes> Superheroes { get; set; }
        public DbSet<Mundo> Mundos { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<Blog> Blog { get; set; }

        public DbSet<Pelis> Peliculas { get; set; }
    }
}
