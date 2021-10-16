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
        int max;
        Food food;
        public Food GetFood()
        {
            return food;
        }
        public bool fillData(Food food)
        {
            if (food.amount == 0) return false;
            this.food = food;
            this.labelID.Text = string.Format("ID: {0}",food.id_food);
            this.labelName.Text = string.Format("Name: {0}", food.name_food);
            this.labelPrice.Text = string.Format("Price: {0}d", food.price);
            this.pictureFood.Image = food.picture;
            this.max = food.amount;
            this.labelAmount.Text = "1";
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
            int amount = int.Parse(this.labelAmount.Text);
            if(amount<this.max)
            {
                amount++;
                this.labelAmount.Text = amount.ToString();
            }
            else
            {
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            int amount = int.Parse(this.labelAmount.Text);
            if (amount > 1)
            {
                amount--;
                this.labelAmount.Text = amount.ToString();
            }
            else
            {
            }
        }
        public int getNum()
        {
            return int.Parse(this.labelAmount.Text);
        }
    }
}
