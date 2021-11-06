
namespace Management_Hotel.View.ViewReceptionist
{
    partial class FormMenuReceptionist
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
            this.panelShow = new System.Windows.Forms.Panel();
            this.panelOption = new System.Windows.Forms.Panel();
            this.buttonOrderRoom = new FontAwesome.Sharp.IconButton();
            this.buttonGuest = new FontAwesome.Sharp.IconButton();
            this.buttonRoom = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFood = new FontAwesome.Sharp.IconButton();
            this.btnNhapKho = new FontAwesome.Sharp.IconButton();
            this.panelOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShow
            // 
            this.panelShow.AutoScroll = true;
            this.panelShow.BackColor = System.Drawing.Color.DimGray;
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(200, 0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1180, 680);
            this.panelShow.TabIndex = 9;
            // 
            // panelOption
            // 
            this.panelOption.AutoScroll = true;
            this.panelOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelOption.Controls.Add(this.btnNhapKho);
            this.panelOption.Controls.Add(this.buttonFood);
            this.panelOption.Controls.Add(this.buttonOrderRoom);
            this.panelOption.Controls.Add(this.buttonGuest);
            this.panelOption.Controls.Add(this.buttonRoom);
            this.panelOption.Controls.Add(this.panel2);
            this.panelOption.Controls.Add(this.panel1);
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOption.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelOption.Location = new System.Drawing.Point(0, 0);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(200, 680);
            this.panelOption.TabIndex = 8;
            // 
            // buttonOrderRoom
            // 
            this.buttonOrderRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonOrderRoom.FlatAppearance.BorderSize = 0;
            this.buttonOrderRoom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonOrderRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderRoom.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.buttonOrderRoom.ForeColor = System.Drawing.Color.Silver;
            this.buttonOrderRoom.IconChar = FontAwesome.Sharp.IconChar.MapMarker;
            this.buttonOrderRoom.IconColor = System.Drawing.Color.Silver;
            this.buttonOrderRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonOrderRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrderRoom.Location = new System.Drawing.Point(10, 100);
            this.buttonOrderRoom.Name = "buttonOrderRoom";
            this.buttonOrderRoom.Size = new System.Drawing.Size(180, 50);
            this.buttonOrderRoom.TabIndex = 8;
            this.buttonOrderRoom.Text = "Order";
            this.buttonOrderRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonOrderRoom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonOrderRoom.UseVisualStyleBackColor = true;
            this.buttonOrderRoom.Click += new System.EventHandler(this.buttonOrderRoom_Click);
            // 
            // buttonGuest
            // 
            this.buttonGuest.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGuest.FlatAppearance.BorderSize = 0;
            this.buttonGuest.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuest.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.buttonGuest.ForeColor = System.Drawing.Color.Silver;
            this.buttonGuest.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.buttonGuest.IconColor = System.Drawing.Color.Silver;
            this.buttonGuest.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonGuest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonGuest.Location = new System.Drawing.Point(10, 50);
            this.buttonGuest.Name = "buttonGuest";
            this.buttonGuest.Size = new System.Drawing.Size(180, 50);
            this.buttonGuest.TabIndex = 5;
            this.buttonGuest.Text = "Khách Hàng";
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
            this.buttonRoom.ForeColor = System.Drawing.Color.Silver;
            this.buttonRoom.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.buttonRoom.IconColor = System.Drawing.Color.Silver;
            this.buttonRoom.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoom.Location = new System.Drawing.Point(10, 0);
            this.buttonRoom.Name = "buttonRoom";
            this.buttonRoom.Size = new System.Drawing.Size(180, 50);
            this.buttonRoom.TabIndex = 4;
            this.buttonRoom.Text = "      Phòng";
            this.buttonRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRoom.UseVisualStyleBackColor = true;
            this.buttonRoom.Click += new System.EventHandler(this.buttonRoom_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(190, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 680);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 680);
            this.panel1.TabIndex = 0;
            // 
            // buttonFood
            // 
            this.buttonFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFood.FlatAppearance.BorderSize = 0;
            this.buttonFood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFood.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.buttonFood.ForeColor = System.Drawing.Color.Silver;
            this.buttonFood.IconChar = FontAwesome.Sharp.IconChar.Utensils;
            this.buttonFood.IconColor = System.Drawing.Color.Silver;
            this.buttonFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFood.Location = new System.Drawing.Point(10, 150);
            this.buttonFood.Name = "buttonFood";
            this.buttonFood.Size = new System.Drawing.Size(180, 50);
            this.buttonFood.TabIndex = 9;
            this.buttonFood.Text = "Kho";
            this.buttonFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonFood.UseVisualStyleBackColor = true;
            this.buttonFood.Click += new System.EventHandler(this.buttonFood_Click);
            // 
            // btnNhapKho
            // 
            this.btnNhapKho.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhapKho.FlatAppearance.BorderSize = 0;
            this.btnNhapKho.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnNhapKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapKho.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.btnNhapKho.ForeColor = System.Drawing.Color.Silver;
            this.btnNhapKho.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.btnNhapKho.IconColor = System.Drawing.Color.Silver;
            this.btnNhapKho.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhapKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapKho.Location = new System.Drawing.Point(10, 200);
            this.btnNhapKho.Name = "btnNhapKho";
            this.btnNhapKho.Size = new System.Drawing.Size(180, 50);
            this.btnNhapKho.TabIndex = 10;
            this.btnNhapKho.Text = "Nhập Kho";
            this.btnNhapKho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapKho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapKho.UseVisualStyleBackColor = true;
            this.btnNhapKho.Click += new System.EventHandler(this.btnNhapKho_Click);
            // 
            // FormMenuReceptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 680);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuReceptionist";
            this.Text = "FormMenuReceptionist";
            this.panelOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton buttonRoom;
        private FontAwesome.Sharp.IconButton buttonGuest;
        private FontAwesome.Sharp.IconButton buttonOrderRoom;
        private FontAwesome.Sharp.IconButton btnNhapKho;
        private FontAwesome.Sharp.IconButton buttonFood;
    }
}