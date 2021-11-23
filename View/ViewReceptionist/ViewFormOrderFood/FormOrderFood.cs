using Management_Hotel.Control;
using Management_Hotel.Control_DAO;
using Management_Hotel.Model;
using Management_Hotel.View.ViewReceptionist.CtrUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Hotel.View.ViewReceptionist.ViewFormOrderFood
{
    public partial class FormOrderFood : Form
    {
        public FormOrderFood()
        {
            InitializeComponent();
            init();
        }
        int id_datPhong;
        public void init()
        {
            this.textBoxSearch.Text = "";
            DataTable data = KhoDAO.Kho_Available_view();
            dataGrid_Load(data);
        }
        public bool fillData(int id_datPhong)
        {
            this.id_datPhong = id_datPhong;
            return true;
        }
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            SqlTransaction trans = ConnectionController.beginTransaction();
            foreach (ControlSelectFood ctr in this.panelSelect.Controls)
            {
                int id_mon = ctr.getID();
                int soLuong = ctr.getSoLuong();
                if (!DatMonDAO.DatMon_add_proc(this.id_datPhong,id_mon,soLuong,trans))
                {
                    MessageBox.Show("Order food fail", "Management Hotel",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    trans.Rollback();
                    init();
                    return;
                }
            }
            trans.Commit();
            init();
            this.panelSelect.Controls.Clear();
            MessageBox.Show("Order food success!", "Management Hotel",
       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void dataGrid_Load(DataTable data)
        {
            this.dataGridViewFood.DataSource = data;
            this.dataGridViewFood.AllowUserToAddRows = false;
            this.dataGridViewFood.RowTemplate.Height = 50;
            int[] colWidth = { 80, 120, 120, 120, 160 };
            string[] colName = { "ID", "Ten Mon", "Số lượng", "Giá","Photo" };
            for (int i = 0; i < colName.Length; i++)
            {
                this.dataGridViewFood.Columns[i].HeaderText = colName[i];
                this.dataGridViewFood.Columns[i].Width = colWidth[i];
            }
            this.dataGridViewFood.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFood.ReadOnly = true;
        }
        private void dataGridViewFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataTable data = this.dataGridViewFood.DataSource as DataTable;
            int id = int.Parse(data.Rows[e.RowIndex][0].ToString());
            foreach (ControlSelectFood ctr in this.panelSelect.Controls)
            {
                if (ctr.getID() == id)
                {
                    ctr.buttonPlus_Click(null, null);
                    return;
                }
            }
            ControlSelectFood control = new ControlSelectFood();
            if (!control.fillData(id))
            {
                control.Dispose();
                MessageBox.Show("Sold out", "Management Hotel",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            panelSelect.Controls.Add(control);
            control.Dock = DockStyle.Top;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewFood_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.dataGridViewFood.Rows[e.RowIndex].Selected = false;
            }
        }

        private void dataGridViewFood_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.dataGridViewFood.ClearSelection();
                this.dataGridViewFood.Rows[e.RowIndex].Selected = true;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search = this.textBoxSearch.Text.Trim();
            DataTable data = KhoDAO.Kho_searchFilter_func(search);
            dataGrid_Load(data);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            float total = 0;
            foreach (ControlSelectFood ctr in this.panelSelect.Controls)
            {
                float gia = ctr.getGia();
                int soLuong = ctr.getSoLuong();
                total += gia * soLuong;
            }
            this.labelTotalMoney.Text = string.Format("{0}d", total);
        }
    }
}
