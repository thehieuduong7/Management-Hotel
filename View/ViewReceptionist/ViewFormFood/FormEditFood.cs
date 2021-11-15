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
    public partial class FormEditFood : Form
    {
        int id_food;
        public FormEditFood()
        {
            InitializeComponent();
            form_load();
        }
      
        private void form_load()
        {
            this.numericAmount.Minimum = 0;
            this.numericAmount.Maximum = 1000;
        }
        public void fillData(int id_food)
        {
            this.id_food = id_food;
            DataTable data = KhoDAO.Kho_searchByID_func(id_food);
            if (data.Rows.Count == 0) return;

            string tenMon = data.Rows[0][1].ToString().Trim();
            string soLuong = data.Rows[0][2].ToString().Trim();
            string giaGoc = data.Rows[0][3].ToString().Trim();
            string giaBan = data.Rows[0][4].ToString().Trim();
            Image img = GlobalUser.CvtToImg((byte[])data.Rows[0][5]);

            this.textBoxID.Text = id_food.ToString() ;
            this.textBoxName.Text = tenMon;
            this.numericAmount.Value = int.Parse(soLuong);
            this.textBoxRealPrice.Text = giaGoc;
            this.textBoxPrice.Text = giaBan;
            if (img != null)
                this.pictureFood.Image = img;
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
("Do you want to remove fodd?", "Management Hotel",
MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            try
            {
                int id_food = int.Parse(this.textBoxID.Text.Trim());
                if (KhoDAO.Kho_del_proc(id_food,null))   
                {
                    MessageBox.Show
                        ("Remove success!", "Management Hotel",
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
                       ("Remove fail!",
                       "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show
     ("Do you want to save food?", "Management Hotel",
     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
                return;
            try
            {
                int id_food = int.Parse(this.textBoxID.Text.Trim());
                Image picture = this.pictureFood.Image;
                string name_food = this.textBoxName.Text.Trim();
                int amount = (int)this.numericAmount.Value;
                float realPrice = float.Parse(this.textBoxRealPrice.Text);
                float price = float.Parse(this.textBoxPrice.Text);
                Image img = pictureFood.Image;
                if (KhoDAO.Kho_upd_proc(id_food, name_food, amount, realPrice,price,img,null) )  
                {
                    MessageBox.Show
                        ("Update success!", "Management Hotel",
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
                       ("Update fail!",
                       "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
