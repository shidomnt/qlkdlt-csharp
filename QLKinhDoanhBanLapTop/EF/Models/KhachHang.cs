using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKinhDoanhBanLapTop.EF.Models
{
    internal class KhachHang
    {
        [Key]
        [Column(TypeName = "varchar(20)")]
        public string MaKH { get; set; } = null!;

        [Column(TypeName = "nvarchar(30)")]
        [MaxLength(30, ErrorMessage = "Ten qua dai! Toi da 30 ki tu")]
        [Required]
        public string TenKH { get; set; } = null!;

        [Column(TypeName = "nvarchar(50)")]
        [MaxLength(50, ErrorMessage = "Dia chi qua dai! Toi da 50 ki tu")]
        public string DiaChi { get; set; } = null!;

        [Column(TypeName = "varchar(12)")]
        [MaxLength(12, ErrorMessage = "So dien thoai qua dai! Toi da 12 ki tu")]
        public string SoDt { get; set; } = null!;

        public virtual List<HoaDon> HoaDons { get; set; } = new List<HoaDon>();

        public virtual List<PhThuChi> PhThuChis { get; set; } = new List<PhThuChi>();

    }
}
