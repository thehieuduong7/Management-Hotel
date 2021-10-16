using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Management_Hotel.Model
{
    public class ReportEmpolyeeWork
    {
        public Employee employee_work { get; }
        public Position employee_position { get; set; }
        public DivisionEmployee employee_division { get; set; }
        public Shift shift { get; set; }
        public TimeSpan time_work { get; set; }         //8 tieng
        public DateTime time_start { get; set; }            //gio lam viec
        public DateTime time_end { get; set; }
        public CheckInCheckOut time_check { get; set; }
        public TimeSpan time_off { get; set; }/// di muon
        public TimeSpan time_over { get; set; }// qua' gio`
        public TimeSpan time_total { get; set; }
        public float money_work { get; }
        public float money_off { get; }
        public float money_over { get; }
        public float money_total { get; }
        private void checkTime(DateTime time_start,DateTime time_end, 
            DateTime check_in,DateTime check_out)
        {
            if (check_in.CompareTo(time_end) >= 0 ||      //---(  )---checkIN
                check_out.CompareTo(this.time_start) <= 0)        //-CheckOut--(  )---
            {
                this.time_off = time_end.Subtract(time_start);         //nghi? ca
                this.time_over = check_out.Subtract(check_in);  //
                this.time_work = new TimeSpan(0, 0, 0);
            }
            else if (check_in.CompareTo(time_start) <= 0  &&  //--CheckIN---()--checkOut       
                check_out.CompareTo(this.time_end) >= 0)     
            {
                this.time_work = time_end.Subtract(time_start);
                this.time_off = new TimeSpan(0, 0, 0);
                this.time_over = time_start.Subtract(check_in).Add(check_out.Subtract(time_end));
            }
            else if (check_in.CompareTo(time_start) < 0 &&  //--CheckIN---(--checkOut --)--      
                check_out.CompareTo(this.time_end) < 0)
            {
                this.time_work = check_out.Subtract(time_start);
                this.time_off = time_end.Subtract(check_out);
                this.time_over = time_start.Subtract(check_in);
            }
            else if (check_in.CompareTo(time_start) > 0 &&  //-----(--CheckIN--)---checkOut -      
                check_out.CompareTo(this.time_end) > 0)
            {
                this.time_work = time_end.Subtract(check_in);
                this.time_off = check_in.Subtract(time_start);
                this.time_over = check_out.Subtract(time_end);
            }
            else             ////-----(--CheckIN---checkOut - --)--------
            {
                this.time_work = check_out.Subtract(check_in);
                this.time_off = time_end.Subtract(check_out).Add(check_in.Subtract(time_start));
                this.time_over = new TimeSpan(0, 0, 0);
            }
        }
       public ReportEmpolyeeWork(Employee employee,Position pos,
           DivisionEmployee division,Shift shift,CheckInCheckOut check)
        {
            this.employee_work = employee;
            this.employee_position = pos;
            this.employee_division = division;
            this.shift = shift;
            this.time_check = check;
            this.time_start = this.employee_division.day_start + this.shift.time_start;
            if (this.shift.name_shift == "Night")
            {
                this.time_end = this.employee_division.day_start.AddDays(1) + this.shift.time_end;
            }
            else
            {
                this.time_end = this.employee_division.day_start + this.shift.time_end;
            }
            

            if (this.time_check.status == "Absent")
            {
                this.time_off = time_end.Subtract(time_start);         //nghi? ca
                this.time_over = this.time_check.time_end.Subtract(time_check.time_start);  //
                this.time_work = new TimeSpan(0, 0, 0);
            }
            else if(this.time_check.status == "Done")
            {
                checkTime(this.time_start, this.time_end, this.time_check.time_start, this.time_check.time_end);
            }
            else
            {
                
            }
            this.money_work = this.time_work.Hours * this.employee_position.salary;
            this.money_off = -this.employee_position.fine_money*this.time_off.Hours;
            this.money_over = this.employee_position.over_money * this.time_over.Hours;
            this.money_total = this.money_work + this.money_off + this.money_over;
            this.time_total = this.time_check.time_end.Subtract(this.time_check.time_start);
        }

        public DataRow toDataRow(DataRow row)//"Shift","ID Employee","Picture","Full Name","Position"
                   // "Total Money"
        {
            row[0] = this.shift.name_shift;
            row[1] = this.employee_work.id;
            row[2] = cvtImg(this.employee_work.picture);
            row[3] = this.employee_work.fname;
            row[4] = this.employee_position.name_position;
            if (this.time_check.status == "Processing")
            {
                row[5] = "Processing";
            }
            else
            {
                row[5] = this.money_total.ToString();
            }
            return row;
        }
        public byte[] cvtImg(Image img)
        {
            if (img == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
    }
}
