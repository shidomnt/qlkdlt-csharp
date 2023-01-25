using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using QLKinhDoanhBanLapTop.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKinhDoanhBanLapTop.Classes
{
    internal class ReportHelper
    {
        public static void Load(LocalReport report, string tenKH, IEnumerable<object> source,
                                DateTime ngayBD, DateTime ngayKT
            )
        {
            var parameters = new[]
            {
                new ReportParameter("TenKH", tenKH),
                new ReportParameter("NgayBD", ngayBD.ToString("dd/MM/yyyy")),
                new ReportParameter("NgayKT", ngayKT.ToString("dd/MM/yyyy"))
            };
            //var fs = Properties.Resources.ChiTietXuatHang;
            var fs = File.ReadAllBytes(@"E:\Study\C_Sharp\source\repos\QLKDLT\QLKinhDoanhBanLapTop\Reports\Designs\ChiTietXuatHang.rdlc");
            report.LoadReportDefinition(new MemoryStream(fs));
            report.DataSources.Add(new ReportDataSource("CTHDXuat", source));
            report.SetParameters(parameters);
        }
    }
}
