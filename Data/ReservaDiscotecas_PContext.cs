using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ReservaDiscotecas_P.Models;

namespace ReservaDiscotecas_P.Data
{
    public class ReservaDiscotecas_PContext : DbContext
    {
        public ReservaDiscotecas_PContext (DbContextOptions<ReservaDiscotecas_PContext> options)
            : base(options)
        {
        }

        public DbSet<ReservaDiscotecas_P.Models.Reservas> Reservas { get; set; } = default!;
    }
}
