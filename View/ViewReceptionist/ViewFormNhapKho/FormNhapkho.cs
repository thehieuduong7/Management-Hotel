using Management_Hotel.Control;
using Management_Hotel.Control_DAO;
using Management_Hotel.View.ViewReceptionist.CtrUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Hotel.View.ViewReceptionist.ViewFormNhapKho
{
    public partial class FormNhapkho : Form
    {
        public FormNhapkho()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            DataTable data = KhoDAO.Kho_detail_view();
            fillData(data);
            this.textBoxSearch.Text = "";
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
                    panel.Height = 150;
                    panel.BringToFront();
                }
                int id = int.Parse(data.Rows[i][0].ToString());
                ControlClickFood control = new ControlClickFood();
                control.formParent = this;
                control.fillData(id);
               
                panel.Controls.Add(control);
                control.Dock = DockStyle.Left;
                control.BringToFront();
            }
        }

        public void selectFood(int id_food)
        {
            foreach (ControlSelectFood ctr in this.panelSelect.Controls)
            {
                if (ctr.getID() == id_food)
                {
                    ctr.buttonPlus_Click(null, null);
                    return;
                }
            }
            ControlSelectFood control = new ControlSelectFood();
            control.fillData(id_food);
            control.setMax(9999999);
            panelSelect.Controls.Add(control);
            control.Dock = DockStyle.Top;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            init();
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure??", "Management Hotel",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }
            SqlTransaction trans = ConnectionController.beginTransaction();
            foreach (ControlSelectFood ctr in this.panelSelect.Controls)
            {
                int id_mon = ctr.getID();
                int soLuong = ctr.getSoLuong();
                if (!NhapKhoDAO.NhapKho_add_proc(id_mon,soLuong,GlobalUser.idNhanVien,trans))
                {
                    MessageBox.Show("input food fail", "Management Hotel",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    trans.Rollback();
                    init();
                    return;
                }
            }
           trans.Commit();
            MessageBox.Show("input food success", "Management Hotel",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            init();
            this.panelSelect.Controls.Clear();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (ControlSelectFood ctr in this.panelSelect.Controls)
            {
                count+= ctr.getSoLuong();
            }
            this.labelTotal.Text = count.ToString();
        }
    }
}
