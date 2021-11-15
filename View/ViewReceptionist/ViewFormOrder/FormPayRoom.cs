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
    public partial class FormPayRoom : Form
    {
        public FormPayRoom()
        {
            InitializeComponent();
        }
        int id_datPhong;
        public void fillData(int id_datPhong)
        {
            this.id_datPhong = id_datPhong;
            DataTable data_datPhong = DatPhongDAO.DatPhong_search_func(id_datPhong);
            //elect MaDat,ID_KH,TenKhachHang,ID_Phong," +
            // "TenPhong,GiaPhong,ID_NV,TenNVDat, NgayDat, TrangThai
            if (data_datPhong.Rows.Count == 0) return;
            String id_kh =data_datPhong.Rows[0][1].ToString().Trim();
            string name_kh = data_datPhong.Rows[0][2].ToString().Trim();
            String tenPhong = data_datPhong.Rows[0][4].ToString().Trim();
            String gia = data_datPhong.Rows[0][5].ToString().Trim();
            string trangThai = data_datPhong.Rows[0][9].ToString().Trim();

            this.label_id_guest.Text = id_kh;
            this.label_nameGuest.Text = name_kh;
            this.labeltenRoom.Text = tenPhong;
            this.labelPrice.Text = gia;
            this.labelTrangThai.Text = trangThai;

            DataTable data_totalMoney = DatPhongDAO.DatPhong_TongTienDatPhong_func(id_datPhong);
            if (data_totalMoney.Rows.Count == 0) return;
            string total_money = data_totalMoney.Rows[0][0].ToString();
            this.label_TotalmoneyRoom.Text = total_money;

            fillDataOrder(id_datPhong) ;

            DataTable data_moneyPAy = ThanhToanDAO.ThanhToan_TongTienPhong_func(id_datPhong);
            if (data_moneyPAy.Rows.Count == 0) return;
            string total_money_pay = data_moneyPAy.Rows[0][0].ToString();
            this.labelMoneyPay.Text = total_money_pay;

        }
        public void fillDataOrder(int id_datPhong)
        {

            DataTable data_order = DatMonDAO.DatMon_listDaDat_func(this.id_datPhong);
            //ID_DatMon,ID_Mon,TenMon,GiaBan,SoLuong,TongTien,ThoiGianDat            this.dataGridViewGuest.DataSource = data;
            this.dataGridViewFood.AllowUserToAddRows = false;
            this.dataGridViewFood.RowTemplate.Height = 100;
            int[] colWidth = { 60,60,160,100,60,160,160 };
            string[] colName = { "ID_DatMon", "ID_Mon", "TenMon", "GiaBan", "SoLuong", "TongTien", "ThoiGianDat" };

            this.dataGridViewFood.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFood.ReadOnly = true;
        }
    }
}
