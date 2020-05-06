using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollectorSuficiencia.Entities
{
    public class Direccion
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public String Provincia { get; set; }
        [Required]
        public String Canton { get; set; }
        [Required]
        public String Distrito { get; set; }
        [Required]
        public String DireccionExacta { get; set; }

        [Required]
        //public int UsuarioID { get; set; }
       // [Required]
        public Usuario Usuario { get; set; }
    }
}
