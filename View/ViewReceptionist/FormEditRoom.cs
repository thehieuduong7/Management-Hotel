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

namespace Management_Hotel.View.ViewReceptionist
{
    public partial class FormEditRoom : Form
    {
        private CtrCRUDRoom ctrRoom;
        public FormEditRoom()
        {
            InitializeComponent();
            formLoad();
        }
        private void formLoad()
        {
            ctrRoom = new CtrCRUDRoom();
            this.numbericGiuong.Maximum = 5;
            this.numbericGiuong.Minimum = 1;
        }
        public void fillData(Room room)
        {
            this.textBoxID.Text = room.id_phong;
            this.textBoxLoai.Text = room.loai;
            this.numbericGiuong.Value = room.so_giuong;
            this.textBoxVitri.Text = room.vitri;
            this.textboxGia.Text = room.giaPhong.ToString();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "Management Hotel",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            try
            {
                string id = this.textBoxID.Text;
                string loai=this.textBoxLoai.Text;
                int so_giuong = (int)this.numbericGiuong.Value;
                string viTri=this.textBoxVitri.Text;
                float gia = float.Parse(this.textboxGia.Text);
                Room room = new Room(id, loai, so_giuong, viTri, gia);
                if (ctrRoom.updatetRoom(room))
                {
                    MessageBox.Show("Success", "Management Hotel",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
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


        //// move form 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message msg = Message.Create(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            base.WndProc(ref msg);
        }
    }
}
