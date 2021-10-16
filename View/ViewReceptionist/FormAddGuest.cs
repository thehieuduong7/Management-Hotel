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

namespace Management_Hotel.View.ViewReceptionist
{
    public partial class FormAddGuest : Form
    {
        CtrCRUDGuest ctrGuest;
        private static Guest new_guest;
        public FormAddGuest()
        {
            InitializeComponent();
            this.ctrGuest = new CtrCRUDGuest();
            FormAddGuest.new_guest = null;
            form_load();
        }
        public Guest get_new_guest()
        {
            return FormAddGuest.new_guest;
        }
        public void form_load()
        {
            this.numbericAge.Maximum = 100;
            this.numbericAge.Minimum = 14;
            id_load();
        }
        public void id_load()
        {
            int id = this.ctrGuest.new_id_guest();
            this.textBoxID.Text = id.ToString();
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
                    this.pictureGuest.Image = new Bitmap(temp, pictureGuest.Size);
                }
                catch (System.ArgumentException)
                {
                    MessageBox.Show
                        (openFileDialog1.FileName + "\nPaint cannot read this file!!!",
                        "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonRefreshID_Click(object sender, EventArgs e)
        {
            id_load();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(this.textBoxID.Text);
                string full_name = this.textBoxName.Text.Trim();
                int age = (int)this.numbericAge.Value;
                string gender = (this.radioMale.Checked) ? "Male" : "Else";
                string phone = this.textboxPhone.Text.Trim();
                Image picture = this.pictureGuest.Image;
                FormAddGuest.new_guest = new Guest(id,full_name,age,gender,phone,picture);
                if (ctrGuest.insertGuest(FormAddGuest.new_guest))
                {
                    MessageBox.Show
                        ("Success!", "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buttonCancel_Click(null, null);
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show
                       ("Fail format!", "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
