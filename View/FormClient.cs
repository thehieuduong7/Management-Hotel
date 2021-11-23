using FontAwesome.Sharp;
using Management_Hotel.Control;
using Management_Hotel.Control_DAO;
using Management_Hotel.Model;
using Management_Hotel.View.ViewAdmin;
using Management_Hotel.View.ViewManager;
using Management_Hotel.View.ViewReceptionist;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Hotel.View
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            timer1.Start();
            init();
        }
        public void init()
        {
            this.panelShow.Controls.Clear();
            Form form;
            if (GlobalUser.ChucVu == "Admin")
            {
                form = new FormMenuAdmin();
                this.labelChuVu.Text = "Admin";
            
            }
            else
            {
                if (GlobalUser.ChucVu == "TiepTan")
                {
                    form = new FormMenuReceptionist();
                    this.labelChuVu.Text = "Tiep tan";

                }
                else
                {
                    form = new FormMenuManager();
                    this.labelChuVu.Text = "Quan ly";

                }
                DataTable data = NhanVienDAO.NhanVien_searchByID_func(GlobalUser.idNhanVien);
                //ID_NV,Ho,Ten,NgaySinh,SDT,GioiTinh,Avatar,Luong,ChucVu
                string name = data.Rows[0][2].ToString().Trim();
                Image img = GlobalUser.CvtToImg((byte[])data.Rows[0][6]);

                this.labelName.Text = name;
                this.picAvatar.Image = img;
            }
            showChildForm(form);
            

        }
        private void showChildForm(Form form)
        {
            this.panelShow.Controls.Clear();
            form.TopLevel = false;
            this.panelShow.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Visible = true;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            ConnectionController.logout();
            GlobalUser.clear();
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
            init();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.labelMess.Location.X > -13)
            {
                this.labelMess.Location = new Point
                    (this.labelMess.Location.X - 1, this.labelMess.Location.Y);
            }
            else
            {
                this.labelMess.Location = new Point
                    (735, this.labelMess.Location.Y);
            }
        }
    }
}
