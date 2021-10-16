using Management_Hotel.Control.ControlReceptionist;
using Management_Hotel.Model;
using Management_Hotel.View.ViewReceptionist.CtrUser;
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
    public partial class FormOrderRoom : Form
    {
        public FormOrderRoom()
        {
            InitializeComponent();
            ctrOrder = new CtrOrderRoom();
            ctrRoom = new CtrCRUDRoom();
            fillData(ctrRoom.getDataRoom());
            //load_static();
        }
        CtrOrderRoom ctrOrder;
        CtrCRUDRoom ctrRoom;
        public void load_static()
        {
            DataTable data = ctrRoom.getStaticRoom();
            panelStatic.Controls.Clear();
            foreach (DataRow row in data.Rows)
            {
                Label label = new Label();
                panelStatic.Controls.Add(label);
                label.Font = new Font("Cooper Black", 10, FontStyle.Italic);
                label.ForeColor = Color.Silver;
                label.Dock = DockStyle.Top;
                label.Text = string.Format("Kind {0}: {1} rooms",
                    row[0].ToString().Trim(), row[1].ToString().Trim()).ToUpper();
            }
        }
        public void reset()
        {
            fillData(ctrRoom.getDataRoom());
        }
        public void fillData(DataTable data)
        {
            if (data == null) return;
            Panel panel = new Panel();
            this.panelShow.Controls.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                if (i % 6 == 0)
                {
                    panel = new Panel();
                    this.panelShow.Controls.Add(panel);
                    panel.Dock = DockStyle.Top;
                    panel.Height = 155;
                    panel.BringToFront();
                }
                Room room = new Room(data.Rows[i].ItemArray);
                ControlOrderRoom control = new ControlOrderRoom();
                control.formParent = this;
                control.setRoom(room);
                panel.Controls.Add(control);
                control.Dock = DockStyle.Left;
                control.BringToFront();
            }
        }
    }
}
