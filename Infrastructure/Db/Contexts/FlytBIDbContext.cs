using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Infrastructure.Db.Dtoes.Pg;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Infrastructure.Db.Contexts
{
    public partial class FlytBIDbContext : DbContext, IDataSynchronizationDbContxt
    {

        public FlytBIDbContext(DbContextOptions<FlytBIDbContext> options)
            : base(options)
        {
            
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=192.168.5.238;Port=5432;User ID=postgres;Password=postgres;Database=FlytBIDW;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CnName).HasMaxLength(255);

                entity.Property(e => e.CompanyId).HasColumnType("character varying");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.EnName).HasMaxLength(255);

                entity.Property(e => e.LastLoginIp).HasMaxLength(255);

                entity.Property(e => e.ParentId).HasMaxLength(255);

                entity.Property(e => e.Permissions).HasColumnType("json");

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.PositionId).HasMaxLength(255);

                entity.Property(e => e.QqNumber).HasMaxLength(255);

                entity.Property(e => e.Rid)
                    .HasColumnName("RId")
                    .HasMaxLength(255);

                entity.Property(e => e.Roleds).HasColumnType("json");

                entity.Property(e => e.Uid)
                    .HasColumnName("UId")
                    .HasMaxLength(255);

                entity.Property(e => e.Unumber)
                    .HasColumnName("UNumber")
                    .HasMaxLength(255);

                entity.Property(e => e.UserName).HasMaxLength(255);

                entity.Property(e => e.VerfiyUserId).HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
