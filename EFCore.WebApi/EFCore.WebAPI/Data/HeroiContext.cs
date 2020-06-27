using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Data
{
    public class HeroiContext : DbContext
    {
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<Batalha>  Batalhas{ get; set; }
        public DbSet<Arma> Armas {get; set;}

        public DbSet<HeroiBatalha> HeroiBatalhas{get; set;}
        public DbSet<IdentidadeSecreta>IdentidadeSecretas{get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Password=sa123456;Persist Security Info");
        }

        public override void onModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HeroiBatalha>(entity => {
                entity.hasKey(e = new { e.BatalhaId, entity.HeroiId});
            });
        }


    }
}