using Management_Hotel.Control;
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

namespace Management_Hotel.View
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        
        }
 

        private string pos = "Khách Hàng";
        private void radioLabour_CheckedChanged(object sender, EventArgs e)
        {
            this.pos = "Khách Hàng";
        }

        private void radioRecept_CheckedChanged(object sender, EventArgs e)
        {
            this.pos = "Nhân Viên";
        }

        private void radioManager_CheckedChanged(object sender, EventArgs e)
        {
            this.pos = "Admin";
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public bool isFull()
        {
            if(this.textBoxUser.Text!="" && this.textBoxPass.Text != "")
            {
                return true;
            }
            return false;
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
