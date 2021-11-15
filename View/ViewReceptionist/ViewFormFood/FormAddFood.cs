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

namespace Management_Hotel.View.ViewReceptionist.ViewFormFood
{
    public partial class FormAddFood : Form
    {
        public FormAddFood()
        {
            InitializeComponent();
            form_load();
        }
        private void form_load()
        {
            this.numericAmount.Minimum = 0;
            this.numericAmount.Maximum = 1000;
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show
     ("Do you want to save", "Management Hotel",
     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            try
            {

                Image picture = this.pictureFood.Image;
                string name_food = this.textBoxName.Text.Trim();
                int amount =(int) this.numericAmount.Value;
                float realprice = float.Parse(this.textBoxRealPrice.Text);
                float price = float.Parse(this.textBoxPrice.Text);

                if (KhoDAO.Kho_add_proc(name_food,amount,realprice,price,picture,null) )  
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
