using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollectorSuficiencia.Entities
{
    public class MetodoPago
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public String Nombre { get; set; }
        [Required]
        public String Descripcion { get; set; }
        //[Required]
       // public int UsuarioID { get; set; }
        [Required]
        public Usuario Usuario { get; set; }

    }
}
