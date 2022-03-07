using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KibunshiSph.Models
{
    [Table("USUARIO")]
    public class Usuarios
    {
        [Key]
        [Column("IdUsuarios")]
        public int IdUsuario { get; set; }
        [Column("Nombres")]
        public string Nombres { get;set;}

        [Column("Apellidos")]
        public string Apellidos  { get;set;}

        [Column("Correo")]
        public string Correo { get; set; }

        [Column("Contrasena")]
        public string Contrasena{ get; set; }

        [Column("FechaRegistro")]
        public DateTime FechaRegistro { get; set; }

    }
}
