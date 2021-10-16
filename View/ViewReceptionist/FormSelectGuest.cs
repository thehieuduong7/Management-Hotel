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

namespace Management_Hotel.View.ViewReceptionist
{
    public partial class FormSelectGuest : Form
    {
        CtrCRUDGuest ctrGuest;
        private  static Guest guest;
        public FormSelectGuest()
        {
            InitializeComponent();
            ctrGuest = new CtrCRUDGuest();
            form_load();
        }
        public static Guest get_select_guest()
        {
            return FormSelectGuest.guest;
        }
        public void form_load()
        {
            this.dataGridViewGuest.DataSource = this.ctrGuest.getDataGuest();
            this.dataGridViewGuest.AllowUserToAddRows = false;
            this.dataGridViewGuest.RowTemplate.Height = 50;
            int[] colWidth = { 80, 160, 60, 80, 160, 120 };
            string[] colName = { "ID Guest", "Full name", "Age", "Gender", "Phone Contact", "Picture" };
            for (int i = 0; i < colName.Length; i++)
            {
                this.dataGridViewGuest.Columns[i].HeaderText = colName[i];
                this.dataGridViewGuest.Columns[i].Width = colWidth[i];
            }
            this.dataGridViewGuest.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewGuest.ReadOnly = true;
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
            FormSelectGuest.guest = new Guest(data.Rows[e.RowIndex].ItemArray);
            this.Close();
        }


        private void dataGridViewGuest_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.dataGridViewGuest.ClearSelection();
                this.dataGridViewGuest.Rows[e.RowIndex].Selected = true;
            }
        }

        private void buttonAddGuest_Click(object sender, EventArgs e)
        {
            FormAddGuest formAdd = new FormAddGuest();
            formAdd.ShowDialog();
            this.form_load();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable data = this.dataGridViewGuest.DataSource as DataTable;
            string search = this.textBoxSearch.Text.Trim();
            data.DefaultView.RowFilter = string.Format("full_name like '{0}%'", search);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
        private void buttonCancel_MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonCancel.IconSize = 40;
        }

        private void buttonCancel_MouseLeave(object sender, EventArgs e)
        {
            this.buttonCancel.IconSize = 35;
        }

        private void dataGridViewGuest_MouseLeave(object sender, EventArgs e)
        {
            this.dataGridViewGuest.ClearSelection();
        }
    }
}
