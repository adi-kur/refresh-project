namespace Model.Covid
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<TB_COVID> TB_COVID { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TB_COVID>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COVID>()
                .Property(e => e.nama)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COVID>()
                .Property(e => e.npm)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COVID>()
                .Property(e => e.telepon)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COVID>()
                .Property(e => e.alamat_saat_ini)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COVID>()
                .Property(e => e.alamat_asal)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COVID>()
                .Property(e => e.posisi_saat_ini)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COVID>()
                .Property(e => e.create_by)
                .IsUnicode(false);

            modelBuilder.Entity<TB_COVID>()
                .Property(e => e.update_by)
                .IsUnicode(false);
        }
    }
}
