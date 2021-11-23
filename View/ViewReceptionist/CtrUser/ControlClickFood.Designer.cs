
namespace Management_Hotel.View.ViewReceptionist.CtrUser
{
    partial class ControlClickFood
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
            this.labelName = new System.Windows.Forms.Label();
            this.buttonMoney = new FontAwesome.Sharp.IconButton();
            this.pictureFood = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFood)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelName.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 15);
            this.labelName.TabIndex = 11;
            this.labelName.Text = "name";
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // buttonMoney
            // 
            this.buttonMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonMoney.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonMoney.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoney.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonMoney.IconColor = System.Drawing.Color.Black;
            this.buttonMoney.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMoney.IconSize = 35;
            this.buttonMoney.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMoney.Location = new System.Drawing.Point(0, 115);
            this.buttonMoney.Name = "buttonMoney";
            this.buttonMoney.Size = new System.Drawing.Size(150, 35);
            this.buttonMoney.TabIndex = 9;
            this.buttonMoney.Text = "giá";
            this.buttonMoney.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMoney.UseVisualStyleBackColor = false;
            this.buttonMoney.Click += new System.EventHandler(this.buttonMoney_Click);
            // 
            // pictureFood
            // 
            this.pictureFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureFood.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureFood.Location = new System.Drawing.Point(0, 18);
            this.pictureFood.Name = "pictureFood";
            this.pictureFood.Size = new System.Drawing.Size(150, 97);
            this.pictureFood.TabIndex = 12;
            this.pictureFood.TabStop = false;
            // 
            // ControlClickFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.pictureFood);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonMoney);
            this.Name = "ControlClickFood";
            ((System.ComponentModel.ISupportInitialize)(this.pictureFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private FontAwesome.Sharp.IconButton buttonMoney;
        private System.Windows.Forms.PictureBox pictureFood;
    }
}
