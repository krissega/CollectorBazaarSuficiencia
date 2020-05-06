using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CollectorSuficiencia.Entities;

namespace CollectorBazzarSuficiencia.Data
{
    public class CollectorBazzarSuficienciaContext : DbContext
    {
        public CollectorBazzarSuficienciaContext (DbContextOptions<CollectorBazzarSuficienciaContext> options)
            : base(options)
        {
        }

        public DbSet<CollectorSuficiencia.Entities.Usuario> Usuario { get; set; }

        public DbSet<CollectorSuficiencia.Entities.Producto> Producto { get; set; }

        public DbSet<CollectorSuficiencia.Entities.Direccion> Direccion { get; set; }

        public DbSet<CollectorSuficiencia.Entities.Interes> Interes { get; set; }

        public DbSet<CollectorSuficiencia.Entities.Oferta> Oferta { get; set; }

        public DbSet<CollectorSuficiencia.Entities.OrdenCompra> OrdenCompra { get; set; }

        public DbSet<CollectorSuficiencia.Entities.Subasta> Subasta { get; set; }

        public DbSet<CollectorSuficiencia.Entities.MetodoPago> MetodoPago { get; set; }
    }
}
