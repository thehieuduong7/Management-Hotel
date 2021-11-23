using Management_Hotel.Control_DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Management_Hotel.View.ViewManager.ViewFormAccount
{
    public partial class FormCRUDAccount : Form
    {
        public FormCRUDAccount()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            DataTable data = AccountNVDAO.AccountNV_detail_view();
            fillData(data);
        }
        public void fillData(DataTable data)
        {
            // Username,Password,ID_NV,TenNV,ChucVU
            this.dataGridViewGuest.DataSource = data;
            this.dataGridViewGuest.AllowUserToAddRows = false;
            this.dataGridViewGuest.RowTemplate.Height = 100;
            int[] colWidth = {160,120,60,160,170};
            string[] colName = { "Username","Password","ID Nhan Vien","Ten Nhan Vien","Chuc Vu" };
            
            this.dataGridViewGuest.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewGuest.ReadOnly = true;
            this.dataGridViewGuest.ClearSelection();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddAccount form = new FormAddAccount();
            if (form.ShowDialog() == DialogResult.OK)
            {
                init();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            init();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewGuest.SelectedRows.Count == 0)
            {
                MessageBox.Show
                      ("Please select employee!",
                      "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            String user = this.dataGridViewGuest.SelectedRows[0].Cells[0].Value.ToString().Trim();
            String pass = this.dataGridViewGuest.SelectedRows[0].Cells[1].Value.ToString().Trim();

            FormEditAccount form = new FormEditAccount();
            form.fillData(user, pass);
            if (form.ShowDialog() == DialogResult.OK)
            {
                init();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (this.dataGridViewGuest.SelectedRows.Count == 0)
            {
                MessageBox.Show
                      ("Please select employee!",
                      "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Are you sure?", "Management Hotel",
              MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            String username = this.dataGridViewGuest.SelectedRows[0].Cells[0].Value.ToString().Trim();
            try
            {

                if (AccountNVDAO.AccountNV_del_proc(username, null))
                {
                    MessageBox.Show("Remove success", "Management Hotel",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void dataGridViewGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            string name = this.dataGridViewGuest.Rows[e.RowIndex].Cells[3].Value.ToString().Trim();
            string username = this.dataGridViewGuest.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            this.labelTen.Text = name;
            this.labelUsername.Text = username;
            this.username = username;
            // ID_PhanQuyen,Username,ID_nv,ChucVu,TenQuyen
            DataTable data = PhanQuyenDAO.PhanQuyen_seachByIDNV_func(username);
            updateQuyen(data);
        }
        string username;

        bool isUpdating = false;

        public bool updateQuyen(DataTable data)
        {
            this.isUpdating = true;
            this.radioButton_KhachHangNo.Checked = true;
            this.radioButton_NhanVienNo.Checked = true;
            this.radioButton_AccountNo.Checked = true;
            this.radioButton_PhongNo.Checked = true;
            this.radioButton_DatPNo.Checked = true;
            this.radioButton_KhoNo.Checked = true;
            this.radioButton_DatMonNo.Checked = true;
            this.radioButton_NhapKhoNo.Checked = true;
            this.radioButton_ThanhToanNo.Checked = true;


            foreach(DataRow row in data.Rows)
            {
                string tenQuyen = row[4].ToString().Trim();
                switch(tenQuyen)
                {
                    case "PhanQuyen_excute_KhachHang":
                        this.radioButton_KhachHangYes.Checked = true;
                        break;
                    case "PhanQuyen_excute_NhanVien":
                        this.radioButton_NhanVienYes.Checked = true;
                        break;
                    case "PhanQuyen_excute_AccountNV":
                        this.radioButton_AccountYes.Checked = true;
                        break;
                    case "PhanQuyen_excute_Phong":
                        this.radioButton_PhongYes.Checked = true;
                        break;
                    case "PhanQuyen_excute_DatPhong":
                        this.radioButton_DatPYes.Checked = true;
                        break;
                    case "PhanQuyen_excute_Kho":
                        this.radioButton_KhoYes.Checked = true;
                        break;
                    case "PhanQuyen_excute_DatMon":
                        this.radioButton_DatMonYes.Checked = true;
                        break;
                    case "PhanQuyen_excute_NhapKho":
                        this.radioButton_NhapKhoYes.Checked = true;
                        break;
                    case "PhanQuyen_excute_ThanhToan":
                        this.radioButton_ThanhToanYes.Checked = true;
                        break;
                }

            }
            this.isUpdating = false;

            return true;
        }
        //   string[] ListtenQuyen =["PhanQuyen_excute_KhachHang", "PhanQuyen_excute_NhanVien",
        // "PhanQuyen_excute_AccountNV", "PhanQuyen_excute_Phong", "PhanQuyen_excute_Kho",
        //  "PhanQuyen_excute_DatPhong", "PhanQuyen_excute_DatMon", "PhanQuyen_excute_ThanhToan",
        // "PhanQuyen_excute_NhapKho"];
        private void radioButton_KhachHangYes_CheckedChanged(object sender, EventArgs e)
        {

            if (this.isUpdating) return;
            if (this.username == null)
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
            if (this.radioButton_KhachHangYes.Checked == true)
            {
                if (PhanQuyenDAO.PhanQuyen_add_proc(this.username,"PhanQuyen_excute_KhachHang",null))
                {
                    MessageBox.Show("Update success", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update fail", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataTable data = PhanQuyenDAO.PhanQuyen_seachByIDNV_func(username);
                    updateQuyen(data);
                }

            }
            else
            {
                if (PhanQuyenDAO.PhanQuyen_del_proc(this.username, "PhanQuyen_excute_KhachHang", null))
                {
                    MessageBox.Show("Update success", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update fail", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataTable data = PhanQuyenDAO.PhanQuyen_seachByIDNV_func(username);
                    updateQuyen(data);
                }
            }


        }

        private void radioButton_KhachHangNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_NhanVienYes_CheckedChanged(object sender, EventArgs e)
        {

            if (this.isUpdating) return;
            if (this.username == null)
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
            if (this.radioButton_NhanVienYes.Checked == true)
            {
                if (PhanQuyenDAO.PhanQuyen_add_proc(this.username, "PhanQuyen_excute_NhanVien", null))
                {
                    MessageBox.Show("Update success", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update fail", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.radioButton_AccountNo.Checked = true;
                    DataTable data = PhanQuyenDAO.PhanQuyen_seachByIDNV_func(username);
                    updateQuyen(data);
                }

            }
            else
            {
                if (PhanQuyenDAO.PhanQuyen_del_proc(this.username, "PhanQuyen_excute_NhanVien", null))
                {
                    MessageBox.Show("Update success", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update fail", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.radioButton_AccountYes.Checked = true;
                    DataTable data = PhanQuyenDAO.PhanQuyen_seachByIDNV_func(username);
                    updateQuyen(data);
                }
            }
        }

        private void radioButton_NhanVienNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_AccountYes_CheckedChanged(object sender, EventArgs e)
        {

            if (this.isUpdating) return;
            if (this.username == null)
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
            if (this.radioButton_AccountYes.Checked == true)
            {
                if (PhanQuyenDAO.PhanQuyen_add_proc(this.username, "PhanQuyen_excute_AccountNV", null))
                {
                    MessageBox.Show("Update success", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update fail", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataTable data = PhanQuyenDAO.PhanQuyen_seachByIDNV_func(username);
                    updateQuyen(data);
                }

            }
            else
            {
                if (PhanQuyenDAO.PhanQuyen_del_proc(this.username, "PhanQuyen_excute_AccountNV", null))
                {
                    MessageBox.Show("Update success", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update fail", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataTable data = PhanQuyenDAO.PhanQuyen_seachByIDNV_func(username);
                    updateQuyen(data);
                }
            }
        }

        private void radioButton_AccountNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_PhongYes_CheckedChanged(object sender, EventArgs e)
        {

            if (this.isUpdating) return;
            if (this.username == null)
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
            if (this.radioButton_PhongYes.Checked == true)
            {
                if (PhanQuyenDAO.PhanQuyen_add_proc(this.username, "PhanQuyen_excute_Phong", null))
                {
                    MessageBox.Show("Update success", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update fail", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataTable data = PhanQuyenDAO.PhanQuyen_seachByIDNV_func(username);
                    updateQuyen(data);
                }

            }
            else
            {
                if (PhanQuyenDAO.PhanQuyen_del_proc(this.username, "PhanQuyen_excute_Phong", null))
                {
                    MessageBox.Show("Update success", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update fail", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataTable data = PhanQuyenDAO.PhanQuyen_seachByIDNV_func(username);
                    updateQuyen(data);
                }
            }
        }

        private void radioButton_PhongNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_KhoYes_CheckedChanged(object sender, EventArgs e)
        {

            if (this.isUpdating) return;
            if (this.username == null)
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
            if (this.radioButton_KhoYes.Checked == true)
            {
                if (PhanQuyenDAO.PhanQuyen_add_proc(this.username, "PhanQuyen_excute_Kho", null))
                {
                    MessageBox.Show("Update success", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update fail", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataTable data = PhanQuyenDAO.PhanQuyen_seachByIDNV_func(username);
                    updateQuyen(data);
                }

            }
            else
            {
                if (PhanQuyenDAO.PhanQuyen_del_proc(this.username, "PhanQuyen_excute_Kho", null))
                {
                    MessageBox.Show("Update success", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update fail", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataTable data = PhanQuyenDAO.PhanQuyen_seachByIDNV_func(username);
                    updateQuyen(data);
                }
            }
        }

        private void radioButton_KhoNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_DatPYes_CheckedChanged(object sender, EventArgs e)
        {

            if (this.isUpdating) return;
            if (this.username == null)
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
            if (this.radioButton_DatPYes.Checked == true)
            {
                if (PhanQuyenDAO.PhanQuyen_add_proc(this.username, "PhanQuyen_excute_DatPhong", null))
                {
                    MessageBox.Show("Update success", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update fail", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataTable data = PhanQuyenDAO.PhanQuyen_seachByIDNV_func(username);
                    updateQuyen(data);
                }

            }
            else
            {
                if (PhanQuyenDAO.PhanQuyen_del_proc(this.username, "PhanQuyen_excute_DatPhong", null))
                {
                    MessageBox.Show("Update success", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update fail", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataTable data = PhanQuyenDAO.PhanQuyen_seachByIDNV_func(username);
                    updateQuyen(data);
                }
            }
        }

        private void radioButton_DatPNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_DatMonYes_CheckedChanged(object sender, EventArgs e)
        {

            if (this.isUpdating) return;
            if (this.username == null)
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
            if (this.radioButton_DatMonYes.Checked == true)
            {
                if (PhanQuyenDAO.PhanQuyen_add_proc(this.username, "PhanQuyen_excute_DatMon", null))
                {
                    MessageBox.Show("Update success", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update fail", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataTable data = PhanQuyenDAO.PhanQuyen_seachByIDNV_func(username);
                    updateQuyen(data);
                }

            }
            else
            {
                if (PhanQuyenDAO.PhanQuyen_del_proc(this.username, "PhanQuyen_excute_DatMon", null))
                {
                    MessageBox.Show("Update success", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update fail", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataTable data = PhanQuyenDAO.PhanQuyen_seachByIDNV_func(username);
                    updateQuyen(data);
                }
            }
        }

        private void radioButton_DatMonNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_ThanhToanYes_CheckedChanged(object sender, EventArgs e)
        {

            if (this.isUpdating) return;
            if (this.username == null)
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
            if (this.radioButton_ThanhToanYes.Checked == true)
            {
                if (PhanQuyenDAO.PhanQuyen_add_proc(this.username, "PhanQuyen_excute_ThanhToan", null))
                {
                    MessageBox.Show("Update success", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update fail", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataTable data = PhanQuyenDAO.PhanQuyen_seachByIDNV_func(username);
                    updateQuyen(data);
                }

            }
            else
            {
                if (PhanQuyenDAO.PhanQuyen_del_proc(this.username, "PhanQuyen_excute_ThanhToan", null))
                {
                    MessageBox.Show("Update success", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update fail", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataTable data = PhanQuyenDAO.PhanQuyen_seachByIDNV_func(username);
                    updateQuyen(data);
                }
            }
        }

        private void radioButton_ThanhToanNo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_NhapKhoYes_CheckedChanged(object sender, EventArgs e)
        {

            if (this.isUpdating) return;
            if (this.username == null)
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
            if (this.radioButton_NhapKhoYes.Checked == true)
            {
                if (PhanQuyenDAO.PhanQuyen_add_proc(this.username, "PhanQuyen_excute_NhapKho", null))
                {
                    MessageBox.Show("Update success", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update fail", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataTable data = PhanQuyenDAO.PhanQuyen_seachByIDNV_func(username);
                    updateQuyen(data);
                }

            }
            else
            {
                if (PhanQuyenDAO.PhanQuyen_del_proc(this.username, "PhanQuyen_excute_NhapKho", null))
                {
                    MessageBox.Show("Update success", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update fail", "Management Hotel",
MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataTable data = PhanQuyenDAO.PhanQuyen_seachByIDNV_func(username);
                    updateQuyen(data);
                }
            }
        }

        private void radioButton_NhapKhoNo_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
