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

namespace Management_Hotel.View.ViewAdmin.ViewFormReport
{
    public partial class FormReportNhapKho : Form
    {
        public FormReportNhapKho()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            //ID_NhapKho,ID_Mon,TenMon," +
            //"SoluongNhap,GiaGoc,GiaBan,Photo,ThoiGianNhap
            DataTable data = NhapKhoDAO.NhapKho_detail_view();
          data.Columns.RemoveAt(6);
          data.Columns.RemoveAt(5);
          data.Columns.RemoveAt(4);
            data.Columns.RemoveAt(1);


            this.dataGridViewGuest.DataSource = data;
            this.dataGridViewGuest.AllowUserToAddRows = false;
            this.dataGridViewGuest.RowTemplate.Height = 100;
            int[] colWidth = { 100, 160, 80, 80};
            string[] colName = { "ID nhap kho", "Ten mon", "So luong nhap", "Thoi gian nhap" };
            for (int i = 0; i < colName.Length; i++)
            {
           this.dataGridViewGuest.Columns[i].HeaderText = colName[i];
            this.dataGridViewGuest.Columns[i].Width = colWidth[i];
            }
            this.dataGridViewGuest.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewGuest.ReadOnly = true;
        }
    }
}
