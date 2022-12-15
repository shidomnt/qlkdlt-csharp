﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QLKinhDoanhBanLapTop.EF;

#nullable disable

namespace QLKinhDoanhBanLapTop.Migrations
{
    [DbContext(typeof(QLKDLTContext))]
    partial class QLKDLTContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QLKinhDoanhBanLapTop.EF.Models.ChiTietHD", b =>
                {
                    b.Property<string>("SoHD")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("MaHang")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("Gia")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("SoHD", "MaHang");

                    b.HasIndex("MaHang");

                    b.ToTable("ChiTietHD");
                });

            modelBuilder.Entity("QLKinhDoanhBanLapTop.EF.Models.Hang", b =>
                {
                    b.Property<string>("MaHang")
                        .HasColumnType("varchar(20)");

                    b.Property<int>("DonGia")
                        .HasColumnType("int");

                    b.Property<string>("DvTinh")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TenHang")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("MaHang");

                    b.ToTable("Hang");
                });

            modelBuilder.Entity("QLKinhDoanhBanLapTop.EF.Models.HoaDon", b =>
                {
                    b.Property<string>("SoHD")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("LoaiHD")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.Property<string>("MaKH")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("NgayPS")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoTienTT")
                        .HasColumnType("int");

                    b.HasKey("SoHD");

                    b.HasIndex("MaKH");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("QLKinhDoanhBanLapTop.EF.Models.KhachHang", b =>
                {
                    b.Property<string>("MaKH")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("SoDt")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("varchar(12)");

                    b.Property<string>("TenKH")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("MaKH");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("QLKinhDoanhBanLapTop.EF.Models.PhThuChi", b =>
                {
                    b.Property<int>("SoPhieu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SoPhieu"));

                    b.Property<string>("LoaiPhieu")
                        .IsRequired()
                        .HasColumnType("varchar(1)");

                    b.Property<string>("MaKH")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime>("Ngay")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoTien")
                        .HasColumnType("int");

                    b.HasKey("SoPhieu");

                    b.HasIndex("MaKH");

                    b.ToTable("PhThuChi");
                });

            modelBuilder.Entity("QLKinhDoanhBanLapTop.EF.Models.ChiTietHD", b =>
                {
                    b.HasOne("QLKinhDoanhBanLapTop.EF.Models.Hang", "HangNavigator")
                        .WithMany("ChiTietHDs")
                        .HasForeignKey("MaHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("QLKinhDoanhBanLapTop.EF.Models.HoaDon", "HoaDonNavigator")
                        .WithMany("ChiTietHDs")
                        .HasForeignKey("SoHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HangNavigator");

                    b.Navigation("HoaDonNavigator");
                });

            modelBuilder.Entity("QLKinhDoanhBanLapTop.EF.Models.HoaDon", b =>
                {
                    b.HasOne("QLKinhDoanhBanLapTop.EF.Models.KhachHang", "KhachHangNavigator")
                        .WithMany("HoaDons")
                        .HasForeignKey("MaKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHangNavigator");
                });

            modelBuilder.Entity("QLKinhDoanhBanLapTop.EF.Models.PhThuChi", b =>
                {
                    b.HasOne("QLKinhDoanhBanLapTop.EF.Models.KhachHang", "KhachHangNavigator")
                        .WithMany("PhThuChis")
                        .HasForeignKey("MaKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHangNavigator");
                });

            modelBuilder.Entity("QLKinhDoanhBanLapTop.EF.Models.Hang", b =>
                {
                    b.Navigation("ChiTietHDs");
                });

            modelBuilder.Entity("QLKinhDoanhBanLapTop.EF.Models.HoaDon", b =>
                {
                    b.Navigation("ChiTietHDs");
                });

            modelBuilder.Entity("QLKinhDoanhBanLapTop.EF.Models.KhachHang", b =>
                {
                    b.Navigation("HoaDons");

                    b.Navigation("PhThuChis");
                });
#pragma warning restore 612, 618
        }
    }
}
