using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Clase02_MVC.Models;

namespace Clase02_MVC.Data
{
    public class Clase02_MVCContext : DbContext
    {
        public Clase02_MVCContext (DbContextOptions<Clase02_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Clase02_MVC.Models.Estudiante> Estudiante { get; set; } = default!;
        public DbSet<Clase02_MVC.Models.Carrera> Carrera { get; set; } = default!;
    }
}
