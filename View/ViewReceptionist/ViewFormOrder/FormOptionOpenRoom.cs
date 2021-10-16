using Management_Hotel.Control.ControlReceptionist;
using Management_Hotel.Model;
using Management_Hotel.View.ViewReceptionist.ViewFormOrderFood;
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
    public partial class FormOptionOpenRoom : Form
    {
        CtrOrderRoom ctrOrder;
        public OrderRoom order { get; set; }
        public FormOrderRoom formParent { get; set; }
        public FormOptionOpenRoom()
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

        private void buttonOrderFood_Click(object sender, EventArgs e)
        {
            FormOrderFood form = new FormOrderFood();
            form.id_order = this.order.id_order;
            if (form.ShowDialog() == DialogResult.No)
            {
                return;
            }
            this.formParent.reset();

        }

        private void buttonSwapRoom_Click(object sender, EventArgs e)
        {
            FormSelectRoom form = new FormSelectRoom();
            if (form.ShowDialog() == DialogResult.No)
            {
                return;
            }
            Room room = FormSelectRoom.get_select_room();
            this.order.id_room = room.id_phong;
            if (ctrOrder.updatetRoom(this.order))
            {
                MessageBox.Show("Success", "Management Hotel",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.formParent.reset();
            }
            else
            {
                MessageBox.Show("Fail", "Management Hotel",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPayRoom_Click(object sender, EventArgs e)
        {
            FormPayRoom form = new FormPayRoom();
            form.setId_Order(this.order.id_order);
            if(form.ShowDialog() == DialogResult.No)
            {
                return;
            }
            else
            {
                this.formParent.reset();
            }
        }
    }
}
