using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKinhDoanhBanLapTop.EF.Models
{
    internal class HoaDon
    {
        [Key]
        [Column(TypeName = "varchar(20)")]
        public string SoHD { get; set; } = null!;

        public DateTime NgayPS { get; set; } = DateTime.Now;

        [Required]
        public int SoTienTT { get; set; }

        [Column(TypeName = "varchar(1)")]
        [Required]
        public LoaiHD LoaiHD { get; set; } = LoaiHD.Xuat;

        public KhachHang KhachHangNavigator { get; set; } = null!;

        [ForeignKey(nameof(KhachHangNavigator))]
        [Column(TypeName = "varchar(20)")]
        public string MaKH { get; set; } = null!;

        public virtual List<ChiTietHD> ChiTietHDs { get; set; } = new List<ChiTietHD>();

    }
    enum LoaiHD
    {
        Xuat = 'X',
        Nhap = 'N'
    }

}
