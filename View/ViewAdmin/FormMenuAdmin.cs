using Management_Hotel.View.ViewManager;
using Management_Hotel.View.ViewManager.ViewFormAccount;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Hotel.View.ViewAdmin
{
    public partial class FormMenuAdmin : Form
    {
        public FormMenuAdmin()
        {
            InitializeComponent();
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
            foreach (Object btn in this.panelOption.Controls)
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


        private void buttonAccount_Click(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonAccount);
            FormCRUDAccount form = new FormCRUDAccount();
            openChildForm(form);
        }

        private void buttonEmployeeOption_Click(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonEmployeeOption);
            FormCRUDEmployee form = new FormCRUDEmployee();
            openChildForm(form);
        }
    }
}
