using Management_Hotel.Control.ControlLabourer;
using System;
using System.Windows.Forms;
using System.Drawing;
using Management_Hotel.Model;

namespace Management_Hotel.View.ViewLabourer
{
    public partial class FormCheckInCheckOut : Form
    {
        public Employee employee { get; set; }
        CtrCheckInCheckOut ctrCheck;
        public FormCheckInCheckOut()
        {
            InitializeComponent();
            this.ctrCheck = new CtrCheckInCheckOut();
        }
        private DateTime time_start;
        private bool modeCheckIn;
        string name_shift = "Morning";


        private void FormCheckInCheckOut_Load(object sender, EventArgs e)
        {
            progressBarTimeWork.Minimum = 0; //Đặt giá trị nhỏ nhất cho ProgressBar
            progressBarTimeWork.Maximum = 60 * 8; //Đặt giá trị lớn nhất cho ProgressBar
            if (!ctrCheck.hasWorkToday(this.employee.id, this.name_shift))
            {
                set_defaultMode();
            }
            else if (!ctrCheck.isChecked(this.employee.id))
            {
                set_checkInMode();
            }
            else
            {
                set_checkOutMode();
            }
        }
        private void set_defaultMode()
        {
            this.buttonCheckIn.Visible = false;
            this.labelAnnoucement.Text = "You dont have " + this.name_shift.ToLower() + " shift today";
            this.timerWork.Stop();
            this.labelTimeWork.Text = "0:00";
            this.progressBarTimeWork.Style = ProgressBarStyle.Marquee;
        }
        private void set_checkInMode()
        {
            this.labelAnnoucement.Text = "";
            this.buttonCheckIn.Visible = true;
            this.buttonCheckIn.Text = "IN";
            this.modeCheckIn = true;
            this.timerWork.Stop();
            this.labelTimeWork.Text = "0:00";
            this.progressBarTimeWork.Style = ProgressBarStyle.Marquee;
        }
        private void set_checkOutMode()
        {
            this.timerWork.Start();
            this.labelAnnoucement.Text = "";
            this.time_start = this.ctrCheck.getTimeStart(this.employee.id);
            this.buttonCheckIn.Visible = true;
            this.buttonCheckIn.Text = "OUT";
            this.modeCheckIn = false;
            this.progressBarTimeWork.Style = ProgressBarStyle.Blocks;
        }
        private void timerWork_Tick(object sender, EventArgs e)
        {
            TimeSpan time_work = DateTime.Now.Subtract(this.time_start);
            this.labelTimeWork.Text = time_work.ToString(@"hh\:mm\:ss");
            int value= time_work.Hours * 60 + time_work.Minutes;
            if (value <= progressBarTimeWork.Maximum)
            {
                this.progressBarTimeWork.Value = value;
            }
            else
            {
                this.progressBarTimeWork.Value = progressBarTimeWork.Maximum;
            }
        }

        private void checkOutClick()
        {
            if (!ctrCheck.checkOut(this.employee.id))
            {
                MessageBox.Show("You have done to work today!!!", "Managent hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Correct!!!", "Managent hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            set_checkInMode();
            return;
        }
        private void checkInClick()
        {
            if (ctrCheck.isChecked(this.employee.id))
            {
                MessageBox.Show("You have checked!!!", "Managent hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!ctrCheck.checkIn(employee.id, name_shift))
            {
                MessageBox.Show("You have done to work today!!!", "Managent hotel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Correct!!!", "Managent hotel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            set_checkOutMode();
            return;
        }
        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            if (this.modeCheckIn)
            {
                checkInClick();
            }
            else { checkOutClick(); ; }
        }


        public void radioButton_select(RadioButton radio)
        {
            foreach(RadioButton i in panelRadioButton.Controls)
            {
                i.ForeColor = Color.Silver;
            }
            radio.ForeColor = Color.White;
        }
        private void radioMorning_CheckedChanged(object sender, EventArgs e)
        {
            this.name_shift = "Morning";
            radioButton_select(this.radioMorning);
             FormCheckInCheckOut_Load(null, null);
        }

        private void radioAfternoon_CheckedChanged(object sender, EventArgs e)
        {
            this.name_shift = "Afternoon";
            radioButton_select(this.radioAfternoon);
            FormCheckInCheckOut_Load(null, null);
        }

        private void radioNight_CheckedChanged(object sender, EventArgs e)
        {
            this.name_shift = "Night";
            radioButton_select(this.radioNight);
            FormCheckInCheckOut_Load(null, null);
        }
    }
}
