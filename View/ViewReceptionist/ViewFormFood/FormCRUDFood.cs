using Management_Hotel.Control.ControlReceptionist;
using Management_Hotel.Model;
using Management_Hotel.View.ViewReceptionist.CtrUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Hotel.View.ViewReceptionist.ViewFormOrder
{
    public partial class FormCRUDFood : Form
    {
        public FormCRUDFood()
        {
            InitializeComponent();
            ctrFood = new CtrCRUDFood();
            fillDataRoom(ctrFood.getDataFood());
        }
        CtrCRUDFood ctrFood;
        public void reset()
        {
            fillDataRoom(ctrFood.getDataFood());
        }
        private void fillDataRoom(DataTable data)
        {
            if (data == null) return;
            Panel panel = new Panel();
            this.panelShow.Controls.Clear();
            for (int i = 0; i < data.Rows.Count+1; i++)
            {
                if (i % 6 == 0)
                {
                    panel = new Panel();
                    this.panelShow.Controls.Add(panel);
                    panel.Dock = DockStyle.Top;
                    panel.Height = 155;
                    panel.BringToFront();
                }
                if (i == data.Rows.Count)
                {
                    ControlAddFood control = new ControlAddFood();
                    control.formParent = this;
                    panel.Controls.Add(control);
                    control.Dock = DockStyle.Left;
                    control.BringToFront();
                }
                else
                { 
                    Food food = new Food(data.Rows[i].ItemArray);
                    ControlCRUDFood control = new ControlCRUDFood();
                    control.formParent = this;
                    control.setFood(food);
                    panel.Controls.Add(control);
                    control.Dock = DockStyle.Left;
                    control.BringToFront();
                }
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable data = ctrFood.getDataFood();
            string search = this.textBoxSearch.Text.Trim();
            data.DefaultView.RowFilter = string.Format("name_food like '{0}%'", search);
            fillDataRoom(data.DefaultView.ToTable());
        }
    }
}
