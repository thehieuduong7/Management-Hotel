﻿using Management_Hotel.View.ViewReceptionist;
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

namespace Management_Hotel.View.ViewManager
{
    public partial class FormMenuManager : Form
    {
        public FormMenuManager()
        {
            InitializeComponent();
            this.formEdit = new FormEditEmployee();
            this.formDivision = new FormDivisionEmployee();
            this.formReport = new FormReportEmployee();
        }
        private void FormMenuManager_Load(object sender, EventArgs e)
        {
        }


        FormEditEmployee formEdit;
        FormDivisionEmployee formDivision;
        FormReportEmployee formReport;
        private void openChildForm(Form form)
        {
            this.panelShow.Controls.Clear();
            form.TopLevel = false;
            this.panelShow.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.Visible = true;
        }

        private void buttonScheduleOption_Click(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonScheduleOption);
            openChildForm(this.formDivision);
        }
        private void buttonInformation_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.White;
        }

        private void buttonInformation_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.ForeColor = Color.Silver;
        }


        private void resetColorButtonOption()
        {
            foreach(Object btn in this.panelOption.Controls)
            {
                Button button;
                try
                {
                    button = (Button)btn;
                }
                catch (InvalidCastException) { continue; }
                if (button != null)
                {
                    button.BackColor = Color.FromArgb(33,33,33) ;
                }
            }
        }
        private void selectButtonOption(Button btn)
        {
            resetColorButtonOption();
            btn.BackColor = Color.DimGray;
        }

        private void buttonReportOption_Click(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonReportOption);
            openChildForm(this.formReport);
        }

        private void buttonEmployeeOption_Click(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonEmployeeOption);
            openChildForm(formEdit);
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonRoom);
            FormCRUDRoom form = new FormCRUDRoom();
            openChildForm(form);
        }

        private void buttonFood_Click(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonFood);
            FormCRUDFood form = new FormCRUDFood();
            openChildForm(form);
        }

        private void buttonGuest_Click(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonGuest);
            FormCRUDGuest form = new FormCRUDGuest();
            openChildForm(form);
        }

        private void buttonOrderRoom_Click(object sender, EventArgs e)
        {
            selectButtonOption(this.buttonOrderRoom);
            FormOrderRoom form = new FormOrderRoom();
            openChildForm(form);
        }
    }
}
