using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MacrotisOriExam.Models
{
    public partial class AttractionContext : DbContext
    {
        public AttractionContext()
        {
        }

        public AttractionContext(DbContextOptions<AttractionContext> options) : base(options)
        {
        }

        public virtual DbSet<Attractions> Attractions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MacrotisOrientationExam;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attractions>(entity =>
            {
                entity.ToTable("attractions");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AttrName)
                    .HasColumnName("attr_name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Lattitude).HasColumnName("lattitude");

                entity.Property(e => e.Longitude).HasColumnName("longitude");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.RecommendedAge).HasColumnName("recommended_age");
            });
        }
    }
}
