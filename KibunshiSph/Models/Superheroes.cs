using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KibunshiSph.Models
{
    [Table("SUPERHEROES")]
    public class Superheroes
    {
        [Key]
        [Column("ID_PERSONAJE")]
        public int IdSuperheroe { get; set; }
        [Column("NOMPERSONAJE")]
        public string NombreSuperhero { get; set; }
        [Column("DESCRIPCION")]
        public string DescripcionSuperheroe { get; set; }
        [Column("FUERZA")]
        public int FuerzaSuperheroe { get; set; }
        [Column("DEFENSA")]
        public int DefensaSuperhero { get; set; }
        [Column("ESPECIAL")]
        public int EspecialSuperheroe { get; set; }
        [Column("VIDA")]
        public int VidaSuperheroe { get; set; }
        [Column("PODERES")]
        public string PoderesSuperhero { get; set; }
        [Column("ULTIMATE")]
        public int UltimateSuperheroe { get; set; }
        [Column("ID_MUNDO")]
        public int MundoSuperheroe { get; set; }

        [Column("IMAGEN")]
        public string ImagenSuperheroe { get; set; }

    }
}
