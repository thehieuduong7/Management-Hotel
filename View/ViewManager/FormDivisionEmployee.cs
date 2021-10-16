using Management_Hotel.Control.ControlManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Hotel.View.ViewManager
{
    public partial class FormDivisionEmployee : Form
    {
        public FormDivisionEmployee()
        {
            InitializeComponent();
            ctrDivision = new CtrDivisionEmployee();
            week = new WeekInMonth();
            this.dataDivision = ctrDivision.getDataDivisionInWeeks();
            FormDivisionEmployee_Load(null, null);
            timerHighLightLableWeek.Start();
        }
        CtrDivisionEmployee ctrDivision;
        WeekInMonth week;
        private void FormDivisionEmployee_Load(object sender, EventArgs e)
        {
            load_dataGridViewInWeek(this.dataDivision[0]);
        }

        private void load_dataGridViewInWeek(DataTable data)
        {
            this.dataGridViewDivision.AllowUserToAddRows = false;
            this.labelWeek.Text = week.getWeek(this.indexData + 1);
            this.dataGridViewDivision.DataSource = data;
            this.dataGridViewDivision.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
            foreach (DataGridViewRow row in this.dataGridViewDivision.Rows)
            {
                for (int i = 0; i < 3; i++)
                {
                    row.Cells[i].Style.BackColor = Color.Gray;
                }
            }
            
        }


        private void buttonDropControl_Click(object sender, EventArgs e)
        {
            panelControl.Visible = !panelControl.Visible;
        }
        DataTable[] dataDivision;
        int indexData = 0;
        private void buttonNextView_Click(object sender, EventArgs e)
        {
            if (this.indexData == dataDivision.Length-1)
            {
                indexData = 0;
            }
            else
            {
                indexData++;
            }
            load_dataGridViewInWeek(this.dataDivision[indexData]);
        }

        private void buttonPreviousView_Click(object sender, EventArgs e)
        {
            if (this.indexData == 0)
            {
                indexData = dataDivision.Length-1;
            }
            else
            {
                indexData--;
            }
            load_dataGridViewInWeek(this.dataDivision[indexData]);
        }



        private void buttonNextView_MouseMove(object sender, MouseEventArgs e)
        {
            FontAwesome.Sharp.IconPictureBox pic = (FontAwesome.Sharp.IconPictureBox)sender;
            pic.IconSize = 40;
        }

        private void buttonNextView_MouseLeave(object sender, EventArgs e)
        {
            FontAwesome.Sharp.IconPictureBox pic = (FontAwesome.Sharp.IconPictureBox)sender;
            pic.IconSize = 30;
        }


        private void timerHighLightLableWeek_Tick(object sender, EventArgs e)
        {
            if( this.labelWeek.ForeColor == Color.Silver)
            {
                this.labelWeek.ForeColor = Color.White ;
            }
            else
            {
                this.labelWeek.ForeColor = Color.Silver;
            }
        }


        private void dataGridViewDivision_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in this.dataGridViewDivision.Rows)
            {
                for (int i = 0; i < 3; i++)
                {
                    row.Cells[i].Style.BackColor = Color.Gray;
                }
            }
        }
    }
}
