using Management_Hotel.Control_DAO;
using Management_Hotel.Model;
using Management_Hotel.View.ViewReceptionist.CtrUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Hotel.View.ViewReceptionist
{
    public partial class FormOrderRoom : Form
    {
        public FormOrderRoom()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            fillData(PhongDAO.Phong_trangthai_view());
        }
        public void fillData(DataTable data)
        {

            if (data == null) return;
            Panel panel = new Panel();
            this.panelShow.Controls.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (i % 6 == 0)
                {
                    panel = new Panel();
                    this.panelShow.Controls.Add(panel);
                    panel.Dock = DockStyle.Top;
                    panel.Height = 155;
                    panel.BringToFront();
                }
                ControlOrderRoom control = new ControlOrderRoom();
                int id_phong = int.Parse(data.Rows[i][0].ToString());
                control.formParent = this;
                control.fillData(id_phong);
                panel.Controls.Add(control);
                control.Dock = DockStyle.Left;
                control.BringToFront();
            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search = this.textBoxSearch.Text.Trim();
            DataTable data = PhongDAO.Phong_searchFilter_func(search);
            fillData(data);
        }
    }
}
