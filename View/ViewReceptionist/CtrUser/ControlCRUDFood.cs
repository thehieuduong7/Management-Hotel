using Management_Hotel.Control_DAO;
using Management_Hotel.Model;
using Management_Hotel.View.ViewReceptionist.ViewFormFood;
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
    public partial class ControlCRUDFood : UserControl
    {
        private int id_food;
        public FormCRUDFood formParent { get; set; }
        public ControlCRUDFood()
        {
            InitializeComponent();
        }
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
            this.buttonMoney.Text = giaBan + "d";
            this.labelName.Text = string.Format("Name: {0}\nAmount:{1}", tenMon, soLuong);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormEditFood form = new FormEditFood();
            form.fillData(this.id_food) ;
            if (form.ShowDialog() == DialogResult.OK)
            {
                formParent.init();
                this.Dispose();
            }
        }


    }
}
