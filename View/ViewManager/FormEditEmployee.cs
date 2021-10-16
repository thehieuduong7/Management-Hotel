using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Management_Hotel.Control;
using Management_Hotel.Control.ControlManager;
using Management_Hotel.Model;

namespace Management_Hotel.View.ViewManager
{
    public partial class FormEditEmployee : Form
    {
        public FormEditEmployee()
        {
            InitializeComponent();
            this.ctrEdit = new CtrManagerEditEmployee();
            this.ctrAccount = new CtrAccount();
            this.formAdd = new FormAddEmployee();
            addChildForm(this.formAdd);
            FormEditEmployee_Load(null, null);
            this.panelTotal_load();
        }
        CtrManagerEditEmployee ctrEdit;
        CtrAccount ctrAccount;
        private void FormEditEmployee_Load(object sender, EventArgs e)
        {
            this.closePanelSet();
            this.panelControlOption.Visible = false;
            this.comboBoxPos.DataSource = this.ctrEdit.getDataPosition();
            this.comboBoxPos.ValueMember = "name_position";
            this.dataGridViewEmployee.DataSource = this.ctrEdit.getDataEmployee();
            this.dataGridViewEmployee.RowTemplate.Height = 80;
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridView_load(true);
          
        }
        private void dataGridView_load(bool full_screen)
        {
            this.dataGridViewEmployee.Columns[0].HeaderText = "ID";
            this.dataGridViewEmployee.Columns[1].HeaderText = "First name";
            this.dataGridViewEmployee.Columns[2].HeaderText = "Last name";
            this.dataGridViewEmployee.Columns[3].HeaderText = "Position";
            this.dataGridViewEmployee.Columns[4].HeaderText = "Gender";
            this.dataGridViewEmployee.Columns[5].HeaderText = "DOB";
            this.dataGridViewEmployee.Columns[6].HeaderText = "Phone contact";
            this.dataGridViewEmployee.Columns[7].HeaderText = "Address";
            this.dataGridViewEmployee.Columns[8].HeaderText = "Picture";
            //this.dataGridViewEmployee.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)this.dataGridViewEmployee.Columns[8];
            pic.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            if (full_screen)
            {
                int[] lenWidth = { 40, 160, 160, 120, 100, 120, 120,120};
                for (int i = 0; i < lenWidth.Length; i++)
                {
                    this.dataGridViewEmployee.Columns[i].Width = lenWidth[i];
                }
                foreach (Label label in this.panelTotal.Controls)
                {
                    if (label != null)
                    {
                        label.Font = new Font(label.Font.Name, 12, label.Font.Style);
                    }
                }
            }
            else
            {
                int[] lenWidth = { 25, 60, 60, 60, 60, 80, 80,80};
                for (int i = 0; i < lenWidth.Length; i++)
                {
                    this.dataGridViewEmployee.Columns[i].Width = lenWidth[i];
                }
                foreach (Label label in this.panelTotal.Controls)
                {
                    if (label != null)
                    {
                        label.Font = new Font(label.Font.Name, 8, label.Font.Style);
                    }
                }
            }

        }
        private void panelTotal_load()
        {
            this.panelTotal.Controls.Clear();
            DataTable data = ctrEdit.getTotal();
            int count = 0;
            foreach (DataRow row in data.Rows)
            {
                Label label = new Label();
                this.panelTotal.Controls.Add(label);
                label.Text = "TOTAL " + row[0].ToString().Trim().ToUpper()+": "+row[1].ToString().Trim()+" PERSON";
                label.Font = new Font("Cooper Black", 12,FontStyle.Italic);
                label.Visible = true;
                label.Dock = DockStyle.Top ;
                label.ForeColor = Color.Red;
                label.Name = "total_" + count.ToString();
            }
        }
        private void fillData(int id)
        {
            Employee employee = this.ctrEdit.getEmployee(id);
            Account account = this.ctrAccount.getAccount(id);
            if (employee != null)
            {
                this.comboBoxPos.SelectedIndex = (employee.name_position == "Labourer") ? 0 :
                    (employee.name_position == "Manager") ? 1 : 2;
                this.textBoxID.Text = employee.id.ToString();
                this.textBoxFname.Text = employee.fname.ToString();
                this.textBoxLname.Text = employee.lname.ToString();
                if (employee.gender)
                {
                    this.radioMale.Checked = true;
                }
                else
                {
                    this.radioFemale.Checked = true;
                }
                this.dateDOB.Value = employee.dob;
                this.textBoxPhone.Text = employee.phone;
                this.textBoxAddress.Text = employee.address;
                this.pictureBoxAvatar.Image = employee.picture;
                if (account != null)
                {
                    this.textBoxUser.Text = account.username;
                    this.textBoxPass.Text = account.password;
                    this.textBoxConfirm.Text = account.password;
                }
            }
        }
        public void closeAllForm()
        {
            foreach (Form form in panelShow.Controls)
            {
                if (form != null)
                {
                    form.Visible = false;
                }
            }
        }
        private void addChildForm(Form form)
        {
            form.TopLevel = false;
            this.panelControl.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            formAdd.Visible = false;
        }
        private void closePanelSet()
        {
            this.panelShowInfor.Visible = false;
            this.buttonSetInfor.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleDown;
            this.panelShowAccount.Visible = false;
            this.buttonSetAcc.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleDown;
        }
        private void buttonFindID_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.textBoxID.Text);
                this.fillData(id);
            }
            catch (FormatException)
            {
                MessageBox.Show("Format ID not correct", "Fail"
        , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            }
            else if (this.textBoxPass.Text.Trim() != this.textBoxConfirm.Text.Trim())
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
        private void buttonEdit_Click(object sender, EventArgs e)
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
                Employee employ = new Employee(id, fname, lname, name_pos, gender, dob, phone, address, pic);
                string username = this.textBoxUser.Text.Trim();
                string password = this.textBoxPass.Text.Trim();
                Account account = new Account(id, username, password);
                if (ctrEdit.updateEmployee(employ) &&
                ctrAccount.updateAccount(account))
                {
                    MessageBox.Show("OK");
                    this.buttonRefresh_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Fail", "Fail"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dataGridViewGuest_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.dataGridViewEmployee.Rows[e.RowIndex].Selected = true;
            }
        }
        private void dataGridViewEmployee_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.dataGridViewEmployee.Rows[e.RowIndex].Selected = false;
            }
        }
        private void dataGridViewGuest_MouseLeave(object sender, EventArgs e)
        {
            this.dataGridViewEmployee.ClearSelection();
        }
        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView_load(false);
            if (e.RowIndex == -1) return;
            int id = int.Parse(this.dataGridViewEmployee.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.panelControlOption.Visible = true;
            this.buttonLeft.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft;
            if (buttonBackEdit.Visible == true)
            {
                buttonBackEdit_Click(null, null);
            }
            this.closePanelSet();
            this.panelShowInfor.Visible = true;
            this.buttonSetInfor.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleUp;
            this.fillData(id);
        }
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if(this.panelControlOption.Visible == false)
            {
                this.panelControlOption.Visible = true;
                this.buttonLeft.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft;
                this.dataGridView_load(false);
            }
            else
            {
                this.buttonLeft.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleRight;
                this.panelControlOption.Visible = false;
                this.dataGridView_load(true);
            }
        }

        private void buttonLeft_MouseLeave(object sender, EventArgs e)
        {
            this.buttonLeft.ForeColor = Color.DimGray;
        }

        private void buttonLeft_MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonLeft.ForeColor = Color.Red;
        }

        private void buttonSearch_MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonSearch.ForeColor = Color.Red;
        }

        private void buttonSearch_MouseLeave(object sender, EventArgs e)
        {
            this.buttonSearch.ForeColor = Color.Black ;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.textBoxID.Text);
                if (ctrEdit.removeEmployee(id))
                {
                    MessageBox.Show("Remove success!!!", "Success"
                , MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.buttonRefresh_Click(null, null);
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ID not found", "Fail"
           , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearTextBox()
        {
            this.comboBoxPos.SelectedIndex = 0;
            this.textBoxID.Text = "";
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
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.dataGridViewEmployee.DataSource = this.ctrEdit.getDataEmployee();
            this.clearTextBox();
            this.panelTotal_load();
            this.Visible = true;
        }
        FormAddEmployee formAdd;
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.panelSet.Visible = false;
            this.formAdd.Visible = true;
            this.buttonBackEdit.Visible = true;
            //this.buttonRefresh_Click(null,null);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable data = (DataTable)this.dataGridViewEmployee.DataSource;
            string search = this.textBoxSearch.Text.Trim();
            try
            {
                int id = int.Parse(search);
                data.DefaultView.RowFilter =
    string.Format("[id]={0}", id);
            }
            catch (FormatException)
            {
                data.DefaultView.RowFilter =
    string.Format("[First_name] like '%{0}%' OR [Last_name] like '%{0}%'", search);
            }
        }

        private void buttonBackEdit_Click(object sender, EventArgs e)
        {
            this.buttonBackEdit.Visible = false;
            this.formAdd.Visible = false;
            this.panelSet.Visible = true;
        }


    }
}
