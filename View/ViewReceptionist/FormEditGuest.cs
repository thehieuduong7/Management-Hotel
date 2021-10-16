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
    public partial class FormEditGuest : Form
    {
        CtrCRUDGuest ctrGuest;
        public FormEditGuest()
        {
            InitializeComponent();
            this.ctrGuest = new CtrCRUDGuest();
            form_load();
        }
        public void fillData(Guest guest)
        {
            this.textBoxID.Text = guest.id_guest.ToString();
            this.textBoxName.Text = guest.full_name;
            this.numbericAge.Value = guest.age;
            if (guest.gender == "Male") radioMale.Checked = true;
            else radioFemale.Checked = true;
            this.textboxPhone.Text = guest.phone;
            this.pictureGuest.Image = guest.picture;
        }
        public void form_load()
        {
            this.numbericAge.Maximum = 100;
            this.numbericAge.Minimum = 14;
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show
                ("Do you want to save?", "Management Hotel",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No) return;
            try
            {
                int id = int.Parse(this.textBoxID.Text);
                string full_name = this.textBoxName.Text.Trim();
                int age = (int)this.numbericAge.Value;
                string gender = (this.radioMale.Checked) ? "Male" : "Else";
                string phone = this.textboxPhone.Text.Trim();
                Image picture = this.pictureGuest.Image;
                Guest guest = new Guest(id, full_name, age, gender, phone, picture);
                if (ctrGuest.updateGuest(guest))
                {
                    MessageBox.Show
                        ("Success!", "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show
                ("Do you want to remove?", "Management Hotel",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            try
            {
                int id = int.Parse(this.textBoxID.Text);
                if (ctrGuest.removeGuest(id))
                {
                    MessageBox.Show
                        ("Success!", "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                       ("Fail format!", "Management Hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_MouseMove(object sender, MouseEventArgs e)
        {
            this.buttonCancel.IconSize = 40;
        }

        private void buttonCancel_MouseLeave(object sender, EventArgs e)
        {
            this.buttonCancel.IconSize = 35;
        }
    }
}
