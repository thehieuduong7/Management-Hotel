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
  
        public FormEditRoom()
        {
            InitializeComponent();
            formLoad();
        }

        public void fillData(PhongModel phong)
        {
            this.textBoxID.Text = phong.id_phong.ToString();
            this.textBoxLoai.Text = phong.tenPhong;
            this.textBoxVitri.Text = phong.ViTri;
            this.textboxGia.Text = phong.gia.ToString();
            if (phong.Photo != null)
            {
                this.pictureGuest.Image = phong.Photo;
            }
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
                string tenPhong=this.textBoxLoai.Text;
                string viTri=this.textBoxVitri.Text;
                float gia = float.Parse(this.textboxGia.Text);
                Image photo = this.pictureGuest.Image;
                PhongModel phong = new PhongModel(id, tenPhong, viTri, photo, gia );
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

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Upload image";
            openFileDialog1.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)" +
                "|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap temp = new Bitmap(openFileDialog1.FileName);
                    this.pictureGuest.Image = new Bitmap(temp, pictureGuest.Size);
                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show
                        (openFileDialog1.FileName + "\nPaint cannot read this file!!!",
                        "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
