using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrnekProje.Models
{
    public class ProjeContext:DbContext
    {
        public ProjeContext(DbContextOptions<ProjeContext>options):base(options)
        {

        }
        public DbSet<AlinanUrun> alinanUruns { get; set; }
        public DbSet<Fatura> faturas { get; set; }
        public DbSet <Musteri> musteris { get; set; }

    }
}
