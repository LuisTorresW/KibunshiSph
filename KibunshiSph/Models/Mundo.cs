using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KibunshiSph.Models
{
    [Table("MUNDO")]
    public class Mundo
    {
        [Key]
        [Column("ID_MUNDO")]
        public int IdMundo { get; set; }

        [Column("NOMUNIVERSO")]

        public string NomUniverso { get; set; }

        [Column("PUNTUACION")]

        public double Puntuacion { get; set; }

        [Column("DESCRIPCION")]

        public string DescripcionMun { get; set; }

        [Column("IMAGEN")]

        public string Imagen { get; set; }
    }
}
