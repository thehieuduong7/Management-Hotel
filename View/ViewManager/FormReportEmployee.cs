using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Management_Hotel.Control.ControlManager;
using Management_Hotel.Model;
namespace Management_Hotel.View.ViewManager
{
    public partial class FormReportEmployee : Form
    {
        public FormReportEmployee()
        {
            InitializeComponent();
            ctrReport = new CtrReportEmployee();
            this.time = formatDayStart(DateTime.Now);
        }
        CtrReportEmployee ctrReport;
        public DateTime time;
        private void FormReportEmployee_Load(object sender, EventArgs e)
        {
            dataGridView_load();
            this.panelControlOption.Visible = false;
            for (int i = 1; i <=this.time.Day; i++)
            {
                comboBoxDay.Items.Add(i);
            }
            this.labelMonth.Text = String.Format("Month: {0}", DateTime.Now.Month);
            this.labelYear.Text = String.Format("Year: {0}", DateTime.Now.Year);
        }
        private void dataGridView_load()
        {
            this.dataGridViewReport.DataSource = ctrReport.getDataReport(this.time);
            this.dataGridViewReport.RowTemplate.Height = 100;
            this.dataGridViewReport.AllowUserToAddRows = false;
            this.dataGridViewReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReport.ReadOnly = true;
            this.dataGridViewReport.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.labelTotalMoney_employee.Text = ctrReport.TotalMoney(this.time).ToString();
        }
        public void fillData(ReportEmpolyeeWork report)
        {
            this.panelDone.Visible = true;
            this.panelProcessing.Visible = false;
            this.panelAbsent.Visible = false;
            this.pictureBoxAvatarEmployee.Image = report.employee_work.picture;
            this.label_ID_employee.Text = report.employee_work.id.ToString();
            this.label_fullName.Text = report.employee_work.fname + report.employee_work.lname;
            this.label_position.Text = report.employee_work.name_position;
            this.label_dayStart.Text = report.employee_division.day_start.ToString("MM/dd/yyyy");
            this.label_shift.Text = report.shift.name_shift;
            this.label_Time_start.Text = report.shift.time_start.ToString(@"hh\:mm\:ss");
            this.label_time_end.Text = report.shift.time_end.ToString(@"hh\:mm\:ss");
            if (report.time_check.status == "Done")
            {
                this.label_checkIn.Text = report.time_check.time_start.ToString("MM/dd/yyyy hh:mm:ss");
                this.label_checkOut.Text = report.time_check.time_end.ToString("MM/dd/yyyy hh:mm:ss");
                this.label_timeWork.Text = report.time_work.ToString(@"hh\:mm");
                this.label_timeOff.Text = report.time_off.ToString(@"hh\:mm");
                this.label_timeOver.Text = report.time_over.ToString(@"hh\:mm");
                this.label_salary.Text = report.employee_position.salary.ToString();
                this.label_fineMoney.Text = report.employee_position.fine_money.ToString();
                this.label_over_salary.Text = report.employee_position.over_money.ToString();
                this.labelMoneyWork.Text = report.money_work.ToString();
                this.labelMoneyOff.Text = report.money_off.ToString();
                this.labelMoneyOver.Text = report.money_over.ToString();
                this.label_Money_Total.Text = report.money_total.ToString();
            }
            else if(report.time_check.status == "Absent")
            {
                this.panelDone.Visible = false;
                this.panelAbsent.Visible =  true;
                this.panelProcessing.Visible = false;
                this.label_money_absent.Text = report.money_total.ToString();
            }
            else
            {
                this.panelDone.Visible = false;
                this.panelAbsent.Visible = false;
                this.panelProcessing.Visible = true;
                this.label_pro_checIN.Text = report.time_check.time_start.ToString();
            }
        }

        public DateTime formatDayStart(DateTime now)
        {
            DateTime newTime = now.Date;
            int hou = (int)TimeWork.new_day_hour;
            int min = (int)TimeWork.new_day_minute;
            int sec = (int)TimeWork.new_day_second;
            if (now.CompareTo(newTime.Add(new TimeSpan(hou, min, sec))) < 0)
            {
                return newTime.AddDays(-2).Add(new TimeSpan(hou, min, sec));
            }
            else return newTime.AddDays(-1).Add(new TimeSpan(hou, min, sec));
        }

        private void buttonBackEdit_Click(object sender, EventArgs e)
        {
            this.panelControlOption.Visible = false;
        }

        private void dataGridViewReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                this.panelControlOption.Visible = true;
                int id = int.Parse(dataGridViewReport.Rows[e.RowIndex].Cells[1].Value.ToString());
                ReportEmpolyeeWork report = this.ctrReport.getReport(id, this.time);
                fillData(report);
            }
        }

        private void comboBoxDay_SelectedIndexChanged(object sender, EventArgs e)
        {
            int day;
            try
            {
                day = int.Parse(comboBoxDay.SelectedItem.ToString());
            }
            catch (FormatException) { return; }
            this.time = new DateTime(this.time.Year, this.time.Month, day);
            dataGridView_load();
        }
    }
}
