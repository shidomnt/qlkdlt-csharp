using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Browsable(false)]
        [Column("LoaiHD", TypeName = "varchar(1)")]
        [Required]
        public char LoaiHDId { get; set; }

        [NotMapped]
        public ELoaiHD LoaiHD
        {
            get
            {
                return (ELoaiHD)LoaiHDId;
            }
            set { LoaiHDId = (char)value; }
        }

        [Browsable(false)]
        public KhachHang KhachHangNavigator { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(KhachHangNavigator))]
        [Column(TypeName = "varchar(20)")]
        public string MaKH { get; set; } = null!;

        public virtual List<ChiTietHD> ChiTietHDs { get; set; } = new List<ChiTietHD>();

    }
    enum ELoaiHD
    {
        Xuất = 'X',
        Nhập = 'N'
    }

}
