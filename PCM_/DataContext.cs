using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PCM_
{
    internal class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = PCM_Reifenservice.db");
        }

        public DbSet<Kunde> Kunden { get; set; }
        public DbSet<Auto> Autos { get; set; }
    }
}
