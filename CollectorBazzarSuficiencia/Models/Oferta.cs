using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollectorSuficiencia.Entities
{
    public class Oferta
    {
        [Key]
        public int ID { get; set; }
      
        [Required]
        public int Puntuacion { get; set; }
        [Required]
        public double PrecioOfera { get; set; }
        [Required]
        public String Estado { get; set; }

        public int Calificacion { get; set; }

        //[Required]
        //public int UsuarioID { get; set; }
        [Required]
        public Usuario Usuario { get; set; }

    }
}
