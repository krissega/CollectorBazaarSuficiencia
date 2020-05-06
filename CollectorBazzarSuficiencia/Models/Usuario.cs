using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CollectorSuficiencia.Entities
{
    public class Usuario
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public String TipoUsuario { get; set; }

        [Required]
        public String Nombre { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        [Required]
        public List<Interes> LtsInteres { get; set; }

        [Required]
        public List<Direccion> LtsDirecciones { get; set; }


        [Required]
        public String Password { get; set; }

        [Required]
        public String Correo { get; set; }

        [Required]
        private int _edad;
        public int Edad
        {
            get
            {
                return this._edad;
            }
            set
            {
                TimeSpan TS = DateTime.Now - this.FechaNacimiento;
                double Years = TS.TotalDays / 365.25;  // 365 1/4 days per year
                _edad = Convert.ToInt32(Years);
            }
        }

        public int Puntuacion { get; set; }




    }
}
