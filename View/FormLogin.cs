using Management_Hotel.Control;
using Management_Hotel.Control.ControlManager;
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

namespace Management_Hotel.View
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.ctrAcc = new CtrAccount();
        }
        private CtrAccount ctrAcc;
        private bool isFull()
        {
            return (this.textBoxUser.Text.Trim() != "") && (this.textBoxPass.Text.Trim() != "");
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (!isFull())
            {
                MessageBox.Show("This username or password can not be empty","Fail",
                    MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            string user = this.textBoxUser.Text.Trim();
            string pass = this.textBoxPass.Text.Trim();
            int id = ctrAcc.accessAccount(new Account(user, pass),this.pos);
            if (id == -1)
            {
                MessageBox.Show("Username or password is incorrect", "Fail"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                FormClient form = new FormClient();
                CtrManager ctrManager = new CtrManager();
                form.setMode(ctrManager.getEmployee(id));
                this.Visible = false;
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.Visible = true;
                }
                else if (result == DialogResult.Cancel)
                {
                    this.Close();
                }
                
            }
        }
        private void form_load()
        {
            this.radioLabour.Checked = true;
            radioLabour_CheckedChanged(null, null);
            this.textBoxUser.Text = "";
            this.textBoxPass.Text = "";
        }
        private string pos = "Labourer";
        private void radioLabour_CheckedChanged(object sender, EventArgs e)
        {
            this.pos = "Labourer";
        }

        private void radioRecept_CheckedChanged(object sender, EventArgs e)
        {
            this.pos = "Receptionist";
        }

        private void radioManager_CheckedChanged(object sender, EventArgs e)
        {
            this.pos = "Manager";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
