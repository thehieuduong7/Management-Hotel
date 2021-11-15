using Management_Hotel.Control_DAO;
using Management_Hotel.Model;
using Management_Hotel.View.ViewReceptionist.ViewFormOrderFood;
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
    public partial class FormOptionOpenRoom : Form
    {
        int id_datPhong;
        public void fillData(int id_room)
        {
            DataTable data = DatPhongDAO.DatPhong_getMaDatAvaiByIDPhong_func(id_room);
            if (data.Rows.Count== 0)
            {
                return;
            }
            int id_datPhong = int.Parse(data.Rows[0][0].ToString());
            this.id_datPhong = id_datPhong;
        }
        public FormOrderRoom formParent { get; set; }
        public FormOptionOpenRoom()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
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

        private void buttonOrderFood_Click(object sender, EventArgs e)
        {
            FormOrderFood form = new FormOrderFood();
            form.id_datPhong = this.id_datPhong;
            if (form.ShowDialog() == DialogResult.OK)
            {
                this.formParent.init();
            }
        }

        private void buttonSwapRoom_Click(object sender, EventArgs e)
        {
            FormSwapRoom form = new FormSwapRoom();
            if (form.ShowDialog() == DialogResult.OK)
            {
               
            }
        }

        private void buttonPayRoom_Click(object sender, EventArgs e)
        {
            
        }
    }
}
