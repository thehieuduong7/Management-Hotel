﻿
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
            this.labelName = new System.Windows.Forms.Label();
            this.pictureFood = new System.Windows.Forms.PictureBox();
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
            this.buttonMoney.Location = new System.Drawing.Point(0, 115);
            this.buttonMoney.Name = "buttonMoney";
            this.buttonMoney.Size = new System.Drawing.Size(148, 33);
            this.buttonMoney.TabIndex = 0;
            this.buttonMoney.Text = "giá";
            this.buttonMoney.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMoney.UseVisualStyleBackColor = false;
            this.buttonMoney.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelName.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(3, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 15);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "name";
            // 
            // pictureFood
            // 
            this.pictureFood.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureFood.Location = new System.Drawing.Point(0, 24);
            this.pictureFood.Name = "pictureFood";
            this.pictureFood.Size = new System.Drawing.Size(148, 91);
            this.pictureFood.TabIndex = 9;
            this.pictureFood.TabStop = false;
            // 
            // ControlCRUDFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureFood);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonMoney);
            this.Name = "ControlCRUDFood";
            this.Size = new System.Drawing.Size(148, 148);
            ((System.ComponentModel.ISupportInitialize)(this.pictureFood)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton buttonMoney;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureFood;
    }
}
