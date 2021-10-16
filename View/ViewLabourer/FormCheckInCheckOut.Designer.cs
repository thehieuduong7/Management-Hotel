
namespace Management_Hotel.View.ViewLabourer
{
    partial class FormCheckInCheckOut
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
            this.components = new System.ComponentModel.Container();
            this.progressBarTimeWork = new System.Windows.Forms.ProgressBar();
            this.panelShow = new System.Windows.Forms.Panel();
            this.timerWork = new System.Windows.Forms.Timer(this.components);
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.labelTimeWork = new System.Windows.Forms.Label();
            this.buttonCheckIn = new FontAwesome.Sharp.IconButton();
            this.radioNight = new System.Windows.Forms.RadioButton();
            this.radioMorning = new System.Windows.Forms.RadioButton();
            this.radioAfternoon = new System.Windows.Forms.RadioButton();
            this.labelAnnoucement = new System.Windows.Forms.Label();
            this.panelRadioButton = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelRadioButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarTimeWork
            // 
            this.progressBarTimeWork.BackColor = System.Drawing.Color.DimGray;
            this.progressBarTimeWork.ForeColor = System.Drawing.Color.LightCoral;
            this.progressBarTimeWork.Location = new System.Drawing.Point(79, 350);
            this.progressBarTimeWork.Name = "progressBarTimeWork";
            this.progressBarTimeWork.Size = new System.Drawing.Size(596, 62);
            this.progressBarTimeWork.TabIndex = 2;
            // 
            // panelShow
            // 
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelShow.Location = new System.Drawing.Point(740, 0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(376, 636);
            this.panelShow.TabIndex = 3;
            // 
            // timerWork
            // 
            this.timerWork.Tick += new System.EventHandler(this.timerWork_Tick);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconPictureBox1.IconColor = System.Drawing.Color.LimeGreen;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 71;
            this.iconPictureBox1.Location = new System.Drawing.Point(80, 273);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(74, 71);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // labelTimeWork
            // 
            this.labelTimeWork.AutoSize = true;
            this.labelTimeWork.Font = new System.Drawing.Font("Wide Latin", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeWork.ForeColor = System.Drawing.Color.LimeGreen;
            this.labelTimeWork.Location = new System.Drawing.Point(161, 273);
            this.labelTimeWork.Name = "labelTimeWork";
            this.labelTimeWork.Size = new System.Drawing.Size(260, 59);
            this.labelTimeWork.TabIndex = 5;
            this.labelTimeWork.Text = "0h00";
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.BackColor = System.Drawing.Color.Silver;
            this.buttonCheckIn.Font = new System.Drawing.Font("Cooper Black", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckIn.ForeColor = System.Drawing.Color.White;
            this.buttonCheckIn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonCheckIn.IconColor = System.Drawing.Color.Black;
            this.buttonCheckIn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonCheckIn.Location = new System.Drawing.Point(226, 463);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(279, 119);
            this.buttonCheckIn.TabIndex = 6;
            this.buttonCheckIn.Text = "IN";
            this.buttonCheckIn.UseVisualStyleBackColor = false;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // radioNight
            // 
            this.radioNight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.radioNight.AutoSize = true;
            this.radioNight.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNight.ForeColor = System.Drawing.Color.Silver;
            this.radioNight.Location = new System.Drawing.Point(505, 73);
            this.radioNight.Name = "radioNight";
            this.radioNight.Size = new System.Drawing.Size(110, 34);
            this.radioNight.TabIndex = 10;
            this.radioNight.Text = "Night";
            this.radioNight.UseVisualStyleBackColor = true;
            this.radioNight.CheckedChanged += new System.EventHandler(this.radioNight_CheckedChanged);
            // 
            // radioMorning
            // 
            this.radioMorning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.radioMorning.AutoSize = true;
            this.radioMorning.Checked = true;
            this.radioMorning.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMorning.ForeColor = System.Drawing.Color.Silver;
            this.radioMorning.Location = new System.Drawing.Point(107, 73);
            this.radioMorning.Name = "radioMorning";
            this.radioMorning.Size = new System.Drawing.Size(146, 34);
            this.radioMorning.TabIndex = 8;
            this.radioMorning.TabStop = true;
            this.radioMorning.Text = "Morning";
            this.radioMorning.UseVisualStyleBackColor = true;
            this.radioMorning.CheckedChanged += new System.EventHandler(this.radioMorning_CheckedChanged);
            // 
            // radioAfternoon
            // 
            this.radioAfternoon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.radioAfternoon.AutoSize = true;
            this.radioAfternoon.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioAfternoon.ForeColor = System.Drawing.Color.Silver;
            this.radioAfternoon.Location = new System.Drawing.Point(289, 73);
            this.radioAfternoon.Name = "radioAfternoon";
            this.radioAfternoon.Size = new System.Drawing.Size(177, 34);
            this.radioAfternoon.TabIndex = 9;
            this.radioAfternoon.Text = "Afternoon";
            this.radioAfternoon.UseVisualStyleBackColor = true;
            this.radioAfternoon.CheckedChanged += new System.EventHandler(this.radioAfternoon_CheckedChanged);
            // 
            // labelAnnoucement
            // 
            this.labelAnnoucement.AutoSize = true;
            this.labelAnnoucement.Font = new System.Drawing.Font("Cooper Black", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnnoucement.ForeColor = System.Drawing.Color.Silver;
            this.labelAnnoucement.Location = new System.Drawing.Point(119, 202);
            this.labelAnnoucement.Name = "labelAnnoucement";
            this.labelAnnoucement.Size = new System.Drawing.Size(96, 31);
            this.labelAnnoucement.TabIndex = 11;
            this.labelAnnoucement.Text = "label2";
            // 
            // panelRadioButton
            // 
            this.panelRadioButton.Controls.Add(this.radioAfternoon);
            this.panelRadioButton.Controls.Add(this.radioMorning);
            this.panelRadioButton.Controls.Add(this.radioNight);
            this.panelRadioButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRadioButton.Location = new System.Drawing.Point(0, 0);
            this.panelRadioButton.Name = "panelRadioButton";
            this.panelRadioButton.Size = new System.Drawing.Size(740, 147);
            this.panelRadioButton.TabIndex = 12;
            // 
            // FormCheckInCheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1116, 636);
            this.Controls.Add(this.panelRadioButton);
            this.Controls.Add(this.labelAnnoucement);
            this.Controls.Add(this.buttonCheckIn);
            this.Controls.Add(this.labelTimeWork);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.progressBarTimeWork);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCheckInCheckOut";
            this.Text = "FormCheckInCheckOut";
            this.Load += new System.EventHandler(this.FormCheckInCheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelRadioButton.ResumeLayout(false);
            this.panelRadioButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBarTimeWork;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Timer timerWork;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label labelTimeWork;
        private FontAwesome.Sharp.IconButton buttonCheckIn;
        private System.Windows.Forms.RadioButton radioNight;
        private System.Windows.Forms.RadioButton radioMorning;
        private System.Windows.Forms.RadioButton radioAfternoon;
        private System.Windows.Forms.Label labelAnnoucement;
        private System.Windows.Forms.Panel panelRadioButton;
    }
}