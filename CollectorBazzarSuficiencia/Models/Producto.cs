using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollectorSuficiencia.Entities
{
    public class Producto
    {
        [Key]
       public  int ID { get; set; }
        
        [Required]
        public String Nombre { get; set; }
        [Required]
        public String Estado{ get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaCompra { get; set; }

        [Required]
        public String Antiguedad { get; set; }

        [Required]
        public Usuario Usuario { get; set; }

//        [Required]
       // public int IDUsuario { get; set; }
      
    }
}
