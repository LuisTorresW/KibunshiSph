using KibunshiSph.Data;
using KibunshiSph.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KibunshiSph.Repositories
{
    public class RepositorySuperheroes
    {
        private SuperheroesContext context;

        public RepositorySuperheroes(SuperheroesContext context)
        {
            this.context = context;
        }

        public List<Superheroes> GetSuperheroes()
        {
            return this.context.Superheroes.ToList();
        }

        public int IdMaxSuperheroes()
        {
            return this.context.Superheroes.Max(z => z.IdSuperheroe) + 1;
        }

        public void InsertarPersonajes(string nom,string desc,int fuer,int defe,int espe,int vida,string pode,int ulti,int idmun,string ima)
        {
            Superheroes super = new Superheroes();
            super.IdSuperheroe = this.IdMaxSuperheroes();
            super.NombreSuperhero = nom;
            super.DescripcionSuperheroe = desc;
            super.FuerzaSuperheroe = fuer;
            super.DefensaSuperhero = defe;
            super.EspecialSuperheroe = espe;
            super.VidaSuperheroe = vida;
            super.PoderesSuperhero = pode;
            super.UltimateSuperheroe = ulti;
            super.MundoSuperheroe = idmun;
            super.ImagenSuperheroe = ima;

            this.context.Superheroes.Add(super);
            this.context.SaveChanges();
            
        }

       


        public Superheroes GetSuperheroesId(int id)
        {
            return this.context.Superheroes.FirstOrDefault(z => z.IdSuperheroe == id);
        }

        public void DeleteSuperheroe(int id)
        {
            
            this.context.Superheroes.Remove(this.GetSuperheroesId(id));
            this.context.SaveChanges();
        }

        public List<Superheroes> GetSuperheroesIdmundo(int idmundo)
        {
            var consulta = from datos in this.context.Superheroes
                           where datos.MundoSuperheroe == idmundo
                           select datos;
            return consulta.ToList();
        }


        public List<int> GetSuperheroesMundoId()
        {
            var consulta = (from datos in this.context.Superheroes
                            select datos.MundoSuperheroe).Distinct();
            return consulta.ToList();
        }

        #region MUNDO
        public List<Mundo> GetMundos()
        {
            return this.context.Mundos.ToList();
        }

        public Mundo GetMundoId(int id)
        {
           
            return this.context.Mundos.FirstOrDefault(z=>z.IdMundo==id);
        }

        public Mundo GetMundoNombreS(string nombre)
        {
            return this.context.Mundos.FirstOrDefault(z => z.NomUniverso == nombre);
        }

        public List<string> GetMundoNombre()
        {
            var consulta = (from datos in this.context.Mundos
                           
                           select datos.NomUniverso).Distinct();

            return consulta.ToList();
        }

        #endregion

        #region USUARIO


        public int MaxIdUsuario()
        {
            return this.context.Usuarios.Max(z => z.IdUsuario) + 1;
        }



        public void InsertarUsuario(string nom, string apellido,string correo,string contraseña, DateTime horaregistro)
        {

            Usuarios usu = new Usuarios();
            usu.IdUsuario = this.MaxIdUsuario();
            usu.Nombres = nom;
            usu.Apellidos = apellido;
            usu.Correo = correo;
            usu.Contrasena = contraseña;
            usu.FechaRegistro = horaregistro;
           
            this.context.Usuarios.Add(usu);
            this.context.SaveChanges();
            
        }

        #endregion

        #region BLOG
            
        public List<Blog> GetBlogs()
        {
            return this.context.Blog.ToList();
        }

        public int IdMaxIdBlog()
        {
            return this.context.Blog.Max(z => z.IdBlog) + 1;
        }

        public void InsertarBlog(string titulo, string nombre , string texto)
        {
            Blog blog = new Blog();
            blog.IdBlog = this.IdMaxIdBlog();
            blog.Titulo = titulo;
            blog.Nombre = nombre;
            blog.Texto = texto;

            this.context.Blog.Add(blog);
            this.context.SaveChanges();
        }


        #endregion


        #region Pelis
        public List<Pelis> GetPelis()
        {
            return this.context.Peliculas.ToList();
        }

        public List<Pelis> GetTitulo(string titulo)
        {
            var consulta = from datos in this.context.Peliculas
                           where datos.Titulo.Contains(titulo)
                           select datos;
            return consulta.ToList();
        }

        


        #endregion Pelis
    }
}
