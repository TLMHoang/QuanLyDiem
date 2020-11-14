namespace DTO
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBQuanLyDiem : DbContext
    {
        public DBQuanLyDiem()
            : base("name=DBQuanLyDiem")
        {
        }

        public virtual DbSet<Diem> Diems { get; set; }
        public virtual DbSet<HeDiem> HeDiems { get; set; }
        public virtual DbSet<HocKy> HocKies { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<LoaiDiem> LoaiDiems { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<MonHoc> MonHocs { get; set; }
        public virtual DbSet<NienKhoa> NienKhoas { get; set; }
        public virtual DbSet<PhanCongDay> PhanCongDays { get; set; }
        public virtual DbSet<PhanCongMon> PhanCongMons { get; set; }
        public virtual DbSet<TaiKhoanSinhVien> TaiKhoanSinhViens { get; set; }
        public virtual DbSet<TaiKhoanTruong> TaiKhoanTruongs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Diem>()
                .Property(e => e.Diem1)
                .HasPrecision(4, 2);

            modelBuilder.Entity<HeDiem>()
                .HasMany(e => e.MonHocs)
                .WithOptional(e => e.HeDiem)
                .HasForeignKey(e => e.IDHeDiem);

            modelBuilder.Entity<HocKy>()
                .HasMany(e => e.PhanCongDays)
                .WithOptional(e => e.HocKy)
                .HasForeignKey(e => e.IDHK);

            modelBuilder.Entity<Khoa>()
                .HasMany(e => e.TaiKhoanSinhViens)
                .WithOptional(e => e.Khoa)
                .HasForeignKey(e => e.IDKhoa);

            modelBuilder.Entity<LoaiDiem>()
                .HasMany(e => e.Diems)
                .WithOptional(e => e.LoaiDiem)
                .HasForeignKey(e => e.IDLoaiDiem);

            modelBuilder.Entity<Lop>()
                .HasMany(e => e.TaiKhoanSinhViens)
                .WithOptional(e => e.Lop)
                .HasForeignKey(e => e.IDLop);

            modelBuilder.Entity<MonHoc>()
                .HasMany(e => e.PhanCongMons)
                .WithOptional(e => e.MonHoc)
                .HasForeignKey(e => e.IDMon);

            modelBuilder.Entity<NienKhoa>()
                .Property(e => e.ThoiGian)
                .IsUnicode(false);

            modelBuilder.Entity<NienKhoa>()
                .HasMany(e => e.TaiKhoanSinhViens)
                .WithOptional(e => e.NienKhoa)
                .HasForeignKey(e => e.IDNienKhoa);

            modelBuilder.Entity<PhanCongDay>()
                .HasMany(e => e.Diems)
                .WithOptional(e => e.PhanCongDay)
                .HasForeignKey(e => e.IDPhanCongDay);

            modelBuilder.Entity<PhanCongMon>()
                .HasMany(e => e.PhanCongDays)
                .WithOptional(e => e.PhanCongMon)
                .HasForeignKey(e => e.IDPhanCongMon);

            modelBuilder.Entity<TaiKhoanSinhVien>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanSinhVien>()
                .Property(e => e.Pass)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanSinhVien>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanSinhVien>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanSinhVien>()
                .HasMany(e => e.Diems)
                .WithOptional(e => e.TaiKhoanSinhVien)
                .HasForeignKey(e => e.IDSV);

            modelBuilder.Entity<TaiKhoanTruong>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanTruong>()
                .Property(e => e.Pass)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanTruong>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanTruong>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<TaiKhoanTruong>()
                .HasMany(e => e.PhanCongMons)
                .WithOptional(e => e.TaiKhoanTruong)
                .HasForeignKey(e => e.IDGV);
        }
    }
}
