using Management_Hotel.Control.ControlReceptionist;
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
    public partial class FormSelectRoom : Form
    {
        CtrOrderRoom ctrOrderRoom;
        private static Room room;
        public FormSelectRoom()
        {
            InitializeComponent();
            this.ctrOrderRoom = new CtrOrderRoom();
            form_load();
        }
        public static Room get_select_room()
        {
            return FormSelectRoom.room;
        }
        public void form_load()
        {
            this.dataGridViewGuest.DataSource = this.ctrOrderRoom.getDataAvailableRoom();
            this.dataGridViewGuest.AllowUserToAddRows = false;
            this.dataGridViewGuest.RowTemplate.Height = 30;
            int[] colWidth = { 160, 120, 120, 120, 160};
            string[] colName = { "ID Phòng","Loại","Số giường","Vị trí","Giá phòng" };
            for (int i = 0; i < colName.Length; i++)
            {
                this.dataGridViewGuest.Columns[i].HeaderText = colName[i];
                this.dataGridViewGuest.Columns[i].Width = colWidth[i];
            }
            this.dataGridViewGuest.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewGuest.ReadOnly = true;
        }

        private void dataGridViewGuest_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.dataGridViewGuest.ClearSelection();
                this.dataGridViewGuest.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dataGridViewGuest_MouseLeave(object sender, EventArgs e)
        {
            this.dataGridViewGuest.ClearSelection();
        }

        private void dataGridViewGuest_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }
            if (MessageBox.Show
               ("Are you sure?", "Management Hotel",
               MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
            DataTable data = this.dataGridViewGuest.DataSource as DataTable;
            FormSelectRoom.room = new Room(data.Rows[e.RowIndex].ItemArray);
            this.DialogResult = DialogResult.Yes;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable data = this.dataGridViewGuest.DataSource as DataTable;
            string search = this.textBoxSearch.Text.Trim();
            data.DefaultView.RowFilter = string.Format("id_phong like '{0}%'", search);
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
