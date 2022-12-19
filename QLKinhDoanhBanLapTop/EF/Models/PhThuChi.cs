using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLKinhDoanhBanLapTop.EF.Models
{
    internal class PhThuChi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SoPhieu { get; set; }

        [Required]
        public DateTime Ngay { get; set; } = DateTime.Now;

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "So tien phai lon hon 0")]
        public int SoTien { get; set; }

        [Browsable(false)]
        [Required]
        [Column("LoaiPhieu", TypeName = "varchar(1)")]
        public char LoaiPhieuId { get; set; }

        [NotMapped]
        public virtual LoaiPh LoaiPhieu
        {
            get
            {
                return (LoaiPh)LoaiPhieuId;
            }
            set { LoaiPhieuId = (char)value; }
        }

        [Browsable(false)]
        public KhachHang KhachHangNavigator { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(KhachHangNavigator))]
        public string MaKH { get; set; } = null!;
    }

    enum LoaiPh
    {
        Thu = 'T',
        Chi = 'C'
    }
}
