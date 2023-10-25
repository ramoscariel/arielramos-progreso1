using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using arielramos_progreso1.Models;

namespace arielramos_progreso1.Data
{
    public class arielramos_progreso1Context : DbContext
    {
        public arielramos_progreso1Context (DbContextOptions<arielramos_progreso1Context> options)
            : base(options)
        {
        }

        public DbSet<arielramos_progreso1.Models.ArielRamos_Tabla> ArielRamos_Tabla { get; set; } = default!;
    }
}
