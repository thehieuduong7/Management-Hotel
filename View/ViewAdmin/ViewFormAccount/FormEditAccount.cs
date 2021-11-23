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
    public partial class FormEditAccount : Form
    {
        public FormEditAccount()
        {
            InitializeComponent();
        }
         string username;
        string pass;

        public void fillData(string username,string pass)
        {
            //ID_KH,Ho,Ten,NgaySinh,SDT,GioiTinh,Avatar
            this.username = username;
            this.pass = pass;


            DataTable data = AccountNVDAO.AccountNV_login_func(username,pass);
            if (data.Rows.Count == 0) return;

            DataRow row = data.Rows[0];
            

            string id = row[2].ToString().Trim();
            string ten = row[3].ToString().Trim();
            String chucvu = row[4].ToString().Trim();

            DataTable data_emp = NhanVienDAO.NhanVien_searchByID_func(int.Parse(id));
            Image img = GlobalUser.CvtToImg((byte[])data_emp.Rows[0][6]);


            this.labelID.Text = id;
            this.labelTen.Text = ten;
            this.labelChucVu.Text = chucvu;
            this.textBoxUser.Text = username;
            this.pictureBoxEmployee.Image = img;
            this.textBoxPass.Text = "";
            this.textBoxComfirm.Text = "";

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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
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
            
            if (MessageBox.Show
("Do you want to save", "Management Hotel",
MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            try
            {
                if (!checkComfirm()) throw new FormatException();
                String username = this.textBoxUser.Text.Trim();
                String pass = this.textBoxPass.Text.Trim();
                if (AccountNVDAO.AccountNV_upd_proc(username, pass, null))
                {
                    MessageBox.Show("Save success", "Management Hotel",
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
    }
}
