
namespace Management_Hotel.View.ViewManager
{
    partial class FormAddEmployee
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
            this.panelSet = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelShowAccount = new System.Windows.Forms.Panel();
            this.buttonSetAcc = new FontAwesome.Sharp.IconButton();
            this.panelShowInfor = new System.Windows.Forms.Panel();
            this.buttonSetInfor = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelSet.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSet
            // 
            this.panelSet.AutoScroll = true;
            this.panelSet.BackColor = System.Drawing.Color.DimGray;
            this.panelSet.Controls.Add(this.panelButton);
            this.panelSet.Controls.Add(this.panelShowAccount);
            this.panelSet.Controls.Add(this.buttonSetAcc);
            this.panelSet.Controls.Add(this.panelShowInfor);
            this.panelSet.Controls.Add(this.buttonSetInfor);
            this.panelSet.Controls.Add(this.panel5);
            this.panelSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSet.Location = new System.Drawing.Point(0, 0);
            this.panelSet.Name = "panelSet";
            this.panelSet.Size = new System.Drawing.Size(464, 461);
            this.panelSet.TabIndex = 43;
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.DarkGray;
            this.panelButton.Controls.Add(this.buttonAdd);
            this.panelButton.Controls.Add(this.buttonCancel);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelButton.Location = new System.Drawing.Point(0, 674);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(447, 237);
            this.panelButton.TabIndex = 12;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.Cyan;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Red;
            this.buttonAdd.Location = new System.Drawing.Point(97, 17);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(98, 42);
            this.buttonAdd.TabIndex = 40;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Cyan;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Red;
            this.buttonCancel.Location = new System.Drawing.Point(259, 17);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 42);
            this.buttonCancel.TabIndex = 41;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelShowAccount
            // 
            this.panelShowAccount.BackColor = System.Drawing.Color.DarkGray;
            this.panelShowAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelShowAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShowAccount.Location = new System.Drawing.Point(0, 509);
            this.panelShowAccount.Name = "panelShowAccount";
            this.panelShowAccount.Size = new System.Drawing.Size(447, 165);
            this.panelShowAccount.TabIndex = 11;
            // 
            // buttonSetAcc
            // 
            this.buttonSetAcc.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSetAcc.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetAcc.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleDown;
            this.buttonSetAcc.IconColor = System.Drawing.Color.Red;
            this.buttonSetAcc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSetAcc.IconSize = 30;
            this.buttonSetAcc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetAcc.Location = new System.Drawing.Point(0, 473);
            this.buttonSetAcc.Name = "buttonSetAcc";
            this.buttonSetAcc.Size = new System.Drawing.Size(447, 36);
            this.buttonSetAcc.TabIndex = 10;
            this.buttonSetAcc.Text = "       Set account";
            this.buttonSetAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetAcc.UseVisualStyleBackColor = true;
            this.buttonSetAcc.Click += new System.EventHandler(this.buttonSetAcc_Click);
            // 
            // panelShowInfor
            // 
            this.panelShowInfor.BackColor = System.Drawing.Color.DarkGray;
            this.panelShowInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShowInfor.Location = new System.Drawing.Point(0, 121);
            this.panelShowInfor.Name = "panelShowInfor";
            this.panelShowInfor.Size = new System.Drawing.Size(447, 352);
            this.panelShowInfor.TabIndex = 6;
            // 
            // buttonSetInfor
            // 
            this.buttonSetInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSetInfor.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetInfor.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleDown;
            this.buttonSetInfor.IconColor = System.Drawing.Color.Red;
            this.buttonSetInfor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonSetInfor.IconSize = 30;
            this.buttonSetInfor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetInfor.Location = new System.Drawing.Point(0, 81);
            this.buttonSetInfor.Name = "buttonSetInfor";
            this.buttonSetInfor.Size = new System.Drawing.Size(447, 40);
            this.buttonSetInfor.TabIndex = 5;
            this.buttonSetInfor.Text = "       Set information";
            this.buttonSetInfor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetInfor.UseVisualStyleBackColor = true;
            this.buttonSetInfor.Click += new System.EventHandler(this.buttonSetInfor_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.iconPictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(447, 81);
            this.panel5.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(66, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "New Employee";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.DarkGray;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Silver;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Silver;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 48;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(57, 48);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(464, 461);
            this.Controls.Add(this.panelSet);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddEmployee";
            this.Text = "FormAddEmployee";
            this.Load += new System.EventHandler(this.FormAddEmployee_Load);
            this.panelSet.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSet;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelShowInfor;
        private FontAwesome.Sharp.IconButton buttonSetInfor;
        private System.Windows.Forms.Panel panelShowAccount;
        private FontAwesome.Sharp.IconButton buttonSetAcc;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelButton;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
    }
}