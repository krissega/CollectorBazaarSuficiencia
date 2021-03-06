﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollectorSuficiencia.Entities
{
    public class Interes
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public String Nombre { get; set; }
        [Required]
        public String Descipcion { get; set; }

        //[Required]
        //public int UsuarioID { get; set; }
        [Required]
        public Usuario Usuario { get; set; }

    }
}
