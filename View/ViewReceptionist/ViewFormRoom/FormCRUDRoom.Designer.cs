
namespace Management_Hotel.View.ViewReceptionist
{
    partial class FormCRUDRoom
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
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonRefresh = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelShow = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Controls.Add(this.iconPictureBox1);
            this.panelLogo.Controls.Add(this.buttonRefresh);
            this.panelLogo.Controls.Add(this.flowLayoutPanel2);
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Controls.Add(this.textBoxSearch);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(1180, 193);
            this.panelLogo.TabIndex = 4;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonRefresh.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.buttonRefresh.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonRefresh.IconSize = 20;
            this.buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRefresh.Location = new System.Drawing.Point(355, 149);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(72, 30);
            this.buttonRefresh.TabIndex = 111;
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(171, 175);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(166, 3);
            this.flowLayoutPanel2.TabIndex = 41;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxSearch.Location = new System.Drawing.Point(171, 158);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(166, 19);
            this.textBoxSearch.TabIndex = 40;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(93, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Search:";
            // 
            // panelShow
            // 
            this.panelShow.AccessibleDescription = ".";
            this.panelShow.AutoScroll = true;
            this.panelShow.Location = new System.Drawing.Point(97, 199);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(1013, 469);
            this.panelShow.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(163, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 46);
            this.label1.TabIndex = 113;
            this.label1.Text = "ROOM";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.HouseUser;
            this.iconPictureBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 48;
            this.iconPictureBox1.Location = new System.Drawing.Point(100, 30);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(60, 60);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox1.TabIndex = 112;
            this.iconPictureBox1.TabStop = false;
            // 
            // FormCRUDRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1180, 680);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCRUDRoom";
            this.Text = "FormCRUDRoom";
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelShow;
        private FontAwesome.Sharp.IconButton buttonRefresh;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}