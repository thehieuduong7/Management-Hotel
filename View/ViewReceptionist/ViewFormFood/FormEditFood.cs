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

namespace Management_Hotel.View.ViewReceptionist.ViewFormFood
{
    public partial class FormEditFood : Form
    {
        CtrCRUDFood ctrFood;
        public FormEditFood()
        {
            InitializeComponent();
            ctrFood = new CtrCRUDFood();
            form_load();
        }
        private void form_load()
        {
            this.numericAmount.Minimum = 0;
            this.numericAmount.Maximum = 1000;
        }
        public void fillData(Food food)
        {
            this.textBoxID.Text = food.id_food;
            this.textBoxName.Text = food.name_food;
            this.numericAmount.Value = food.amount;
            this.textBoxPrice.Text = food.price.ToString();
            this.pictureFood.Image = food.picture;
        }
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Upload image";
            openFileDialog1.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)" +
                "|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Bitmap temp = new Bitmap(openFileDialog1.FileName);
                    this.pictureFood.Image = new Bitmap(temp, pictureFood.Size);
                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show
                        (openFileDialog1.FileName + "\nPaint cannot read this file!!!",
                        "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show
("Do you want to remove", "Management Hotel",
MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            try
            {
                string id_food = this.textBoxID.Text.Trim();
                if (ctrFood.removeFood(id_food))
                {
                    MessageBox.Show
                        ("Success!", "Management Hotel",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.Yes;
                    this.Close();
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show
                       ("Fail format!",
                       "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show
     ("Do you want to save", "Management Hotel",
     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            try
            {
                string id_food = this.textBoxID.Text.Trim();
                Image picture = this.pictureFood.Image;
                string name_food = this.textBoxName.Text.Trim();
                int amount = (int)this.numericAmount.Value;
                float price = float.Parse(this.textBoxPrice.Text);
                Food food = new Food(id_food, picture, name_food, amount, price);
                if (ctrFood.updateFood(food))
                {
                    MessageBox.Show
                        ("Success!", "Management Hotel",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show
                       ("Fail format!",
                       "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
