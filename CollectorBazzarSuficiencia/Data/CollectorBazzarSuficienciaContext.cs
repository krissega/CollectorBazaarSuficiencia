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
    }
}
