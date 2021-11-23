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

namespace Management_Hotel.View.ViewManager.ViewFormReport
{
    public partial class FormReportThanhToan : Form
    {
        public FormReportThanhToan()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            //ID_ThanhToan,ID_DatPhong,TenKH," +
            //"TenPhong,TenNVTT,TongTien,ThoiGianThanhToan
            DataTable data = ThanhToanDAO.ThanhToan_detail_view();

            data.Columns.RemoveAt(1);

            this.dataGridViewGuest.DataSource = data;
            this.dataGridViewGuest.AllowUserToAddRows = false;
            this.dataGridViewGuest.RowTemplate.Height = 100;
            int[] colWidth = { 100, 100, 160, 80, 80,120 };
            string[] colName = { "ID nhap kho", "Ten khach hang", "Ten phong", "Nhan vien thanh toan","Tong tien", "Thoi gian nhap" };
            for (int i = 0; i < colName.Length; i++)
            {
              this.dataGridViewGuest.Columns[i].HeaderText = colName[i];
              this.dataGridViewGuest.Columns[i].Width = colWidth[i];
            }
            this.dataGridViewGuest.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewGuest.ReadOnly = true;
        }
    }
}
