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

namespace Management_Hotel.View.ViewReceptionist.CtrUser
{
    public partial class ControlSelectFood : UserControl
    {
        public ControlSelectFood()
        {
            InitializeComponent();
        }
        int id;
        int soLuong;
        int soLuongMax;
        float gia;
        public int getID() => id;
        public int getSoLuong() => soLuong;
        public float getGia() => gia;
        public void setMax(int max)
        {
            this.soLuongMax = max;
        }
        public bool fillData(int id_food)
        {
            this.id = id_food;
            DataTable data = KhoDAO.Kho_searchByID_func(id_food);
            if (data == null) return false;
            string tenMon = data.Rows[0][1].ToString().Trim() ;
            int SoLuongMax = int.Parse(data.Rows[0][2].ToString().Trim());
            String gia = data.Rows[0][4].ToString().Trim();
            Image img = GlobalUser.CvtToImg((byte[])data.Rows[0][5]);
            if (SoLuongMax == 0) return false;


            this.labelID.Text = string.Format("ID: {0}",id);
            this.labelName.Text = string.Format("Name: {0}", tenMon);
            this.labelPrice.Text = string.Format("Price: {0}d", gia);
            if(img != null)
                this.pictureFood.Image = img;
            this.soLuongMax = SoLuongMax;
            this.soLuong = 1;
            this.gia = float.Parse(gia);
            this.labelAmount.Text =this.soLuong.ToString();
            return true;
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonClose_MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonClose.IconSize = 27;
        }

        private void buttonClose_MouseLeave(object sender, EventArgs e)
        {
            this.buttonClose.IconSize = 25;
        }

        public void buttonPlus_Click(object sender, EventArgs e)
        {
            
            if(this.soLuong<this.soLuongMax)
            {
                this.soLuong++;
                this.labelAmount.Text = this.soLuong.ToString();
            }
            else
            {
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (this.soLuong > 1)
            {
                this.soLuong--;
                this.labelAmount.Text = this.soLuong.ToString();
            }
            else
            {
            }
        }
    }
}
