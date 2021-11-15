using Management_Hotel.Model;
using Management_Hotel.View.ViewReceptionist.CtrUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Hotel.View.ViewReceptionist.ViewFormOrderFood
{
    public partial class FormOrderFood : Form
    {
        public FormOrderFood()
        {
            InitializeComponent();
        }
        public int id_datPhong { get; set; }
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            foreach (ControlSelectFood ctr in this.panelSelect.Controls)
            {
                int id = ctr.id;
                int soLuong = ctr.soLuong;
                ////////////// 
                if (true)
                {
                    // do fail
                }
        
            }
            this.panelSelect.Controls.Clear();
            this.dataGrid_Load();
            MessageBox.Show("Đặt món thành công!", "Management Hotel",
       MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public Image CvtToImg(byte[] byteImage)
        {
            if (byteImage == null) return null;
            using (MemoryStream ms = new MemoryStream(byteImage))
            {
                return new Bitmap(ms);
            }
        }
        public void dataGrid_Load()
        {
            //this.dataGridViewFood.DataSource = this.ctrFood.getDataFoodAvailable();
            this.dataGridViewFood.AllowUserToAddRows = false;
            this.dataGridViewFood.RowTemplate.Height = 50;
            int[] colWidth = { 80, 120, 120, 120, 160 };
            string[] colName = { "ID", "Ten Mon", "Số lượng", "Giá","Photo" };
            for (int i = 0; i < colName.Length; i++)
            {
                this.dataGridViewFood.Columns[i].HeaderText = colName[i];
                this.dataGridViewFood.Columns[i].Width = colWidth[i];
            }
            this.dataGridViewFood.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewFood.ReadOnly = true;
        }
        private void dataGridViewFood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable data = this.dataGridViewFood.DataSource as DataTable;
            int id = int.Parse(data.Rows[e.RowIndex][0].ToString());
            foreach (ControlSelectFood ctr in this.panelSelect.Controls)
            {
                if (ctr.id == id)
                {
                    ctr.buttonPlus_Click(null, null);
                    return;
                }
            }
            ControlSelectFood control = new ControlSelectFood();
            String tenMon = data.Rows[e.RowIndex][1].ToString();
            float Gia = float.Parse(data.Rows[e.RowIndex][1].ToString());
            int SoLuong = int.Parse( data.Rows[e.RowIndex][1].ToString());
            Image img = CvtToImg((byte[])data.Rows[e.RowIndex][1]);
            if (control.fillData(id, tenMon, Gia, SoLuong, img) == false)
            {
                control.Dispose();
                return;
            }
            panelSelect.Controls.Add(control);
            control.Dock = DockStyle.Top;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewFood_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.dataGridViewFood.Rows[e.RowIndex].Selected = false;
            }
        }

        private void dataGridViewFood_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.dataGridViewFood.ClearSelection();
                this.dataGridViewFood.Rows[e.RowIndex].Selected = true;
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable data = this.dataGridViewFood.DataSource as DataTable;
            string search = this.textBoxSearch.Text.Trim();
            data.DefaultView.RowFilter = string.Format("tenMon like '%{0}%'", search);
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            float total = 0;
            foreach (ControlSelectFood ctr in this.panelSelect.Controls)
            {
                float gia = ctr.Gia;
                int soLuong = ctr.soLuong;
                total += gia * soLuong;
            }
            this.labelTotalMoney.Text = string.Format("{0}d", total);
        }
    }
}
