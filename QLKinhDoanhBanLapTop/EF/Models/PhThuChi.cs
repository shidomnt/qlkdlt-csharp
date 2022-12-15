using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKinhDoanhBanLapTop.EF.Models
{
    internal class PhThuChi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SoPhieu { get; set; }

        public DateTime Ngay { get; set; } = DateTime.Now;

        [Range(0, int.MaxValue, ErrorMessage = "So tien phai lon hon 0")]
        public int SoTien { get; set; }

        [Column(TypeName = "varchar(1)")]
        public LoaiPh LoaiPhieu { get; set; }

        public KhachHang KhachHangNavigator { get; set; } = null!;

        [ForeignKey(nameof(KhachHangNavigator))]
        public string MaKH { get; set; } = null!;
    }

    enum LoaiPh
    {
        Thu = 'T',
        Chi = 'C'
    }
}
