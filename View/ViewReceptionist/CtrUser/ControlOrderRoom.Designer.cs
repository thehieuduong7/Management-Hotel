
namespace Management_Hotel.View.ViewReceptionist.CtrUser
{
    partial class ControlOrderRoom
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOrder = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // buttonOrder
            // 
            this.buttonOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOrder.FlatAppearance.BorderSize = 0;
            this.buttonOrder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrder.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrder.ForeColor = System.Drawing.Color.Blue;
            this.buttonOrder.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.buttonOrder.IconColor = System.Drawing.Color.Blue;
            this.buttonOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonOrder.IconSize = 130;
            this.buttonOrder.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonOrder.Location = new System.Drawing.Point(0, 0);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(150, 150);
            this.buttonOrder.TabIndex = 0;
            this.buttonOrder.Text = "Room";
            this.buttonOrder.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonOrder.UseVisualStyleBackColor = false;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // ControlOrderRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonOrder);
            this.Name = "ControlOrderRoom";
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton buttonOrder;
    }
}
