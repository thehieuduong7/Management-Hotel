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
        public FormCRUDRoom formParent { get; set; }
        private void pictureAdd_Click(object sender, EventArgs e)
        {
            FormAddRoom form = new FormAddRoom();
            if (form.ShowDialog() == DialogResult.OK)
            {
                if (formParent != null)
                    formParent.init();
            }
        }
    }
}
