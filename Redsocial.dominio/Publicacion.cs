using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Redsocial.dominio
{

    [Table("Publicacion")]
    public class Publicacion
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Usuario { get; set; }
        [Required]
        [MaxLength(200)]
        public string Descripcion { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int MeGusta { get; set; }
        public int MeDisgusta { get; set; }
        public int VecesCompartido { get; set; }
        public bool EsPrivada { get; set; }
    }
}
