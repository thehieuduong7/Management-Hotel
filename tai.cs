using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        MyDB myDB = new MyDB();
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            int days = 30;
            int shifts = 3;
            int emps = 2;
            string cv = "QuanLi";
            NhanVien nhanVien = new NhanVien();
            for (int i = 1; i <= days; i++)
            {
                for (int j = 1; j <= shifts; j++)
                {
                    int tem = i + j - 1;
                    while (tem > emps && tem > 0)
                    {
                        tem -= emps;
                    }
                    nhanVien.insertCa(tem, cv, j, Convert.ToDateTime(DateTime.Now.AddDays(i).ToString("MM/dd/yyyy")), Convert.ToDateTime(DateTime.Now.AddDays(i).ToString("MM/dd/yyyy")).DayOfWeek.ToString());
                }
            }
            SqlCommand command = new SqlCommand("Select*from ChiaCa");
            dataGridView1.DataSource = nhanVien.getChiaCa(command);
        }
        private void okbtn_Click(object sender, EventArgs e)
        {
            
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            nv.deleteID(1);
            nv.deleteID(2);
            nv.deleteID(3);
            nv.deleteID(4);
            nv.deleteID(5);
            nv.deleteID(6);
            SqlCommand command = new SqlCommand("select Employee.id, fname, lname, Employee.ChucVu, phone,Ca.id_ca, Ca.Ca, Ca.Start_ca, Ca.End_ca, day, dayofweek from Employee inner join ChiaCa on Employee.id = ChiaCa.id_emp inner join Ca on ChiaCa.id_ca = Ca.id_ca ");
            dataGridView1.DataSource = nv.getChiaCa(command);
        }
    }
}
