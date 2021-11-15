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

namespace Management_Hotel.View.ViewReceptionist.ViewFormOrder
{
    public partial class FormSwapRoom : Form
    {
        public FormSwapRoom()
        {
            InitializeComponent();
            init();
        }
        int id_datPhong;
        public void init()
        {
            DataTable data = PhongDAO.Phong_Available_view();
            comboBoxRoom.DataSource = data;
            comboBoxRoom.ValueMember = "ID_Phong";
            comboBoxRoom.DisplayMember = "TenPhong";
            comboBoxRoom.SelectedIndex = -1;

        }
        public void fillData(int id_datPhong)
        {
            this.id_datPhong = id_datPhong;
            DataTable data = DatPhongDAO.DatPhong_search_func(id_datPhong);
            if (data.Rows.Count == 0) return;
            int id_phong = int.Parse(data.Rows[0][3].ToString());
            //ID_Phong,TenPhong,Vitri,Photo,Gia,TrangThai
            DataTable data_old = PhongDAO.Phong_searchByID_func(id_phong);
            string ten = data_old.Rows[0][1].ToString();
            String vitri = data_old.Rows[0][2].ToString();
            Image img = GlobalUser.CvtToImg((byte[])data_old.Rows[0][3]);
            String gia = data_old.Rows[0][4].ToString();

            this.labelIDOld.Text = id_phong.ToString();
            this.labelTenOld.Text = ten;
            this.labelViTriOld.Text = vitri;
            this.labelGiaOld.Text = gia;
            this.pictureOld.Image = img;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
        public void fillDataNew(int id_Phong)
        {
            this.id_datPhong = id_Phong;
            DataTable data = PhongDAO.Phong_searchByID_func(id_Phong);
            if (data.Rows.Count == 0) return;
            //ID_Phong,TenPhong,Vitri,Photo,Gia,TrangThai
            DataTable data_old = PhongDAO.Phong_searchByID_func(id_Phong);
            string ten = data_old.Rows[0][1].ToString();
            String vitri = data_old.Rows[0][2].ToString();
            Image img = GlobalUser.CvtToImg((byte[])data_old.Rows[0][3]);
            String gia = data_old.Rows[0][4].ToString();

            this.labelTenNew.Text = ten;
            this.labelViTriNew.Text = vitri;
            this.labelGiaNew.Text = gia;
            this.pictureNew.Image = img;
        }
        private void comboBoxRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = this.comboBoxRoom.SelectedIndex;
            if (i == -1) return;
            try
            {
                int id = int.Parse(this.comboBoxRoom.SelectedValue.ToString());
                fillDataNew(id);

            }
            catch (FormatException)
            {
                return;
            }
        }

        private void buttonSwap_Click(object sender, EventArgs e)
        {
            if (this.comboBoxRoom.SelectedIndex == -1)
            {
                MessageBox.Show
                      ("Please select employee!",
                      "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show
("Do you want to save", "Management Hotel",
MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            try
            {
                int idp = int.Parse(this.comboBoxRoom.SelectedValue.ToString());
                if (DatPhongDAO.DatPhong_doiPhong_proc(this.id_datPhong,idp,null))
                {
                    MessageBox.Show("Swap success", "Management Hotel",
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
                MessageBox.Show
                       ("Swap fail!",
                       "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
