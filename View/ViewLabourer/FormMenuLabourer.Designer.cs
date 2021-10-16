
namespace Management_Hotel.View.ViewLabourer
{
    partial class FormMenuLabourer
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
            this.buttonCheckInOut = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.panelOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOption
            // 
            this.panelOption.AutoScroll = true;
            this.panelOption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panelOption.Controls.Add(this.buttonCheckInOut);
            this.panelOption.Controls.Add(this.panel2);
            this.panelOption.Controls.Add(this.panel1);
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelOption.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panelOption.Location = new System.Drawing.Point(0, 0);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(200, 680);
            this.panelOption.TabIndex = 5;
            // 
            // buttonCheckInOut
            // 
            this.buttonCheckInOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCheckInOut.FlatAppearance.BorderSize = 0;
            this.buttonCheckInOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.buttonCheckInOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCheckInOut.Font = new System.Drawing.Font("Lucida Console", 10F);
            this.buttonCheckInOut.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCheckInOut.IconChar = FontAwesome.Sharp.IconChar.ClipboardCheck;
            this.buttonCheckInOut.IconColor = System.Drawing.Color.Silver;
            this.buttonCheckInOut.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCheckInOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCheckInOut.Location = new System.Drawing.Point(10, 0);
            this.buttonCheckInOut.Name = "buttonCheckInOut";
            this.buttonCheckInOut.Size = new System.Drawing.Size(180, 50);
            this.buttonCheckInOut.TabIndex = 3;
            this.buttonCheckInOut.Text = "Check";
            this.buttonCheckInOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCheckInOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCheckInOut.UseVisualStyleBackColor = true;
            this.buttonCheckInOut.Click += new System.EventHandler(this.buttonCheckInOut_Click);
            this.buttonCheckInOut.MouseLeave += new System.EventHandler(this.buttonInformation_MouseLeave);
            this.buttonCheckInOut.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonInformation_MouseMove);
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
            // panelShow
            // 
            this.panelShow.AutoScroll = true;
            this.panelShow.BackColor = System.Drawing.Color.DimGray;
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(200, 0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1180, 680);
            this.panelShow.TabIndex = 7;
            // 
            // FormMenuLabourer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 680);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuLabourer";
            this.Text = "FormMenuLabourer";
            this.panelOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOption;
        private FontAwesome.Sharp.IconButton buttonCheckInOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelShow;
    }
}