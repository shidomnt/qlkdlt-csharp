using QLKinhDoanhBanLapTop.Helpers;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLKinhDoanhBanLapTop.EF.Models
{
    internal class Hang
    {
        [Key]
        [Column(TypeName = "varchar(20)")]
        public string MaHang { get; set; } = null!;

        [Column(TypeName = "nvarchar(30)")]
        [MaxLength(30, ErrorMessage = "Ten hang qua dai! Toi da 30 ki tu")]
        [Required]
        public string TenHang { get; set; } = null!;

        [Column(TypeName = "nvarchar(20)")]
        [MaxLength(20, ErrorMessage = "Don vi qua dai! Toi da 20 ki tu")]
        [Required]
        public string DvTinh { get; set; } = null!;

        [Range(0, int.MaxValue, ErrorMessage = "Don gia phai lon hon 0")]
        [Browsable(false)]
        [Required]
        public int DonGia { get; set; }

        [NotMapped]
        public string DonGiaText
        {
            get
            {
                return ConvertHelpers.FormatCurrency(DonGia);
            }
        }

        public List<ChiTietHD> ChiTietHDs { get; set; } = new List<ChiTietHD>();

    }
}
