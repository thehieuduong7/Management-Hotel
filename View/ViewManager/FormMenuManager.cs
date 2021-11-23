using Management_Hotel.View.ViewAdmin.ViewFormReport;
using Management_Hotel.View.ViewManager.ViewFormAccount;
using Management_Hotel.View.ViewReceptionist;
using Management_Hotel.View.ViewReceptionist.ViewFormOrder;
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
    public partial class FormMenuManager : Form
    {
        public FormMenuManager()
        {
            InitializeComponent();
        }
        private void FormMenuManager_Load(object sender, EventArgs e)
        {
        }

        DataTable format(DataTable data)
        {
            foreach(DataRow row in data.Rows)
            {
            }
            return null;
        }
        private void openChildForm(Form form)
        {
            this.panelShow.Controls.Clear();
            form.TopLevel = false;
            this.panelShow.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Visible = true;
        }

  



        private void resetColorButtonOption()
        {
            foreach(Object btn in this.panelOption.Controls)
            {
                Button button;
                try
                {
                    button = (Button)btn;
                }
                catch (InvalidCastException) { continue; }
                if (button != null)
                {
                    button.BackColor = Color.FromArgb(255, 192, 192);
                    button.ForeColor = Color.Brown;
                }
            }
        }
        private void selectButtonOption(Button btn)
        {
            resetColorButtonOption();
            btn.BackColor = Color.FromArgb(255, 128, 128);
            btn.ForeColor = Color.FromArgb(255, 224, 192);
        }

        private void buttonReportOption_Click(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonReportOption);
        }


        private void buttonRoom_Click(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonRoom);
            FormCRUDRoom form = new FormCRUDRoom();
            openChildForm(form);
        }

        private void buttonFood_Click(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonFood);
            FormCRUDFood form = new FormCRUDFood();
            openChildForm(form);
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonGuest);
            FormCRUDGuest form = new FormCRUDGuest();
            openChildForm(form);
        }

        private void buttonOrderRoom_Click(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonOrderRoom);
            FormOrderRoom form = new FormOrderRoom();
            openChildForm(form);
        }

        private void buttonEmployeeOption_Click_1(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonEmployeeOption);
            FormCRUDEmployee form = new FormCRUDEmployee();
            openChildForm(form);
        }


        private void buttonReportOption_Click_1(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonReportOption);
            Form form = new FormReport();
            openChildForm(form);
        }
    }
}
