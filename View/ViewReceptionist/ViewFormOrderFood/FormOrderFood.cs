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

namespace Management_Hotel.View.ViewReceptionist.ViewFormOrderFood
{
    public partial class FormOrderFood : Form
    {
        CtrCRUDFood ctrFood;
        CtrOrderFood ctrOrder;
        public string id_order { get; set; }
        public FormOrderFood()
        {
            InitializeComponent();
            this.ctrFood = new CtrCRUDFood();
            ctrOrder = new CtrOrderFood();
            form_load();
        }
        public void form_load()
        {
            this.dataGridViewFood.DataSource = this.ctrFood.getDataFoodAvailable();
            this.dataGridViewFood.AllowUserToAddRows = false;
            this.dataGridViewFood.RowTemplate.Height = 50;
            int[] colWidth = { 80, 120, 120, 120, 160 };
            string[] colName = { "ID food", "Picture", "Name food", "Stock", "Price" };
            for (int i = 0; i < colName.Length; i++)
            {
               this.dataGridViewFood.Columns[i].HeaderText = colName[i];
                this.dataGridViewFood.Columns[i].Width = colWidth[i];
            }
            this.dataGridViewFood.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFood.ReadOnly = true;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridViewGuest_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.dataGridViewFood.ClearSelection();
                this.dataGridViewFood.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dataGridViewGuest_MouseLeave(object sender, EventArgs e)
        {
            this.dataGridViewFood.ClearSelection();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable data = this.dataGridViewFood.DataSource as DataTable;
            string search = this.textBoxSearch.Text.Trim();
            data.DefaultView.RowFilter = string.Format("name_food like '%{0}%'", search);
        }

        private void dataGridViewFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable data = this.dataGridViewFood.DataSource as DataTable;
            Food food = new Food(data.Rows[e.RowIndex].ItemArray);
            foreach (ControlSelectFood ctr in this.panelSelect.Controls)
            {
                if (ctr.GetFood().id_food == food.id_food)
                {
                    ctr.buttonPlus_Click(null, null);
                    return;
                }
            }
            ControlSelectFood control = new ControlSelectFood();
            if (control.fillData(food) == false)
            {
                control.Dispose();
                return;
            }
            panelSelect.Controls.Add(control);
            control.Dock = DockStyle.Top;
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            bool ok = true;
            foreach (ControlSelectFood ctr in this.panelSelect.Controls)
            {
                string id_food = ctr.GetFood().id_food;
                DateTime day_order = DateTime.Now;
                int amount = ctr.getNum();
                OrderFood orderFood = new OrderFood(this.id_order, id_food, amount, day_order);
                if (!ctrOrder.insertOrderFood(orderFood))
                {
                    MessageBox.Show("Can not order " + id_food, "Management Hotel", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ok = false;
                }
            }
            if (ok == true)
            {
                MessageBox.Show("Success!", "Management Hotel",
           MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
