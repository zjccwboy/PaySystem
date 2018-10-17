using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Tester.PayWeb.Models
{
    public partial class TestPayDBContext : DbContext
    {
        public TestPayDBContext()
        {
        }

        public TestPayDBContext(DbContextOptions<TestPayDBContext> options)
            : base(options)
        {
        }

        public static string ConnectionString { get; set; }

        public virtual DbSet<Tuser> Tuser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tuser>(entity =>
            {
                entity.ToTable("TUser");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMail")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
