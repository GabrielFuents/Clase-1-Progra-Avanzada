using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Practica2.Models;

namespace Practica2.Data
{
    public class Practica2Context : DbContext
    {
        public Practica2Context (DbContextOptions<Practica2Context> options)
            : base(options)
        {
        }

        public DbSet<Practica2.Models.Comida> Comida { get; set; }
    }
}
