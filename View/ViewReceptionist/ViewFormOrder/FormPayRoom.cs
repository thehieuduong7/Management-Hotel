using Management_Hotel.Control.ControlReceptionist;
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

namespace Management_Hotel.View.ViewReceptionist.ViewFormOrder
{
    public partial class FormPayRoom : Form
    {
        CtrOrderFood ctrOrderFood;
        CtrOrderRoom ctrOrderRoom;
        CtrCRUDRoom ctrRoom;
        CtrCRUDGuest ctrGuest;
        Room room;
        OrderRoom order;
        Guest guest;
        private string id_order;
        private float moneyTotalFood;
        private float moneyTotalRoom;

        public FormPayRoom()
        {
            InitializeComponent();
            this.ctrOrderFood = new CtrOrderFood();
            ctrOrderRoom = new CtrOrderRoom();
            ctrRoom = new CtrCRUDRoom();
            ctrGuest = new CtrCRUDGuest();
        }
        public void setId_Order(string id_order)
        {
            this.id_order = id_order;
            dataGrid_load();
            Information_load();
            this.labelMoneyPay.Text = (this.moneyTotalFood + this.moneyTotalRoom).ToString()+"d";
        }
        public void dataGrid_load()
        {
            this.dataGridViewFood.DataSource = ctrOrderFood.getOrderById(id_order);
            this.dataGridViewFood.AllowUserToAddRows = false;
            this.dataGridViewFood.RowTemplate.Height = 30;
            int[] colWidth = { 100, 80, 120, 80,160,120};
            string[] colName = { "ID food","Picture food","Name food","Amount","Day","Price" };
            for (int i = 0; i < colName.Length; i++)
            {
                this.dataGridViewFood.Columns[i].HeaderText = colName[i];
                this.dataGridViewFood.Columns[i].Width = colWidth[i];
            }
            this.dataGridViewFood.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFood.ReadOnly = true;

            //total
            this.moneyTotalFood=0;
            foreach(DataRow row in (dataGridViewFood.DataSource as DataTable).Rows)
            {
                moneyTotalFood = moneyTotalFood + 
                    float.Parse(row["price"].ToString())*int.Parse(row["amount"].ToString());
            }
            this.labelMoneyFood.Text = moneyTotalFood.ToString() + "d";
        }
        private void Information_load()
        {
            this.order = ctrOrderRoom.getOrderByIDOrder(id_order);
            this.room = ctrRoom.getRoomById(order.id_room);
            this.guest = ctrGuest.getGuestByID(order.id_guest);
            this.pictureGuest.Image = guest.picture;
            this.label_id_guest.Text = guest.id_guest.ToString();
            this.label_nameGuest.Text = guest.full_name;
            this.labelIDRoom.Text = room.id_phong;
            this.labelPrice.Text = room.giaPhong.ToString() + "d";
            this.label_Daystart.Text = order.day_order.ToString("MM/dd/yyyy hh:mm:ss");
            this.label_dayEnd.Text = DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss");
            TimeSpan time_total = DateTime.Now.Subtract(order.day_order);
            this.label_dayTotal.Text = time_total.ToString(@"dd\:hh\:mm\:ss");
            this.moneyTotalRoom = room.giaPhong * (time_total.Days+1);
            this.label_moneyRoom.Text = moneyTotalRoom.ToString()+"d";
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
        private void dataGridViewFood_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.dataGridViewFood.ClearSelection();
                this.dataGridViewFood.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dataGridViewFood_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.dataGridViewFood.ClearSelection();
                this.dataGridViewFood.Rows[e.RowIndex].Selected = false;
            }
        }

        private void buttonPay_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show
   ("Do you want to pay?", "Management Hotel",
   MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
            if(this.ctrOrderRoom.closeRoom(order.id_order))
            {
                MessageBox.Show
   ("Success!", "Management Hotel",
   MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Yes;
                this.Close();
            }
            else{
                MessageBox.Show
   ("Fail!", "Management Hotel",
   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
