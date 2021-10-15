using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class ApplicationContext : DbContext
    {
        //public DbSet<User> Users { get; set; }
        
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options) {        }
        

        public DbSet<Material> Materials { get; set; }
        public DbSet<Peremeshenie> Peremeshenies { get; set; }
        public DbSet<Pomeshenie> Pomeshenies { get; set; }
        public DbSet<Rashod_material> Rashod_Materials { get; set; }
        public DbSet<Sotrudniki> Sotrudnikis { get; set; }
        public DbSet<Technika> Technikas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
