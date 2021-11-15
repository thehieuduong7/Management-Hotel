using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Management_Hotel.Control;
using Management_Hotel.Control_DAO;
using Management_Hotel.Model;

namespace Management_Hotel.View.ViewManager
{
    public partial class FormEditEmployee : Form
    {
        public FormEditEmployee()
        {
            InitializeComponent();
            init();
        }
        void init()
        {
            this.ComboChucVu.Items.Add("Tiep Tan");
            this.ComboChucVu.Items.Add("Quan Ly");
        }
        int id_nv;

        public void fillData(int id_nv)
        {
            //ID_NV,Ho,Ten,NgaySinh,SDT,GioiTinh,Avatar,Luong,ChucVu
            this.id_nv = id_nv;
            DataTable data = NhanVienDAO.NhanVien_searchByID_func(id_nv);
            if (data.Rows.Count == 0) return;
            DataRow row = data.Rows[0];
            string ho = row[1].ToString().Trim();
            string ten = row[2].ToString().Trim();
            DateTime ngaySinh = DateTime.Parse(row[3].ToString());
            string sdt = row[4].ToString().Trim();
            string gioiTinh = row[5].ToString().Trim();
            Image img = GlobalUser.CvtToImg((byte[])row[6]);
            String luong = row[7].ToString().Trim();
            String ChucVu = row[8].ToString().Trim();

            this.labelID.Text = id_nv.ToString();
            this.textBoxHo.Text = ho;
            this.textBoxTen.Text = ten;
            this.dateNgaySinh.Value = ngaySinh;
            this.textboxPhone.Text = sdt;
            if (gioiTinh == "Nam")
                this.radioMale.Checked = true;
            else
                this.radioFemale.Checked = true;
            if (img != null)
                this.pictureGuest.Image = img;
            this.textBoxLuong.Text = luong;
            if(ChucVu=="Tiep Tan")
            {
                ComboChucVu.SelectedIndex = 0;
            }
            else
            {
                ComboChucVu.SelectedIndex = 1;
            }
        }
        private void buttonUpload_Click_1(object sender, EventArgs e)
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

        private void buttonCancel_Click(object sender, EventArgs e)
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
                int id = this.id_nv;
                string Ho = this.textBoxHo.Text;
                string ten = this.textBoxTen.Text;
                DateTime ngaySinh = this.dateNgaySinh.Value;
                string sdt = this.textboxPhone.Text;
                string gioiTinh = (this.radioMale.Checked == true) ? "Nam" : "Nu";
                Image img = this.pictureGuest.Image;
                float Luong = float.Parse(this.textBoxLuong.Text);
                String ChucVu = (ComboChucVu.SelectedIndex == 0) ? "ChucVu" : "QuanLy";
                if (NhanVienDAO.NhanVien_upd_full_proc(id, Ho, ten, ngaySinh, sdt, gioiTinh, img,Luong,ChucVu, null))
                {
                    MessageBox.Show("Update success", "Management Hotel",
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
                MessageBox.Show("Update fail", "Management Hotel",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
