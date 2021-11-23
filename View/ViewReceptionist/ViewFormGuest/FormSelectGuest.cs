using Management_Hotel.Control_DAO;
using Management_Hotel.Model;
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
    public partial class FormSelectGuest : Form
    {

        public FormSelectGuest()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            this.textBoxSearch.Text = "";
            DataTable data = KhachHangDAO.KhachHang_detail_view();
            fillData(data);
        }
        public void fillData(DataTable data)
        {

            // ID_Mon,TenMon,SoLuong,GiaGoc,GiaBan,Photo;
            this.dataGridViewGuest.DataSource = data;
            this.dataGridViewGuest.AllowUserToAddRows = false;
            this.dataGridViewGuest.RowTemplate.Height = 60;
            int[] colWidth = { 50, 100, 160, 100, 100, 80};
            string[] colName = { "ID", "Ten Mon", "So Luong Trong Kho", "Gia Goc","Gia Ban", "Photo" };
            for (int i = 0; i < colName.Length; i++)
            {
                this.dataGridViewGuest.Columns[i].HeaderText = colName[i];
                this.dataGridViewGuest.Columns[i].Width = colWidth[i];
            }
            this.dataGridViewGuest.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewGuest.ReadOnly = true;
            this.dataGridViewGuest.ClearSelection();
        }
        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
            FormAddGuest form = new FormAddGuest();
            if (form.ShowDialog() == DialogResult.OK)
            {
                init();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            init();
        }
        static int id_guestSelect;
        public static int get_id_guesst()
        {
            return id_guestSelect;
        }
        private void dataGridViewGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int id = int.Parse(this.dataGridViewGuest[0, e.RowIndex].Value.ToString());
                id_guestSelect = id;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void dataGridViewGuest_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.dataGridViewGuest.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dataGridViewGuest_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridViewGuest.ClearSelection();
        }
    }
}
