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

namespace Management_Hotel.View.ViewLabourer
{
    public partial class FormMenuLabourer : Form
    {
        public FormMenuLabourer()
        {
            InitializeComponent();
        }
        public Employee employee { get; set; }
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
                    button.BackColor = Color.FromArgb(33, 33, 33);
                }
            }
        }
        private void selectButtonOption(Button btn)
        {
            resetColorButtonOption();
            btn.BackColor = Color.DimGray;
        }
        private void openChildForm(Form form)
        {
            this.panelShow.Controls.Clear();
            form.TopLevel = false;
            this.panelShow.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Visible = true;
        }
        private void buttonCheckInOut_Click(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonCheckInOut);
            FormCheckInCheckOut form = new FormCheckInCheckOut();
            form.employee = this.employee;
            openChildForm(form);
        }
        private void buttonInformation_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.White;
        }
        private void buttonInformation_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.Silver;
        }

    }
}
