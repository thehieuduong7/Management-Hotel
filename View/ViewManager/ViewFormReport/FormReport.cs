using Management_Hotel.View.ViewManager.ViewFormReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Hotel.View.ViewAdmin.ViewFormReport
{
    public partial class FormReport : Form
    {
        public FormReport()
        {
            InitializeComponent();
        }
        private void openChildForm(Form form)
        {
            this.panelShow.Controls.Clear();
            form.TopLevel = false;
            this.panelShow.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Visible = true;
        }
        private void radioThongKeNhap_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioThongKeNhap.Checked == true)
            {
                Form form = new FormReportThongKeNK();
                openChildForm(form);
            }
        }

        private void radioThanhtoan_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioThanhtoan.Checked == true)
            {
                Form form = new FormReportThanhToan();
                openChildForm(form);
            }
        }

        private void radioNhapKho_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioNhapKho.Checked == true)
            {
                Form form = new FormReportNhapKho();
                openChildForm(form);
            }

        }
    }
}
