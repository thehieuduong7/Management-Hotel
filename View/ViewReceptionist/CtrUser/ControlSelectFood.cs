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
        public int id { get; set; }
        String tenMon;public float Gia { get; set; }
        int max; Image image;
        public int soLuong { get; set; }
        public bool fillData(int id, String tenMon,float Gia,int max,Image image)
        {
            this.id = id; this.tenMon = tenMon; this.Gia = Gia; this.max = max; this.image = image;
            if (max == 0) return false;
            this.labelID.Text = string.Format("ID: {0}",id);
            this.labelName.Text = string.Format("Name: {0}", tenMon);
            this.labelPrice.Text = string.Format("Price: {0}d", Gia);
            this.pictureFood.Image = image;
            this.max = max;
            this.soLuong = 1;
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
            
            if(this.soLuong<this.max)
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
