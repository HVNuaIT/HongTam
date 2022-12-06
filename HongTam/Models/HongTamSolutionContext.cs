using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HongTam.Models
{
    public partial class HongTamSolutionContext : DbContext
    {
        public HongTamSolutionContext()
        {
        }

        public HongTamSolutionContext(DbContextOptions<HongTamSolutionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CoKhi> CoKhis { get; set; }
        public virtual DbSet<DanhMuc> DanhMucs { get; set; }
        public virtual DbSet<GioiThieu> GioiThieus { get; set; }
        public virtual DbSet<LienHe> LienHes { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-US9F04C\\SQLEXPRESS2012;Initial Catalog=HongTamSolution;Integrated Security=True ;User ID =sa;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoKhi>(entity =>
            {
                entity.HasKey(e => e.MaSp);

                entity.ToTable("CoKhi");

                entity.Property(e => e.MaSp).HasColumnName("MaSP");
            });

            modelBuilder.Entity<DanhMuc>(entity =>
            {
                entity.HasKey(e => e.MaDanhMuc)
                    .HasName("PK_DanhMuc]");

                entity.ToTable("DanhMuc");

                entity.Property(e => e.TenDanhMuc).HasMaxLength(50);
            });

            modelBuilder.Entity<GioiThieu>(entity =>
            {
                entity.HasKey(e => e.MaGt);

                entity.ToTable("GioiThieu");

                entity.Property(e => e.MaGt).HasColumnName("MaGT");

                entity.Property(e => e.HinhAnh)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.NoiDung)
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<LienHe>(entity =>
            {
                entity.HasKey(e => e.MaLienHe);

                entity.ToTable("LienHe");

                entity.Property(e => e.LoiNhan).HasMaxLength(50);

                entity.Property(e => e.TenKhachHang).IsRequired();
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DienTich).HasMaxLength(50);

                entity.Property(e => e.TenKhach).HasMaxLength(50);

                entity.Property(e => e.TieuDe).HasMaxLength(100);
            });

            modelBuilder.Entity<TaiKhoan>(entity =>
            {
                entity.ToTable("TaiKhoan");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.TaiKhoan1).HasColumnName("TaiKhoan");

                entity.Property(e => e.TenAdmin).HasMaxLength(50);

                entity.Property(e => e.TrangThai).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
