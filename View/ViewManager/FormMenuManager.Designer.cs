﻿
namespace Management_Hotel.View.ViewManager
{
    partial class FormMenuManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelOption = new System.Windows.Forms.Panel();
            this.buttonOrderRoom = new FontAwesome.Sharp.IconButton();
            this.buttonFood = new FontAwesome.Sharp.IconButton();
            this.buttonGuest = new FontAwesome.Sharp.IconButton();
            this.buttonRoom = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.buttonNhapKho = new FontAwesome.Sharp.IconButton();
            this.buttonReportOption = new FontAwesome.Sharp.IconButton();
            this.buttonEmployeeOption = new FontAwesome.Sharp.IconButton();
            this.panelOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOption
            // 
            this.panelOption.AutoScroll = true;
            this.panelOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelOption.Controls.Add(this.buttonReportOption);
            this.panelOption.Controls.Add(this.buttonEmployeeOption);
            this.panelOption.Controls.Add(this.buttonNhapKho);
            this.panelOption.Controls.Add(this.buttonOrderRoom);
            this.panelOption.Controls.Add(this.buttonFood);
            this.panelOption.Controls.Add(this.buttonGuest);
            this.panelOption.Controls.Add(this.buttonRoom);
            this.panelOption.Controls.Add(this.panel2);
            this.panelOption.Controls.Add(this.panel1);
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOption.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelOption.Location = new System.Drawing.Point(0, 0);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(200, 780);
            this.panelOption.TabIndex = 2;
            // 
            // buttonOrderRoom
            // 
            this.buttonOrderRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrderRoom.FlatAppearance.BorderSize = 0;
            this.buttonOrderRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonOrderRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderRoom.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.buttonOrderRoom.ForeColor = System.Drawing.Color.Brown;
            this.buttonOrderRoom.IconChar = FontAwesome.Sharp.IconChar.MapMarker;
            this.buttonOrderRoom.IconColor = System.Drawing.Color.Brown;
            this.buttonOrderRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonOrderRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrderRoom.Location = new System.Drawing.Point(10, 150);
            this.buttonOrderRoom.Name = "buttonOrderRoom";
            this.buttonOrderRoom.Size = new System.Drawing.Size(180, 50);
            this.buttonOrderRoom.TabIndex = 12;
            this.buttonOrderRoom.Text = "Order";
            this.buttonOrderRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrderRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOrderRoom.UseVisualStyleBackColor = true;
            this.buttonOrderRoom.Click += new System.EventHandler(this.buttonOrderRoom_Click);
            // 
            // buttonFood
            // 
            this.buttonFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFood.FlatAppearance.BorderSize = 0;
            this.buttonFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFood.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.buttonFood.ForeColor = System.Drawing.Color.Brown;
            this.buttonFood.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.buttonFood.IconColor = System.Drawing.Color.Brown;
            this.buttonFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFood.Location = new System.Drawing.Point(10, 100);
            this.buttonFood.Name = "buttonFood";
            this.buttonFood.Size = new System.Drawing.Size(180, 50);
            this.buttonFood.TabIndex = 11;
            this.buttonFood.Text = "Food";
            this.buttonFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFood.UseVisualStyleBackColor = true;
            this.buttonFood.Click += new System.EventHandler(this.buttonFood_Click);
            // 
            // buttonGuest
            // 
            this.buttonGuest.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGuest.FlatAppearance.BorderSize = 0;
            this.buttonGuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuest.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.buttonGuest.ForeColor = System.Drawing.Color.Brown;
            this.buttonGuest.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.buttonGuest.IconColor = System.Drawing.Color.Brown;
            this.buttonGuest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuest.Location = new System.Drawing.Point(10, 50);
            this.buttonGuest.Name = "buttonGuest";
            this.buttonGuest.Size = new System.Drawing.Size(180, 50);
            this.buttonGuest.TabIndex = 10;
            this.buttonGuest.Text = "Guest";
            this.buttonGuest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonGuest.UseVisualStyleBackColor = true;
            this.buttonGuest.Click += new System.EventHandler(this.buttonGuest_Click);
            // 
            // buttonRoom
            // 
            this.buttonRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRoom.FlatAppearance.BorderSize = 0;
            this.buttonRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoom.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.buttonRoom.ForeColor = System.Drawing.Color.Brown;
            this.buttonRoom.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.buttonRoom.IconColor = System.Drawing.Color.Brown;
            this.buttonRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoom.Location = new System.Drawing.Point(10, 0);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(180, 50);
            this.buttonRoom.TabIndex = 9;
            this.buttonRoom.Text = "      Room";
            this.buttonRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoom.UseVisualStyleBackColor = true;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(190, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 780);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 780);
            this.panel1.TabIndex = 0;
            // 
            // panelShow
            // 
            this.panelShow.AutoScroll = true;
            this.panelShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(200, 0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1150, 780);
            this.panelShow.TabIndex = 4;
            // 
            // buttonNhapKho
            // 
            this.buttonNhapKho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonNhapKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNhapKho.FlatAppearance.BorderSize = 0;
            this.buttonNhapKho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNhapKho.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.buttonNhapKho.ForeColor = System.Drawing.Color.Brown;
            this.buttonNhapKho.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.buttonNhapKho.IconColor = System.Drawing.Color.Brown;
            this.buttonNhapKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonNhapKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNhapKho.Location = new System.Drawing.Point(10, 200);
            this.buttonNhapKho.Name = "buttonNhapKho";
            this.buttonNhapKho.Size = new System.Drawing.Size(180, 50);
            this.buttonNhapKho.TabIndex = 17;
            this.buttonNhapKho.Text = "Nhập kho";
            this.buttonNhapKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNhapKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNhapKho.UseVisualStyleBackColor = false;
            this.buttonNhapKho.Click += new System.EventHandler(this.buttonNhapKho_Click);
            // 
            // buttonReportOption
            // 
            this.buttonReportOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReportOption.FlatAppearance.BorderSize = 0;
            this.buttonReportOption.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonReportOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReportOption.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.buttonReportOption.ForeColor = System.Drawing.Color.Brown;
            this.buttonReportOption.IconChar = FontAwesome.Sharp.IconChar.File;
            this.buttonReportOption.IconColor = System.Drawing.Color.Brown;
            this.buttonReportOption.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonReportOption.IconSize = 40;
            this.buttonReportOption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReportOption.Location = new System.Drawing.Point(10, 300);
            this.buttonReportOption.Name = "buttonReportOption";
            this.buttonReportOption.Size = new System.Drawing.Size(180, 50);
            this.buttonReportOption.TabIndex = 19;
            this.buttonReportOption.Text = "Report";
            this.buttonReportOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReportOption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReportOption.UseVisualStyleBackColor = true;
            this.buttonReportOption.Click += new System.EventHandler(this.buttonReportOption_Click_1);
            // 
            // buttonEmployeeOption
            // 
            this.buttonEmployeeOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEmployeeOption.FlatAppearance.BorderSize = 0;
            this.buttonEmployeeOption.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonEmployeeOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEmployeeOption.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.buttonEmployeeOption.ForeColor = System.Drawing.Color.Brown;
            this.buttonEmployeeOption.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.buttonEmployeeOption.IconColor = System.Drawing.Color.Brown;
            this.buttonEmployeeOption.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonEmployeeOption.IconSize = 40;
            this.buttonEmployeeOption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployeeOption.Location = new System.Drawing.Point(10, 250);
            this.buttonEmployeeOption.Name = "buttonEmployeeOption";
            this.buttonEmployeeOption.Size = new System.Drawing.Size(180, 50);
            this.buttonEmployeeOption.TabIndex = 18;
            this.buttonEmployeeOption.Text = "Employee";
            this.buttonEmployeeOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployeeOption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEmployeeOption.UseVisualStyleBackColor = true;
            this.buttonEmployeeOption.Click += new System.EventHandler(this.buttonEmployeeOption_Click_1);
            // 
            // FormMenuManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 780);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuManager";
            this.Text = "FormMenuManager";
            this.Load += new System.EventHandler(this.FormMenuManager_Load);
            this.panelOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton buttonOrderRoom;
        private FontAwesome.Sharp.IconButton buttonFood;
        private FontAwesome.Sharp.IconButton buttonGuest;
        private FontAwesome.Sharp.IconButton buttonRoom;
        private FontAwesome.Sharp.IconButton buttonReportOption;
        private FontAwesome.Sharp.IconButton buttonEmployeeOption;
        private FontAwesome.Sharp.IconButton buttonNhapKho;
    }
}