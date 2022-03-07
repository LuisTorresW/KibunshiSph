using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KibunshiSph.Models
{
    [Table("PELIS")]
    public class Pelis
    {
        [Key]
        [Column("ID_PELI")]
        public int IdPeli { get; set; }

        [Column("TITULO")]
        public string Titulo { get; set; }

        [Column("DESCRIPCION")]
        public string Descripcion { get; set; }

        [Column("IMAGEN")]
        public string Imagen { get; set; }
    }
}
