using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace WebApplication3
{
    public partial class WWWContext : DbContext
    {
        public WWWContext()
        {
        }

        public WWWContext(DbContextOptions<WWWContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Material> Materials { get; set; }
        public virtual DbSet<Peremesheny> Peremeshenies { get; set; }
        public virtual DbSet<Pomesheny> Pomeshenies { get; set; }
        public virtual DbSet<RashodMaterial> RashodMaterials { get; set; }
        public virtual DbSet<Sotrudniki> Sotrudnikis { get; set; }
        public virtual DbSet<Technika> Technikas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-VH8HKUU;Database=WWW;Trusted_Connection=True;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS");

            modelBuilder.Entity<Material>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Firma).HasColumnName("firma");

                entity.Property(e => e.Model).HasColumnName("model");

                entity.Property(e => e.Tip).HasColumnName("tip");
            });

            modelBuilder.Entity<Peremesheny>(entity =>
            {
                entity.HasIndex(e => e.Pomeshenieid, "IX_Peremeshenies_pomeshenieid");

                entity.HasIndex(e => e.Technikaid, "IX_Peremeshenies_technikaid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataDemontazha).HasColumnName("data_demontazha");

                entity.Property(e => e.DataUstanivki).HasColumnName("data_ustanivki");

                entity.Property(e => e.IdPomeshenie).HasColumnName("id_pomeshenie");

                entity.Property(e => e.IdTechnika).HasColumnName("id_technika");

                entity.Property(e => e.Pomeshenieid).HasColumnName("pomeshenieid");

                entity.Property(e => e.Prichina).HasColumnName("prichina");

                entity.Property(e => e.Technikaid).HasColumnName("technikaid");

                entity.HasOne(d => d.Pomeshenie)
                    .WithMany(p => p.Peremeshenies)
                    .HasForeignKey(d => d.Pomeshenieid);

                entity.HasOne(d => d.Technika)
                    .WithMany(p => p.Peremeshenies)
                    .HasForeignKey(d => d.Technikaid);
            });

            modelBuilder.Entity<Pomesheny>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Etazh).HasColumnName("etazh");

                entity.Property(e => e.Gorod).HasColumnName("gorod");

                entity.Property(e => e.KabNom).HasColumnName("kab_nom");

                entity.Property(e => e.Ulitsa).HasColumnName("ulitsa");

                entity.Property(e => e.ZdanieNom).HasColumnName("zdanie_nom");
            });

            modelBuilder.Entity<RashodMaterial>(entity =>
            {
                entity.ToTable("Rashod_Materials");

                entity.HasIndex(e => e.Materialid, "IX_Rashod_Materials_materialid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DataDemontazha).HasColumnName("data_demontazha");

                entity.Property(e => e.DataUstanivki).HasColumnName("data_ustanivki");

                entity.Property(e => e.IdMaterial).HasColumnName("id_material");

                entity.Property(e => e.Materialid).HasColumnName("materialid");

                entity.Property(e => e.Prichina).HasColumnName("prichina");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.RashodMaterials)
                    .HasForeignKey(d => d.Materialid);
            });

            modelBuilder.Entity<Sotrudniki>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dolzhnost).HasColumnName("dolzhnost");

                entity.Property(e => e.F).HasColumnName("f");

                entity.Property(e => e.I).HasColumnName("i");

                entity.Property(e => e.O).HasColumnName("o");

                entity.Property(e => e.Tel).HasColumnName("tel");
            });

            modelBuilder.Entity<Technika>(entity =>
            {
                entity.HasIndex(e => e.Pomeshenieid, "IX_Technikas_pomeshenieid");

                entity.HasIndex(e => e.Sotrudnikiid, "IX_Technikas_sotrudnikiid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Firma).HasColumnName("firma");

                entity.Property(e => e.IdPomeshenie).HasColumnName("id_pomeshenie");

                entity.Property(e => e.IdSotrudnik).HasColumnName("id_sotrudnik");

                entity.Property(e => e.Model).HasColumnName("model");

                entity.Property(e => e.Pomeshenieid).HasColumnName("pomeshenieid");

                entity.Property(e => e.Sotrudnikiid).HasColumnName("sotrudnikiid");

                entity.Property(e => e.Tip).HasColumnName("tip");

                entity.HasOne(d => d.Pomeshenie)
                    .WithMany(p => p.Technikas)
                    .HasForeignKey(d => d.Pomeshenieid);

                entity.HasOne(d => d.Sotrudniki)
                    .WithMany(p => p.Technikas)
                    .HasForeignKey(d => d.Sotrudnikiid);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
