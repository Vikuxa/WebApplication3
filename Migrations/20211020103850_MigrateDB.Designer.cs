// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication3.Models;

namespace WebApplication3.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211020103850_MigrateDB")]
    partial class MigrateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication3.Models.Material", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("firma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("WebApplication3.Models.Peremeshenie", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("data_demontazha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("data_ustanivki")
                        .HasColumnType("datetime2");

                    b.Property<int>("id_pomeshenie")
                        .HasColumnType("int");

                    b.Property<int>("id_sotrudnik")
                        .HasColumnType("int");

                    b.Property<int>("id_technika")
                        .HasColumnType("int");

                    b.Property<string>("prichina")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("id_pomeshenie");

                    b.HasIndex("id_sotrudnik");

                    b.HasIndex("id_technika");

                    b.ToTable("Peremeshenies");
                });

            modelBuilder.Entity("WebApplication3.Models.Pomeshenie", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("etazh")
                        .HasColumnType("int");

                    b.Property<string>("gorod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("kab_nom")
                        .HasColumnType("int");

                    b.Property<string>("ulitsa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("zdanie_nom")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Pomeshenies");
                });

            modelBuilder.Entity("WebApplication3.Models.Rashod_material", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Pomeshenieid")
                        .HasColumnType("int");

                    b.Property<DateTime>("data_demontazha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("data_ustanivki")
                        .HasColumnType("datetime2");

                    b.Property<int>("id_material")
                        .HasColumnType("int");

                    b.Property<int>("id_technika")
                        .HasColumnType("int");

                    b.Property<string>("prichina")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Pomeshenieid");

                    b.HasIndex("id_material");

                    b.HasIndex("id_technika");

                    b.ToTable("Rashod_Materials");
                });

            modelBuilder.Entity("WebApplication3.Models.Sotrudniki", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("dolzhnost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("f")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("i")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("o")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tel")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Sotrudnikis");
                });

            modelBuilder.Entity("WebApplication3.Models.Technika", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Technikaid")
                        .HasColumnType("int");

                    b.Property<string>("firma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("id_pomeshenie")
                        .HasColumnType("int");

                    b.Property<int>("id_sotrudnik")
                        .HasColumnType("int");

                    b.Property<string>("model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Technikaid");

                    b.HasIndex("id_pomeshenie");

                    b.HasIndex("id_sotrudnik");

                    b.ToTable("Technikas");
                });

            modelBuilder.Entity("WebApplication3.Models.Peremeshenie", b =>
                {
                    b.HasOne("WebApplication3.Models.Pomeshenie", "pomeshenie")
                        .WithMany()
                        .HasForeignKey("id_pomeshenie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication3.Models.Sotrudniki", "sotrudniki")
                        .WithMany("Peremeshenies")
                        .HasForeignKey("id_sotrudnik")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication3.Models.Technika", "technika")
                        .WithMany("Peremeshenies")
                        .HasForeignKey("id_technika")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pomeshenie");

                    b.Navigation("sotrudniki");

                    b.Navigation("technika");
                });

            modelBuilder.Entity("WebApplication3.Models.Rashod_material", b =>
                {
                    b.HasOne("WebApplication3.Models.Pomeshenie", null)
                        .WithMany("Rashod_Materials")
                        .HasForeignKey("Pomeshenieid");

                    b.HasOne("WebApplication3.Models.Material", "material")
                        .WithMany("Rashod_Materials")
                        .HasForeignKey("id_material")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication3.Models.Technika", "technika")
                        .WithMany()
                        .HasForeignKey("id_technika")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("material");

                    b.Navigation("technika");
                });

            modelBuilder.Entity("WebApplication3.Models.Technika", b =>
                {
                    b.HasOne("WebApplication3.Models.Technika", null)
                        .WithMany("Technikas")
                        .HasForeignKey("Technikaid");

                    b.HasOne("WebApplication3.Models.Pomeshenie", "pomeshenie")
                        .WithMany()
                        .HasForeignKey("id_pomeshenie")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication3.Models.Sotrudniki", "sotrudniki")
                        .WithMany("Technikas")
                        .HasForeignKey("id_sotrudnik")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pomeshenie");

                    b.Navigation("sotrudniki");
                });

            modelBuilder.Entity("WebApplication3.Models.Material", b =>
                {
                    b.Navigation("Rashod_Materials");
                });

            modelBuilder.Entity("WebApplication3.Models.Pomeshenie", b =>
                {
                    b.Navigation("Rashod_Materials");
                });

            modelBuilder.Entity("WebApplication3.Models.Sotrudniki", b =>
                {
                    b.Navigation("Peremeshenies");

                    b.Navigation("Technikas");
                });

            modelBuilder.Entity("WebApplication3.Models.Technika", b =>
                {
                    b.Navigation("Peremeshenies");

                    b.Navigation("Technikas");
                });
#pragma warning restore 612, 618
        }
    }
}
