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
    public partial class FormEditGuest : Form
    {
        public FormEditGuest()
        {
            InitializeComponent();
        }
        int id_khachHang;

        public void fillData(int id_khachHang)
        {
            //ID_KH,Ho,Ten,NgaySinh,SDT,GioiTinh,Avatar
            this.id_khachHang = id_khachHang;
            DataTable data = KhachHangDAO.KhachHang_searchByID_func(id_khachHang);
            if (data.Rows.Count == 0) return;
            DataRow row = data.Rows[0];
            string ho = row[1].ToString().Trim();
            string ten = row[2].ToString().Trim();
            DateTime ngaySinh = DateTime.Parse(row[3].ToString());
            string sdt = row[4].ToString().Trim();
            string gioiTinh = row[5].ToString().Trim();
            Image img = GlobalUser.CvtToImg((byte[])row[6]);

            this.textBoxID.Text = id_khachHang.ToString();
            this.textBoxHo.Text = ho;
            this.textBoxTen.Text = ten;
           this.dateTimeNgaySinh.Value = ngaySinh;
            this.textboxPhone.Text = sdt;
            if (gioiTinh == "Nam")
                this.radioMale.Checked = true;
            else
                this.radioFemale.Checked = true;
            if (img != null)
                this.pictureGuest.Image = img;

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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Management Hotel",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            try
            {
                int id = this.id_khachHang;
                string Ho = this.textBoxHo.Text;
                string ten = this.textBoxTen.Text;
                DateTime ngaySinh = this.dateTimeNgaySinh.Value;
                string sdt = this.textboxPhone.Text;
                string gioiTinh = (this.radioMale.Checked == true) ? "Nam" : "Nu";
                Image img = this.pictureGuest.Image;
                if (KhachHangDAO.KhachHang_upd_proc(id,Ho, ten, ngaySinh, sdt, gioiTinh, img,null))
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

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Management Hotel",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            try
            {

                if (KhachHangDAO.KhachHang_del_proc(id_khachHang,null))
                {
                    MessageBox.Show("Remove success", "Management Hotel",
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
                MessageBox.Show("Remove fail", "Management Hotel",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
    
}
