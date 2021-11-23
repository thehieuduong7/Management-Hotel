
namespace Management_Hotel.View.ViewReceptionist.CtrUser
{
    partial class ControlRoom
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
            this.buttonEdit = new FontAwesome.Sharp.IconButton();
            this.buttonRemove = new FontAwesome.Sharp.IconButton();
            this.label_room = new System.Windows.Forms.Label();
            this.pictureLogo = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEdit.FlatAppearance.BorderSize = 0;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("MV Boli", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEdit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonEdit.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonEdit.IconSize = 35;
            this.buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEdit.Location = new System.Drawing.Point(0, 117);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(150, 33);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Money";
            this.buttonEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            this.buttonRemove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.IconChar = FontAwesome.Sharp.IconChar.None;
            this.buttonRemove.IconColor = System.Drawing.Color.Black;
            this.buttonRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonRemove.Location = new System.Drawing.Point(121, -1);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(28, 21);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "X";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // label_room
            // 
            this.label_room.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_room.AutoSize = true;
            this.label_room.BackColor = System.Drawing.Color.LightGray;
            this.label_room.Font = new System.Drawing.Font("Lucida Calligraphy", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_room.ForeColor = System.Drawing.Color.Black;
            this.label_room.Location = new System.Drawing.Point(47, 34);
            this.label_room.Name = "label_room";
            this.label_room.Size = new System.Drawing.Size(52, 17);
            this.label_room.TabIndex = 4;
            this.label_room.Text = "Room";
            this.label_room.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pictureLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureLogo.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.pictureLogo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureLogo.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.pictureLogo.IconSize = 150;
            this.pictureLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(150, 150);
            this.pictureLogo.TabIndex = 0;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.Click += new System.EventHandler(this.pictureLogo_Click);
            // 
            // ControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label_room);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.pictureLogo);
            this.Name = "ControlRoom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton buttonEdit;
        private FontAwesome.Sharp.IconButton buttonRemove;
        private System.Windows.Forms.Label label_room;
        private FontAwesome.Sharp.IconPictureBox pictureLogo;
    }
}
