using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Management_Hotel.Control_DAO;
using Management_Hotel.Model;
namespace Management_Hotel.View.ViewReceptionist.CtrUser
{
    public partial class ControlRoom : UserControl
    {
        int id_phong=-1;
        public FormCRUDRoom formParent { get; set; }
        public ControlRoom()
        {
            InitializeComponent();
        }

        public int getIDPhong() { return id_phong; }
        public bool fillData(int id_phong)
        {
            this.id_phong = id_phong;
            DataTable data = PhongDAO.Phong_searchByID_func(id_phong);
            if (data.Rows.Count == 0) return false;
            string gia = data.Rows[0][4].ToString().Trim();
            string tenPhong = data.Rows[0][1].ToString().Trim();
            this.buttonEdit.Text = gia + " đ";
            this.label_room.Text = tenPhong;
            int x = this.Width / 2 - this.label_room.Width / 2;
            this.label_room.Location = new Point(x, this.label_room.Location.Y);
            return true;
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            FormEditRoom form = new FormEditRoom();
            form.fillData(this.id_phong);
            if (form.ShowDialog() == DialogResult.OK)
                this.formParent.init();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to remove this door?", "Management Hotel",
     MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }
            try
            {
                if (PhongDAO.Phong_del_proc(this.id_phong,null))
                {
                    MessageBox.Show("Remove success", "Management Hotel",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.formParent.init();
                    this.Dispose();
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Remove fail", "Management Hotel",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureLogo_Click(object sender, EventArgs e)
        {
            buttonEdit_Click(null, null);
        }
    }
}
