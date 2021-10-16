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
    public partial class FormCRUDRoom : Form
    {
        public FormCRUDRoom()
        {
            InitializeComponent();
            ctrRoom = new CtrCRUDRoom();
            fillDataRoom(ctrRoom.getDataRoom());
            load_static();
        }
        CtrCRUDRoom ctrRoom;
        public void load_static()
        {
            DataTable data = ctrRoom.getStaticRoom();
            panelStatic.Controls.Clear();
            foreach(DataRow row in data.Rows)
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
            this.fillDataRoom(ctrRoom.getDataRoom());
            load_static();
        }
        private void fillDataRoom(DataTable data)
        {
            if (data == null) return;
            Panel panel = new Panel();
            this.panelShow.Controls.Clear();
            for (int i = 0; i < data.Rows.Count+1; i++)
            {
                if (i % 6 == 0)
                {
                    panel = new Panel();
                    this.panelShow.Controls.Add(panel);
                    panel.Dock = DockStyle.Top;
                    panel.Height = 155;
                    panel.BringToFront();
                }
                if (i == data.Rows.Count)
                {
                    ControlAddRoom control = new ControlAddRoom();
                    control.setParent(this);
                    panel.Controls.Add(control);
                    control.Dock = DockStyle.Left;
                    control.BringToFront();
                }
                else
                {
                    Room room = new Room(data.Rows[i].ItemArray);
                    ControlRoom control = new ControlRoom();
                    control.setParent(this);
                    control.fillData(room);
                    panel.Controls.Add(control);
                    control.Dock = DockStyle.Left;
                    control.BringToFront();
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = this.textBoxSearch.Text.Trim();
            DataTable data = this.ctrRoom.getDataRoom();
            data.DefaultView.RowFilter = string.Format("[id_phong] like '%{0}%'", search);
            data = data.DefaultView.ToTable();
            fillDataRoom(data);
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable data = ctrRoom.getDataRoom();
            string search = this.textBoxSearch.Text.Trim();
            data.DefaultView.RowFilter = string.Format("id_phong like '{0}%'", search);
            fillDataRoom(data.DefaultView.ToTable());
        }
    }
}
