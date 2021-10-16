using Management_Hotel.View.ViewReceptionist.ViewFormFood;
using Management_Hotel.View.ViewReceptionist.ViewFormOrder;
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
    public partial class ControlAddFood : UserControl
    {
        public FormCRUDFood formParent { get; set; }
        public ControlAddFood()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddFood form = new FormAddFood();
            if (form.ShowDialog() == DialogResult.No) return;
            if (formParent != null)
            {
                formParent.reset();
            }
        }
    }
}
