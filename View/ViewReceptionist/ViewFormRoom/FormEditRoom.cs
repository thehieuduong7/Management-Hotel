using Management_Hotel.Control_DAO;
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
        int id_phong;
        public FormEditRoom()
        {
            InitializeComponent();

            if (GlobalUser.nhanVien == null) return;
            if (GlobalUser.nhanVien.ChucVu == "TiepTan")
            {
                this.textboxGia.ReadOnly = true;
            }
            else
            {
                this.textboxGia.ReadOnly = false;
            }
            
        }

        public void fillData(int id_phong)
        {
            this.id_phong = id_phong;
            DataTable data = PhongDAO.Phong_searchByID_func(this.id_phong);
            this.textBoxID.Text = data.Rows[0][0].ToString().Trim();
            this.textBoxTenPhong.Text = data.Rows[0][1].ToString().Trim();
            this.textBoxVitri.Text = data.Rows[0][2].ToString().Trim();
            if (data.Rows[0][3] != null)
            {
                this.pictureGuest.Image = GlobalUser.CvtToImg((byte[])data.Rows[0][3]);
            }
            this.textboxGia.Text = data.Rows[0][4].ToString().Trim();
      
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
                int id = int.Parse(this.textBoxID.Text);
                string tenPhong = this.textBoxTenPhong.Text.Trim();
                string viTri = this.textBoxVitri.Text.Trim();
                float gia = float.Parse(this.textboxGia.Text);
                
                Image photo = this.pictureGuest.Image;
                if (GlobalUser.nhanVien == null) //return;

               // if (GlobalUser.nhanVien.ChucVu == "TiepTan")
                {
                    if (PhongDAO.Phong_upd_sort_proc(id, tenPhong, viTri, photo,null))
                    {
                        MessageBox.Show("Update succes", "Management Hotel",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                else
                {
                    if (PhongDAO.Phong_upd_full_proc(id, tenPhong, viTri, photo, gia,null))
                    {
                        MessageBox.Show("Update success", "Management Hotel",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.Yes;
                        this.Close();
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Update fail", "Management Hotel",
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
