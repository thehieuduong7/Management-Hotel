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
    public partial class FormAddRoom : Form
    {
        public FormAddRoom()
        {
            InitializeComponent();
            formLoad();
        }
        CtrCRUDRoom ctrRoom;
        FormCRUDRoom formParent;
        public void setParent(FormCRUDRoom formParent)
        {
            this.formParent = formParent;
        }
        private void formLoad()
        {
            ctrRoom = new CtrCRUDRoom();
            this.numbericGiuong.Maximum = 5;
            this.numbericGiuong.Minimum = 1;
            this.pictureCheckID.Visible = false;
        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {
            if (ctrRoom.isExistingID(this.textBoxID.Text.Trim()))
            {
                this.pictureCheckID.IconChar = FontAwesome.Sharp.IconChar.Times;
                this.pictureCheckID.ForeColor = Color.Red;
            }
            else
            {
                this.pictureCheckID.IconChar = FontAwesome.Sharp.IconChar.Check;
                this.pictureCheckID.ForeColor = Color.Green;
            }
            if(this.pictureCheckID.Visible == false) { this.pictureCheckID.Visible = true; }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Management Hotel",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            try
            {
                string id = this.textBoxID.Text;
                string loai = this.textBoxLoai.Text;
                int so_giuong = (int)this.numbericGiuong.Value;
                string viTri = this.textBoxVitri.Text;
                float gia = float.Parse(this.textboxGia.Text);
                Room room = new Room(id, loai, so_giuong, viTri, gia);
                if (ctrRoom.insertRoom(room))
                {
                    MessageBox.Show("Success", "Management Hotel",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
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
        /// move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private void FormAddRoom_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message msg = Message.Create(Handle, WM_NCLBUTTONDOWN, (IntPtr)HT_CAPTION, IntPtr.Zero);
            base.WndProc(ref msg);
        }
    }
}
