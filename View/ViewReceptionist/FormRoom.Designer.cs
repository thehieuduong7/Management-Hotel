
namespace Management_Hotel.View.ViewReceptionist
{
    partial class FormRoom
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
            this.panelSearch = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.panelListRoom = new System.Windows.Forms.Panel();
            this.panelShow.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOption
            // 
            this.panelOption.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOption.Location = new System.Drawing.Point(0, 580);
            this.panelOption.Name = "panelOption";
            this.panelOption.Size = new System.Drawing.Size(1180, 100);
            this.panelOption.TabIndex = 0;
            // 
            // panelSearch
            // 
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSearch.Location = new System.Drawing.Point(975, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(205, 580);
            this.panelSearch.TabIndex = 1;
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.panelListRoom);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(0, 0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(975, 580);
            this.panelShow.TabIndex = 2;
            // 
            // panelListRoom
            // 
            this.panelListRoom.Location = new System.Drawing.Point(147, 182);
            this.panelListRoom.Name = "panelListRoom";
            this.panelListRoom.Size = new System.Drawing.Size(785, 274);
            this.panelListRoom.TabIndex = 0;
            // 
            // FormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 680);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRoom";
            this.Text = "FormRoom";
            this.panelShow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOption;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Panel panelListRoom;
    }
}