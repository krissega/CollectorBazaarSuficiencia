using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollectorSuficiencia.Entities
{
    public class OrdenCompra
    {

        [Key]
        public int ID { get; set; }

        [Required]
        public Subasta IDSubasta { get; set; }

        [Required]
        public String Estado { get; set; }

        [Required]
        public double Total { get; set; }

        [Required]
        public DateTime FechaOrden { get; set; }




}
}
