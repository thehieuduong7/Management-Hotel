using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Management_Hotel.Control.ControlReceptionist;
using Management_Hotel.Model;
namespace Management_Hotel.View.ViewReceptionist.CtrUser
{
    public partial class ControlRoom : UserControl
    {
        public Room room { get; set; }
        private CtrCRUDRoom ctrRoom;
        public ControlRoom()
        {
            InitializeComponent();
            ctrRoom = new CtrCRUDRoom();
        }
        FormCRUDRoom formParent;
        public void setParent(FormCRUDRoom formParent)
        {
            this.formParent = formParent;
        }
        public void fillData(Room room)
        {
            this.room = room;
            this.buttonEdit.Text = room.giaPhong.ToString() + " đ";
            this.label_room.Text = room.id_phong;
            int x = this.Width / 2 - this.label_room.Width / 2;
            this.label_room.Location = new Point(x, this.label_room.Location.Y);
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormEditRoom form = new FormEditRoom();
            form.fillData(this.room);
            if (form.ShowDialog() == DialogResult.Yes) 
                this.formParent.reset();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to remove this door?", "Management Hotel",
    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            try
            {
                if (ctrRoom.removeRoom(this.room.id_phong))
                {
                    MessageBox.Show("Success", "Management Hotel",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.formParent.reset();
                    this.Dispose();
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Fail", "Management Hotel",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {

        }
    }
}
