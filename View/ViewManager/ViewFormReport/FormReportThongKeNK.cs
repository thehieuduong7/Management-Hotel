using Management_Hotel.Control_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Hotel.View.ViewManager.ViewFormReport
{
    public partial class FormReportThongKeNK : Form
    {
        public FormReportThongKeNK()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            this.chart1.DataSource = NhapKhoDAO.NhapKho_TongNhap_view();
            this.chart1.Series["Series1"].XValueMember = "TenMon";
            this.chart1.Series["Series1"].YValueMembers = "TongSoLuongDaNhap";
        }
    }
}
