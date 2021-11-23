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

namespace Management_Hotel.View.ViewReceptionist.ViewFormOrder
{
    public partial class FormOptionCloseRoom : Form
    {
        int id_phong;
        public FormOrderRoom formParent { get; set; }
        public FormOptionCloseRoom()
        {
            InitializeComponent();
        }
        public void fillData(int id_phong)
        {
            this.id_phong=id_phong;
        }
        private void buttonOrder_Click(object sender, EventArgs e)
        {
            FormSelectGuest form = new FormSelectGuest();
            if (form.ShowDialog() == DialogResult.No)
            {
                return;
            }
            int id_guest = FormSelectGuest.get_id_guesst();
            try
            {
                if (DatPhongDAO.DatPhong_add_proc(id_guest,this.id_phong,GlobalUser.idNhanVien,null))
                {
                    MessageBox.Show("Dat phong success", "Management Hotel",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.formParent.init();
                    this.Close();
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Fail", "Management Hotel",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
