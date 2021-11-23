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

namespace Management_Hotel.View.ViewManager
{
    public partial class FormCRUDEmployee : Form
    {
        public FormCRUDEmployee()
        {
            InitializeComponent();
            init();
        }

        public void init()
        {
            this.textBoxSearch.Text = "";
            DataTable data = NhanVienDAO.NhanVien_detail_view();
            fillData(data);
        }
        public void fillData(DataTable data)
        {
            //ID_NV,Ho,Ten,NgaySinh,SDT,GioiTinh,Avatar," +
            //"Luong,ChucVu,TaiKhoan,MatKhau
            this.dataGridViewGuest.DataSource = data;
            this.dataGridViewGuest.AllowUserToAddRows = false;
            this.dataGridViewGuest.RowTemplate.Height = 100;
            int[] colWidth = { 60,80,160,80,120,80,100,80,80 };
            string[] colName = { "ID", "Ho", "Ten", "Ngay sinh", "SDT", "Gioi Tinh", "Avatar","Luong","Chuc Vu"};
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
            FormAddEmpl form = new FormAddEmpl();
            if (form.ShowDialog() == DialogResult.OK)
            {
                init();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            init();
        }

        private void dataGridViewGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewGuest.SelectedRows.Count == 0)
            {
                MessageBox.Show
            ("Please select!", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String str_id =this.dataGridViewGuest.SelectedRows[0].Cells[0].Value.ToString();
            int id = int.Parse(str_id);
            if (MessageBox.Show("Are you sure?", "Management Hotel",
              MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            try
            {

                if (NhanVienDAO.NhanVien_del_proc(id, null))
                {
                    MessageBox.Show("Remove success", "Management Hotel",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Remove fail", "Management Hotel",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewGuest.SelectedRows.Count == 0)
            {
                MessageBox.Show
            ("Please select!", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String str_id = this.dataGridViewGuest.SelectedRows[0].Cells[0].Value.ToString();
            int id = int.Parse(str_id);
            FormEditEmployee form = new FormEditEmployee();
            form.fillData(id);
            if (form.ShowDialog()==DialogResult.OK)
            {
                init();
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            String search = this.textBoxSearch.Text.Trim();
            DataTable data = NhanVienDAO.NhanVien_searchFilter_func(search);
            fillData(data);
        }
    }
}
