using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKinhDoanhBanLapTop.Forms
{
    public partial class ThanhToan : Form
    {

        public ThanhToan()
        {
            InitializeComponent();
        }

        private void Btn_ThemHang_Click(object sender, EventArgs e)
        {
            var form_ThemHang = new DSHangThanhToan();
            var result = form_ThemHang.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("ok");
            }
        }
    }
    public class HangThanhToan
    {
        public string MaHang { get; set; } = string.Empty;

        public string TenHang { get; set; } = string.Empty;

        public int SoLuong { get; set; }

        public int DonGia { get; set; }
    }
}
