namespace sms.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyDBContext : DbContext
    {
        public MyDBContext()
            : base("name=MyDBContext")
        {
        }

        public virtual DbSet<DiemDanh> DiemDanhs { get; set; }
        public virtual DbSet<HocKy> HocKies { get; set; }
        public virtual DbSet<HocPhan> HocPhans { get; set; }
        public virtual DbSet<HocPhan_HocKy> HocPhan_HocKy { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<LopHocPhan> LopHocPhans { get; set; }
        public virtual DbSet<NienKhoa> NienKhoas { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<SV_LHP> SV_LHP { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User_Role> User_Role { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HocKy>()
                .HasMany(e => e.HocPhan_HocKy)
                .WithRequired(e => e.HocKy)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HocPhan>()
                .HasMany(e => e.HocPhan_HocKy)
                .WithRequired(e => e.HocPhan)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SinhVien>()
                .Property(e => e.image)
                .IsFixedLength();

            modelBuilder.Entity<SinhVien>()
                .HasMany(e => e.DiemDanhs)
                .WithRequired(e => e.SinhVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SV_LHP>()
                .Property(e => e.Diem1)
                .HasPrecision(2, 2);

            modelBuilder.Entity<SV_LHP>()
                .Property(e => e.Diem2)
                .HasPrecision(2, 2);

            modelBuilder.Entity<SV_LHP>()
                .Property(e => e.Diem3)
                .HasPrecision(2, 2);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
