using FontAwesome.Sharp;
using Management_Hotel.Model;
using Management_Hotel.View.ViewLabourer;
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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            timer1.Start();
        }
        Employee user;
        Form current;
        public void setMode(Employee employee)
        {
            this.user = employee;
            picAvatar.Image = employee.picture;
            this.labelName.Text = String.Format("{0}({1}) ", employee.fname.ToUpper(),
                employee.name_position.ToLower());

            if (employee.name_position == "Manager")
            {
                FormMenuManager form = new FormMenuManager();
                showChildForm(form);
            }else if(employee.name_position == "Labourer")
            {
                FormMenuLabourer form = new FormMenuLabourer();
                form.employee = employee;
                showChildForm(form);
            }else if (employee.name_position == "Receptionist")
            {
                FormMenuReceptionist form = new FormMenuReceptionist();
                form.employee = employee;
                showChildForm(form);
            }
        }
        private void showChildForm(Form form)
        {
            this.panelShow.Controls.Clear();
            if (this.current != null) { this.current.Dispose(); }
            form.TopLevel = false;
            this.panelShow.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Visible = true;
            this.current = form;
        }
        private void pictureBoxLogo_MouseMove(object sender, MouseEventArgs e)
        {
            IconPictureBox i = (IconPictureBox)sender;
            i.ForeColor = Color.White;
        }
        private void button_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.White;
        }
        private void buttonLogout_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.Silver;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;    //exit
            this.Close();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK; // logout
            this.Close();
        }

        private void pictureBoxLogo_MouseLeave(object sender, EventArgs e)
        {
            IconPictureBox i = (IconPictureBox)sender;
            i.ForeColor = Color.Silver;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.labelMess.Location.X > -13)
            {
                this.labelMess.Location = new Point
                    (this.labelMess.Location.X - 1, this.labelMess.Location.Y);
            }
            else
            {
                this.labelMess.Location = new Point
                    (735, this.labelMess.Location.Y);
            }
        }
    }
}
