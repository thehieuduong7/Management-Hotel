
namespace Management_Hotel.View.ViewReceptionist.CtrUser
{
    partial class ControlCRUDFood
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
            this.buttonMoney = new FontAwesome.Sharp.IconButton();
            this.pictureFood = new FontAwesome.Sharp.IconPictureBox();
            this.labelName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureFood)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMoney
            // 
            this.buttonMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonMoney.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonMoney.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMoney.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.buttonMoney.IconColor = System.Drawing.Color.Black;
            this.buttonMoney.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonMoney.IconSize = 35;
            this.buttonMoney.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMoney.Location = new System.Drawing.Point(0, 140);
            this.buttonMoney.Name = "buttonMoney";
            this.buttonMoney.Size = new System.Drawing.Size(135, 35);
            this.buttonMoney.TabIndex = 0;
            this.buttonMoney.Text = "giá";
            this.buttonMoney.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMoney.UseVisualStyleBackColor = false;
            this.buttonMoney.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // pictureFood
            // 
            this.pictureFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureFood.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureFood.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pictureFood.IconChar = FontAwesome.Sharp.IconChar.Apple;
            this.pictureFood.IconColor = System.Drawing.SystemColors.ControlText;
            this.pictureFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pictureFood.IconSize = 135;
            this.pictureFood.Location = new System.Drawing.Point(0, 0);
            this.pictureFood.Name = "pictureFood";
            this.pictureFood.Size = new System.Drawing.Size(135, 140);
            this.pictureFood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureFood.TabIndex = 1;
            this.pictureFood.TabStop = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.White;
            this.labelName.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(3, 5);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 15);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "name";
            // 
            // ControlCRUDFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureFood);
            this.Controls.Add(this.buttonMoney);
            this.Name = "ControlCRUDFood";
            this.Size = new System.Drawing.Size(135, 175);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton buttonMoney;
        private FontAwesome.Sharp.IconPictureBox pictureFood;
        private System.Windows.Forms.Label labelName;
    }
}
