using Management_Hotel.Control_DAO;
using Management_Hotel.Model;
using Management_Hotel.View.ViewReceptionist.ViewFormOrder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Hotel.View.ViewReceptionist.CtrUser
{
    public partial class ControlOrderRoom : UserControl
    {
        public ControlOrderRoom()
        {
            InitializeComponent();
        }
        private int id_room;
        private string status = "Dang Su Dung";
        public void fillData(int id_room)
        {
            //ID_Phong,TenPhong,Vitri,Photo,Gia,TrangThai
            DataTable data = PhongDAO.Phong_searchByID_func(id_room);
            if (data.Rows.Count == 0) return;
            string tenPhong = data.Rows[0][1].ToString().Trim();
            String trangThai = data.Rows[0][5].ToString().Trim();
            this.status = trangThai;
            this.buttonOrder.Text = tenPhong;
            if (status=="Dang Su Dung")
            {
                open_load();
            }
            else
            {
                closed_load();
            }
        }

        public FormOrderRoom formParent;

        public void open_load()
        {
            this.buttonOrder.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.buttonOrder.BackColor = Color.Red;
        }
        public void closed_load()
        {
            this.buttonOrder.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.buttonOrder.BackColor = Color.DimGray;
        }
        public void open_click()
        {
            FormOptionOpenRoom form = new FormOptionOpenRoom();
            form.fillData(this.id_room);
            form.formParent = this.formParent;
            form.ShowDialog();
        }
        public void closed_click()
        {
            FormOptionCloseRoom form = new FormOptionCloseRoom();
            form.fillData(this.id_room);
            form.formParent = this.formParent;
            form.ShowDialog();
        }
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            if(this.status=="Dang Su Dung")
            {
                open_click();
            }
            else
            {
                closed_click();
            }
        }
    }
}
