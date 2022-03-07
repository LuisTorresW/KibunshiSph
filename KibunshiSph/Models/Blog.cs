using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KibunshiSph.Models
{
    [Table("BLOG")]
    public class Blog
    {
        [Key]
        [Column("ID_BLOG")]
        public int IdBlog { get; set; }

        [Column("TITULO")]
        public string Titulo { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("TEXTO")]
        public string Texto { get; set; }


    }
}
