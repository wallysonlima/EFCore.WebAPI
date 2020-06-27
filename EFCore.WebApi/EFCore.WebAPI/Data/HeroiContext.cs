using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Data
{
    public class HeroiContext : DbContext
    {
        public DbSet<Heroi> Heroi { get; set; }
        public DbSet<Batalha>  Batalha{ get; set; }
        public DbSet<Arma> Armas {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=sa123456;Persist Security Info");
        }
    }
}