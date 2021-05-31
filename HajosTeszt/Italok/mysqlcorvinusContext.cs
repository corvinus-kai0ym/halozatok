using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HajosTeszt.Italok
{
    public partial class mysqlcorvinusContext : DbContext
    {
        public mysqlcorvinusContext()
        {
        }

        public mysqlcorvinusContext(DbContextOptions<mysqlcorvinusContext> options)
            : base(options)
        {
        }

      
        public virtual DbSet<Italok> Italoks { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=tcp:kai0ym-covinus.database.windows.net,1433;Initial Catalog=mysql-corvinus;User Id=kai0ym@kai0ym-covinus;Password=3337305Bp1237");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hungarian_CI_AS");

           
            modelBuilder.Entity<Italok>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Italok");
               
                entity.Property(e => e.ItalNev)
                    .IsRequired()
                    .HasMaxLength(50);
                entity.Property(e => e.ItalÁr)
                    .IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
