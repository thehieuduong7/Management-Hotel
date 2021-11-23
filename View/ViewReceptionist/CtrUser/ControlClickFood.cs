using Management_Hotel.Control_DAO;
using Management_Hotel.View.ViewReceptionist.ViewFormNhapKho;
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
    public partial class ControlClickFood : UserControl
    {
        public ControlClickFood()
        {
            InitializeComponent();
        }
        int id_food;
        public FormNhapkho formParent { get; set; }
        
        public void fillData(int id_food)
        {
            this.id_food = id_food;
            DataTable data = KhoDAO.Kho_searchByID_func(id_food);

            if (data.Rows.Count == 0) return;

            string tenMon = data.Rows[0][1].ToString().Trim();
            string soLuong = data.Rows[0][2].ToString().Trim();
            string giaBan = data.Rows[0][4].ToString().Trim();
            Image img = GlobalUser.CvtToImg((byte[])data.Rows[0][5]);

            if (img != null)
                this.pictureFood.Image = img;
            this.buttonMoney.Text = String.Format("Amount:{0}", soLuong);
            this.labelName.Text = string.Format("Name: {0}", tenMon);
        }

        private void buttonMoney_Click(object sender, EventArgs e)
        {
            this.formParent.selectFood(this.id_food);
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void pictureFood_Click(object sender, EventArgs e)
        {

        }
    }
}
