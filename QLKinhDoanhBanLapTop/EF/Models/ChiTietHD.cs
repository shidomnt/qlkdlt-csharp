using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using QLKinhDoanhBanLapTop.Helpers;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLKinhDoanhBanLapTop.EF.Models
{
    [PrimaryKey(nameof(SoHD), nameof(MaHang))]
    internal class ChiTietHD
    {
        [ForeignKey(nameof(HoaDonNavigator))]
        [Column(TypeName = "varchar(20)")]
        public string SoHD { get; set; } = null!;

        [ForeignKey(nameof(HangNavigator))]
        [Column(TypeName = "varchar(20)")]
        public string MaHang { get; set; } = null!;

        [Range(0, int.MaxValue, ErrorMessage = "So luong phai lon hon 0")]
        [Required]
        public int SoLuong { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Gia phai lon hon 0")]
        [Browsable(false)]
        [Required]
        public int Gia { get; set; }

        [NotMapped]
        public string GiaText
        {
            get
            {
                return ConvertHelpers.FormatCurrency(Gia);
            }
        }

        [Browsable(false)]
        public HoaDon HoaDonNavigator { get; set; } = null!;

        [Browsable(false)]
        public Hang HangNavigator { get; set; } = null!;

        [NotMapped]
        [Browsable(false)]
        [DisplayName("Thành tiền")]
        public int ThanhTien
        {
            get => Gia * SoLuong;
        }

        [NotMapped]
        [DisplayName("Thành tiền")]
        public string ThanhTienText
        {
            get => ConvertHelpers.FormatCurrency(ThanhTien);
        }

    }
}
