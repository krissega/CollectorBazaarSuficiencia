using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollectorSuficiencia.Entities
{
    public class Subasta
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public List<Producto> ltsProductos { get; set; }
        [Required]
        public double PrecioBase { get; set; }
       
        [Required]
        public int Puntuacion { get; set; }
        [Required]
        public String Estado { get; set; }
        [Required]
        public DateTime Inicio { get; set; }
        [Required]
        public DateTime Finaliza { get; set; }

        //[Required]
        //public int UsuarioID { get; set; }
        [Required]
        public Usuario Usuario { get; set; }


    }
}
