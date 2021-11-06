
namespace Management_Hotel.View.ViewReceptionist
{
    partial class FormCRUDGuest
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelShow = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.dataGridViewGuest = new System.Windows.Forms.DataGridView();
            this.panelControl = new System.Windows.Forms.Panel();
            this.buttonAdd = new FontAwesome.Sharp.IconButton();
            this.panelStatic = new System.Windows.Forms.Panel();
            this.buttonReset = new FontAwesome.Sharp.IconButton();
            this.panelShow.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuest)).BeginInit();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelShow
            // 
            this.panelShow.AutoScroll = true;
            this.panelShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelShow.Controls.Add(this.panel2);
            this.panelShow.Controls.Add(this.label3);
            this.panelShow.Controls.Add(this.panel1);
            this.panelShow.Controls.Add(this.dataGridViewGuest);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(200, 0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(964, 641);
            this.panelShow.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.textBoxSearch);
            this.panel2.Controls.Add(this.iconPictureBox2);
            this.panel2.Location = new System.Drawing.Point(55, 189);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(252, 33);
            this.panel2.TabIndex = 8;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.BackColor = System.Drawing.Color.Silver;
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(29, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(217, 24);
            this.textBoxSearch.TabIndex = 6;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Silver;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 23;
            this.iconPictureBox2.Location = new System.Drawing.Point(0, 1);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(23, 29);
            this.iconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconPictureBox2.TabIndex = 7;
            this.iconPictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(49, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Search name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 140);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(121, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "MANAGEMENT GUEST";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.DimGray;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 41;
            this.iconPictureBox1.Location = new System.Drawing.Point(55, 56);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(46, 41);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // dataGridViewGuest
            // 
            this.dataGridViewGuest.AllowUserToAddRows = false;
            this.dataGridViewGuest.AllowUserToDeleteRows = false;
            this.dataGridViewGuest.AllowUserToResizeColumns = false;
            this.dataGridViewGuest.AllowUserToResizeRows = false;
            this.dataGridViewGuest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridViewGuest.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridViewGuest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewGuest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewGuest.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGuest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewGuest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewGuest.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewGuest.EnableHeadersVisualStyles = false;
            this.dataGridViewGuest.Location = new System.Drawing.Point(55, 241);
            this.dataGridViewGuest.Name = "dataGridViewGuest";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewGuest.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewGuest.RowHeadersVisible = false;
            this.dataGridViewGuest.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewGuest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGuest.Size = new System.Drawing.Size(847, 413);
            this.dataGridViewGuest.TabIndex = 4;
            this.dataGridViewGuest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGuest_CellContentClick);
            this.dataGridViewGuest.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewGuest_CellMouseMove);
            this.dataGridViewGuest.MouseLeave += new System.EventHandler(this.dataGridViewGuest_MouseLeave);
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.Gray;
            this.panelControl.Controls.Add(this.buttonReset);
            this.panelControl.Controls.Add(this.buttonAdd);
            this.panelControl.Controls.Add(this.panelStatic);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(200, 641);
            this.panelControl.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.DimGray;
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAdd.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.ForeColor = System.Drawing.Color.Silver;
            this.buttonAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.buttonAdd.IconColor = System.Drawing.Color.Silver;
            this.buttonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.Location = new System.Drawing.Point(0, 140);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(200, 63);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "New guest";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelStatic
            // 
            this.panelStatic.AutoScroll = true;
            this.panelStatic.BackColor = System.Drawing.Color.Gray;
            this.panelStatic.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatic.Location = new System.Drawing.Point(0, 0);
            this.panelStatic.Name = "panelStatic";
            this.panelStatic.Size = new System.Drawing.Size(200, 140);
            this.panelStatic.TabIndex = 43;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.DimGray;
            this.buttonReset.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReset.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.Silver;
            this.buttonReset.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.buttonReset.IconColor = System.Drawing.Color.Silver;
            this.buttonReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonReset.IconSize = 40;
            this.buttonReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReset.Location = new System.Drawing.Point(0, 203);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(200, 63);
            this.buttonReset.TabIndex = 47;
            this.buttonReset.Text = "New guest";
            this.buttonReset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // FormCRUDGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1164, 641);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCRUDGuest";
            this.Text = "FormCRUDGuest";
            this.panelShow.ResumeLayout(false);
            this.panelShow.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGuest)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelStatic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewGuest;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxSearch;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton buttonAdd;
        private FontAwesome.Sharp.IconButton buttonReset;
    }
}