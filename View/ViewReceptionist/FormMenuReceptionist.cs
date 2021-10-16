using Management_Hotel.Model;
using Management_Hotel.View.ViewLabourer;
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

namespace Management_Hotel.View.ViewReceptionist
{
    public partial class FormMenuReceptionist : Form
    {

        public FormMenuReceptionist()
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
        private void buttonRoom_Click(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonRoom);
            FormCRUDRoom form = new FormCRUDRoom();
            openChildForm(form);
        }

        private void buttonCheckInOut_Click(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonCheckInOut);
            FormCheckInCheckOut form = new FormCheckInCheckOut();
            form.employee = employee;
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

        private void buttonFood_Click(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonFood);
            FormCRUDFood form = new FormCRUDFood();
            openChildForm(form);
        }
    }
}
