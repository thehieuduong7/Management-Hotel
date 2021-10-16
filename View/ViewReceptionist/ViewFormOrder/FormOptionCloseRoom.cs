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
    public partial class FormOptionCloseRoom : Form
    {
        CtrOrderRoom ctrOrder;
        public Room room { get; set; }
        public FormOrderRoom formParent { get; set; }
        public FormOptionCloseRoom()
        {
            InitializeComponent();
            this.ctrOrder = new CtrOrderRoom();
        }
  
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonCancel_MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonCancel.IconSize = 40;
        }

        private void buttonCancel_MouseLeave(object sender, EventArgs e)
        {
            this.buttonCancel.IconSize = 35;
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            FormSelectGuest form = new FormSelectGuest();
            if(form.ShowDialog()==DialogResult.No) return;
            Guest guest = FormSelectGuest.get_select_guest();
            DateTime day_order = DateTime.Now;
            string id_order = ctrOrder.hash_id_order(room.id_phong, guest.id_guest, day_order);
            OrderRoom order = new OrderRoom(id_order, room.id_phong, guest.id_guest, day_order, "Open");
            if (ctrOrder.insertRoom(order))
            {
                MessageBox.Show("Success", "Management Hotel",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Fail", "Management Hotel", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
