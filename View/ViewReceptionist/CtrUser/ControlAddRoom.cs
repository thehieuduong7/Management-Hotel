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
    public partial class ControlAddRoom : UserControl
    {
        public ControlAddRoom()
        {
            InitializeComponent();
        }
        FormCRUDRoom formParent;
        public void setParent(FormCRUDRoom formParent)
        {
            this.formParent = formParent;
        }
        private void pictureAdd_Click(object sender, EventArgs e)
        {
            FormAddRoom formAdd = new FormAddRoom();
            if (this.formParent != null)
            {
                formAdd.setParent(this.formParent);
            }
            if (formAdd.ShowDialog() == DialogResult.Yes)
            {
                this.formParent.reset();
            }
        }
    }
}
