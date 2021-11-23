
namespace Management_Hotel.View.ViewAdmin
{
    partial class FormMenuAdmin
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
            this.buttonAccount = new FontAwesome.Sharp.IconButton();
            this.buttonEmployeeOption = new FontAwesome.Sharp.IconButton();
            this.panelOption = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.panelOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAccount
            // 
            this.buttonAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAccount.FlatAppearance.BorderSize = 0;
            this.buttonAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.buttonAccount.ForeColor = System.Drawing.Color.Brown;
            this.buttonAccount.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.buttonAccount.IconColor = System.Drawing.Color.Brown;
            this.buttonAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAccount.IconSize = 40;
            this.buttonAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccount.Location = new System.Drawing.Point(10, 50);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(180, 50);
            this.buttonAccount.TabIndex = 15;
            this.buttonAccount.Text = "Account";
            this.buttonAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAccount.UseVisualStyleBackColor = true;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
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
            this.buttonEmployeeOption.Location = new System.Drawing.Point(10, 0);
            this.buttonEmployeeOption.Name = "buttonEmployeeOption";
            this.buttonEmployeeOption.Size = new System.Drawing.Size(180, 50);
            this.buttonEmployeeOption.TabIndex = 13;
            this.buttonEmployeeOption.Text = "Employee";
            this.buttonEmployeeOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEmployeeOption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEmployeeOption.UseVisualStyleBackColor = true;
            this.buttonEmployeeOption.Click += new System.EventHandler(this.buttonEmployeeOption_Click);
            // 
            // panelOption
            // 
            this.panelOption.AutoScroll = true;
            this.panelOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panelOption.Controls.Add(this.buttonAccount);
            this.panelOption.Controls.Add(this.buttonEmployeeOption);
            this.panelOption.Controls.Add(this.panel2);
            this.panelOption.Controls.Add(this.panel1);
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOption.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelOption.Location = new System.Drawing.Point(0, 0);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(200, 780);
            this.panelOption.TabIndex = 5;
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
            this.panelShow.TabIndex = 7;
            // 
            // FormMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 780);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuAdmin";
            this.Text = "FormMenuAdmin";
            this.panelOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton buttonAccount;
        private FontAwesome.Sharp.IconButton buttonEmployeeOption;
        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelShow;
    }
}