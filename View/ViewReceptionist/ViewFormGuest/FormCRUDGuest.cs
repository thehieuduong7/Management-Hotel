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
    public partial class FormCRUDGuest : Form
    {
        public FormCRUDGuest()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            this.textBoxSearch.Text="";
            DataTable data = KhachHangDAO.KhachHang_detail_view();
            fillData(data);
        }
        public void fillData(DataTable data)
        {
            this.dataGridViewGuest.DataSource = data;
            this.dataGridViewGuest.AllowUserToAddRows = false;
            this.dataGridViewGuest.RowTemplate.Height = 100;
            int[] colWidth = { 100, 160, 160, 200, 100, 120,160 };
            string[] colName = {"ID","Ho","Ten","Ngay sinh","SDT","Gioi Tinh","Avatar" };
            for (int i = 0; i < colName.Length; i++)
            {
                this.dataGridViewGuest.Columns[i].HeaderText = colName[i];
                this.dataGridViewGuest.Columns[i].Width = colWidth[i];
            }
            this.dataGridViewGuest.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewGuest.ReadOnly = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddGuest form = new FormAddGuest();
            if (form.ShowDialog() == DialogResult.OK)
            {
                init();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
       
            init();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string search = this.textBoxSearch.Text.Trim();
            DataTable data = KhachHangDAO.KhachHang_searchFilter_func(search);
            fillData(data);
        }

        private void dataGridViewGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int id = int.Parse(this.dataGridViewGuest[0, e.RowIndex].Value.ToString());
                FormEditGuest form = new FormEditGuest();
                form.fillData(id);
                if (form.ShowDialog() == DialogResult.OK)
                    init();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panelShow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
