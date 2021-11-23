using Management_Hotel.Control_DAO;
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

namespace Management_Hotel.View.ViewManager
{
    public partial class FormAddAccount : Form
    {
        public FormAddAccount()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            DataTable data = NhanVienDAO.NhanVien_detail_view();
            this.comboBoxEmployee.DataSource = data;
            this.comboBoxEmployee.DisplayMember = "Ten";
            this.comboBoxEmployee.ValueMember = "ID_NV";
            this.comboBoxEmployee.SelectedIndex = -1;
            
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked == true)
            {
                this.textBoxComfirm.UseSystemPasswordChar = false;
                this.textBoxPass.UseSystemPasswordChar = false;
            }
            else
            {
                this.textBoxComfirm.UseSystemPasswordChar = true;
                this.textBoxPass.UseSystemPasswordChar = true;
            }
        }
        public bool checkComfirm()
        {
            if (this.textBoxComfirm.Text != this.textBoxPass.Text)
            {
                return false;
            }
     
            return true;
        }

        private void buttonRegis_Click(object sender, EventArgs e)
        {
            if (this.comboBoxEmployee.SelectedIndex == -1)
            {
                MessageBox.Show
                       ("Please select employee!",
                       "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show
("Do you want to save", "Management Hotel",
MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            try
            {
                if (!checkComfirm()) throw new FormatException();
                String username = this.textBoxUser.Text.Trim();
                String pass = this.textBoxPass.Text.Trim();
                int id_nv = int.Parse(this.comboBoxEmployee.SelectedValue.ToString());
                if (AccountNVDAO.AccountNV_add_proc(username,pass,id_nv,null))
                {
                    MessageBox.Show("Add success", "Management Hotel",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show
                       ("Fail format!",
                       "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void comboBoxEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = this.comboBoxEmployee.SelectedIndex;
            if (i == -1) return;
            try
            {
                int id = int.Parse(this.comboBoxEmployee.SelectedValue.ToString());
                fillData(id);

            }
            catch (FormatException)
            {
                return;
            }
        }
        public void fillData(int id)
        {
            DataTable data = NhanVienDAO.NhanVien_searchByID_func(id);
            if (data.Rows.Count == 0) return;
            String ten = data.Rows[0][2].ToString().Trim();
            String chucVu = (data.Rows[0][8].ToString().Trim() == "TiepTan") ? "Tiếp Tân" : "Quản lý";
            Image img = GlobalUser.CvtToImg((byte[])data.Rows[0][6]);

            this.labelTen.Text = ten;;
            this.labelChucVu.Text = chucVu;
            if(img!=null)
            this.pictureBoxEmployee.Image = img;
        }
    }
}
