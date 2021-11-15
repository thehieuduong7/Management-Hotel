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

namespace Management_Hotel.View.ViewManager.ViewFormAccount
{
    public partial class FormCRUDAccount : Form
    {
        public FormCRUDAccount()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            DataTable data = AccountNVDAO.AccountNV_detail_view();
            fillData(data);
        }
        public void fillData(DataTable data)
        {
            // Username,Password,ID_NV,TenNV,ChucVU
            this.dataGridViewGuest.DataSource = data;
            this.dataGridViewGuest.AllowUserToAddRows = false;
            this.dataGridViewGuest.RowTemplate.Height = 100;
            int[] colWidth = {120,120,60,160,170};
            string[] colName = { "Username","Password","ID Nhan Vien","Ten Nhan Vien","Chuc Vu" };
            
            this.dataGridViewGuest.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewGuest.ReadOnly = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddAccount form = new FormAddAccount();
            if (form.ShowDialog() == DialogResult.OK)
            {
                init();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            init();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewGuest.SelectedRows.Count == 0)
            {
                MessageBox.Show
                      ("Please select employee!",
                      "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String user = this.dataGridViewGuest.SelectedRows[0].Cells[0].Value.ToString().Trim();
            String pass = this.dataGridViewGuest.SelectedRows[0].Cells[1].Value.ToString().Trim();

            FormEditAccount form = new FormEditAccount();
            form.fillData(user, pass);
            if (form.ShowDialog() == DialogResult.OK)
            {
                init();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewGuest.SelectedRows.Count == 0)
            {
                MessageBox.Show
                      ("Please select employee!",
                      "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure?", "Management Hotel",
              MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            String username = this.dataGridViewGuest.SelectedRows[0].Cells[0].Value.ToString().Trim();
            try
            {

                if (AccountNVDAO.AccountNV_del_proc(username, null))
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
    }
}
