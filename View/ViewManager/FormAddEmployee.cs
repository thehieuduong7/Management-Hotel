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

namespace Management_Hotel.View.ViewManager
{
    public partial class FormAddEmployee : Form
    {
        public FormAddEmployee()
        {
            InitializeComponent();
            ctrManager = new CtrManagerAddEmployee();
            ctrAccount = new CtrAccount();
        }
        private CtrManagerAddEmployee ctrManager;
        private CtrAccount ctrAccount;
        private bool isValid()
        {

            int years = DateTime.Now.Year - this.dateDOB.Value.Year;
            if ((this.textBoxFname.Text.Trim() == "") || (this.textBoxLname.Text.Trim() == "") ||
                (this.textBoxPhone.Text.Trim() == "") || (this.textBoxAddress.Text.Trim() == "") ||
                (this.pictureBoxAvatar.Image == null) || (this.textBoxPass.Text.Trim() == "")
                || (this.textBoxConfirm.Text.Trim() == "") || (this.textBoxUser.Text.Trim() == "")
                || (this.pictureBoxAvatar.Image == null))
            {
                MessageBox.Show("Something can not be empty", "Fail"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!(years < 100 && years > 18))
            {
                MessageBox.Show("Your old must <100 and >20", "Fail"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (ctrAccount.isExistingUsername(this.textBoxUser.Text.Trim()))
            {
                MessageBox.Show("This username already exists", "Fail"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(this.textBoxPass.Text.Trim()!=this.textBoxConfirm.Text.Trim())
            {
                MessageBox.Show("Does not match password field!", "Fail"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                return true;
            }
            return false;
        }
        private void FormAddEmployee_Load(object sender, EventArgs e)
        {
            this.closePanelSet();
            buttonSetInfor_Click(null, null);
            this.comboBoxPos.DataSource = this.ctrManager.getDataPosition();
            this.comboBoxPos.ValueMember = "name_position";
            if ((this.comboBoxPos.DataSource as DataTable).Rows.Count != 0)
            {
                this.comboBoxPos.SelectedIndex = 0;
            }
            this.textBoxID.Text = ctrManager.newID().ToString();
        }
        private void closePanelSet()
        {
            this.panelShowInfor.Visible = false;
            this.buttonSetInfor.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleDown;
            this.panelShowAccount.Visible = false;
            this.buttonSetAcc.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleDown;
        }
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Upload image";
            openFileDialog1.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)" +
                "|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap temp = new Bitmap(openFileDialog1.FileName);
                    this.pictureBoxAvatar.Image = new Bitmap(temp, new Size(100, 100));
                }
                catch (System.ArgumentException exp)
                {
                    MessageBox.Show(openFileDialog1.FileName + "\nPaint cannot read this file!!!");
                }
            }
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (!this.checkBoxShow.Checked)
            {
                this.textBoxPass.UseSystemPasswordChar = true;
                this.textBoxConfirm.UseSystemPasswordChar = true;
            }
            else
            {
                this.textBoxPass.UseSystemPasswordChar = false;
                this.textBoxConfirm.UseSystemPasswordChar = false;
            }
        }

        private void buttonChangeID_Click(object sender, EventArgs e)
        {
            this.textBoxID.Text = this.ctrManager.newID().ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.isValid())
            {
                int id = int.Parse(this.textBoxID.Text);
                string name_pos = this.comboBoxPos.SelectedValue.ToString().Trim();
                string fname = this.textBoxFname.Text.Trim().ToUpper();
                string lname = this.textBoxLname.Text.Trim().ToUpper();
                bool gender = (this.radioMale.Checked == true);
                DateTime dob = this.dateDOB.Value;
                string phone = this.textBoxAddress.Text.Trim().ToUpper();
                string address = this.textBoxAddress.Text.Trim().ToUpper();
                Image pic = new Bitmap(this.pictureBoxAvatar.Image, new Size(100, 100));
                Employee employ = new Employee( id, fname, lname,name_pos, gender, dob, phone, address, pic);
                string username = this.textBoxUser.Text.Trim();
                string password = this.textBoxPass.Text.Trim();
                Account account = new Account(id,username, password);
                if (ctrManager.appendEmployee(employ) &&
                ctrAccount.appendAccount(account))
                {
                    MessageBox.Show("OK");
                }
                else
                {
                    MessageBox.Show("Something can not be empty", "Fail"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void clearTextBox()
        {
            this.comboBoxPos.SelectedIndex = 0;
            buttonChangeID_Click(null, null);
            this.textBoxFname.Text = "";
            this.textBoxLname.Text = "";
            this.radioMale.Checked = true;
            this.dateDOB.Value = new DateTime(2001, 1, 1);
            this.textBoxPhone.Text = "";
            this.textBoxAddress.Text = "";
            this.textBoxUser.Text = "";
            this.textBoxPass.Text = "";
            this.textBoxConfirm.Text = "";
            this.pictureBoxAvatar.Image = null;
            this.pictureBoxAvatar.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }
        private void buttonSetInfor_Click(object sender, EventArgs e)
        {
            if (this.panelShowInfor.Visible == false)
            {
                this.closePanelSet();
                this.panelShowInfor.Visible = true;
                this.buttonSetInfor.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleUp;
            }
            else
            {
                this.panelShowInfor.Visible = false;
                this.buttonSetInfor.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleDown;
            }
        }

        private void buttonSetAcc_Click(object sender, EventArgs e)
        {
            if (this.panelShowAccount.Visible == false)
            {
                this.closePanelSet();
                this.panelShowAccount.Visible = true;
                this.buttonSetAcc.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleUp;
            }
            else
            {
                this.panelShowAccount.Visible = false;
                this.buttonSetAcc.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleDown;
            }
        }
    }
}
