using Management_Hotel.Control;
using Management_Hotel.Control_DAO;
using Management_Hotel.Model;
using Management_Hotel.View.ViewAdmin;
using Management_Hotel.View.ViewManager;
using Management_Hotel.View.ViewReceptionist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Hotel.View
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        
        }
 

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public bool isFull()
        {
            if(this.textBoxUser.Text!="" && this.textBoxPass.Text != "")
            {
                return true;
            }
            return false;
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!isFull())
            {
                MessageBox.Show("Fail", "Management Hotel",
    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string username = this.textBoxUser.Text.Trim();
            string password = this.textBoxPass.Text.Trim();

            if (ConnectionController.login(username, password))
            {

                DataTable data = AccountNVDAO.AccountNV_login_func(username, password);
                if (data != null && data.Rows.Count!=0)
                {
                    GlobalUser.idNhanVien = int.Parse(data.Rows[0][2].ToString());
                    GlobalUser.ChucVu = data.Rows[0][4].ToString().Trim();
                }
                else
                {
                    GlobalUser.ChucVu = "Admin";
                }
                this.Visible = false;
                Form form = new FormClient();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.Visible = true;
                }
                else
                {
                    this.Dispose();
                }
            }
            else
            {
                MessageBox.Show("Wrong username or password", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
