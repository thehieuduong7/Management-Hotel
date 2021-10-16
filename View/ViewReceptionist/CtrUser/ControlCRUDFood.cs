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
        private Food food;
        public FormCRUDFood formParent { get; set; }
        public ControlCRUDFood()
        {
            InitializeComponent();
        }
        public void setFood(Food food)
        {
            this.food = food;
            this.buttonEdit.Image = food.picture;
            this.buttonEdit.Text = food.price.ToString()+"d";
            this.labelName.Text = string.Format("Name: {0}\nAmount:{1}", food.name_food, food.amount);
            
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormEditFood form = new FormEditFood();
            form.fillData(this.food);
            if(form.ShowDialog()==DialogResult.No) return;
            if (formParent != null)
            {
                formParent.reset();
            }
        }
    }
}
