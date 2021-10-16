using Management_Hotel.Control.ControlReceptionist;
using Management_Hotel.Model;
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

namespace Management_Hotel.View.ViewReceptionist.CtrUser
{
    public partial class ControlOrderRoom : UserControl
    {
        public ControlOrderRoom()
        {
            InitializeComponent();
            this.ctrRoom = new CtrCRUDRoom();
            this.ctrOrder = new CtrOrderRoom();
        }
        public Room room { get; set; }
        private string status;
        CtrCRUDRoom ctrRoom;
        CtrOrderRoom ctrOrder;
        public FormOrderRoom formParent;
        public void setRoom (Room room)
        {
            this.room = room;
            this.buttonOrder.Text = room.id_phong;
            this.status = ctrRoom.get_state_room(room.id_phong);
            if (this.status == "Open")
            {
                open_load();
            }
            else
            {
                closed_load();
            }
        }
        public void open_load()
        {
            this.buttonOrder.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.buttonOrder.BackColor = Color.Red;
        }
        public void closed_load()
        {
            this.buttonOrder.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.buttonOrder.BackColor = Color.DimGray;
        }
        public void open_click()
        {
            FormOptionOpenRoom form = new FormOptionOpenRoom();
            form.order = this.ctrOrder.getOrderByIdRoom(room.id_phong);
            form.formParent = this.formParent;
            form.ShowDialog();
        }
        public void close_click()
        {
            FormOptionCloseRoom form = new FormOptionCloseRoom();
            form.room = this.room;
            form.formParent = this.formParent;
            form.ShowDialog();
            form.formParent.reset();
        }
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if (this.status == "Open")
            {
                open_click();
            }
            else
            {
                close_click();
            }
        }
    }
}
