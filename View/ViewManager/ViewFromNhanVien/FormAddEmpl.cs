using Management_Hotel.Control;
using Management_Hotel.Control_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Hotel.View.ViewManager
{
    public partial class FormAddEmpl : Form
    {
        public FormAddEmpl()
        {
            InitializeComponent();
            init();
        }
        

        void init()
        {
            this.ComboChucVu.Items.Add("Tiep Tan");
            this.ComboChucVu.Items.Add("Quan Ly");
            this.ComboChucVu.SelectedIndex = 0;
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }


  
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Management Hotel",
   MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            try
            {
                string Ho = this.textBoxHo.Text;
                string ten = this.textBoxTen.Text;
                DateTime ngaySinh = this.dateNgaySinh.Value;
                string sdt = this.textboxPhone.Text;
                string gioiTinh = (this.radioMale.Checked == true) ? "Nam" : "Nu";
                Image img = this.pictureGuest.Image;
                float Luong = float.Parse(this.textBoxLuong.Text);
                String chucVu = (this.ComboChucVu.SelectedIndex==0)?"TiepTan":"QuanLy";
                if (NhanVienDAO.NhanVien_add_proc(Ho, ten, ngaySinh, sdt, gioiTinh, img, Luong, chucVu,null))
                {
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
                MessageBox.Show
                       ("Fail format!",
                       "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
