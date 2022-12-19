using QLKinhDoanhBanLapTop.EF;
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
    internal partial class DSHangThanhToan : Form
    {
        public List<HangThanhToan> ListHangThanhToan { get; set; }

        public QLKDLTContext Context { get; set; }

        public DSHangThanhToan(QLKDLTContext context)
        {
            InitializeComponent();
            ListHangThanhToan = new();
            Context = context;
            DataGridView_ThemHang.DataSource = ListHangThanhToan;
        }

        private void Btn_ChapNhan_Click(object sender, EventArgs e)
        {
            
            DialogResult= DialogResult.OK;
            Close();
        }

        private void Btn_Them_Click(object sender, EventArgs e)
        {
            var form_ThemHang = new ThemHang(Context);
            form_ThemHang.ShowDialog();
        }
    }
}
