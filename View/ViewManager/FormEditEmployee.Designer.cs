
namespace Management_Hotel.View.ViewManager
{
    partial class FormEditEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLeft = new FontAwesome.Sharp.IconPictureBox();
            this.panelSet = new System.Windows.Forms.Panel();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonAdd = new FontAwesome.Sharp.IconButton();
            this.buttonRefresh = new FontAwesome.Sharp.IconButton();
            this.buttonRemove = new FontAwesome.Sharp.IconButton();
            this.buttonEdit = new FontAwesome.Sharp.IconButton();
            this.panelShowAccount = new System.Windows.Forms.Panel();
            this.buttonSetAcc = new FontAwesome.Sharp.IconButton();
            this.panelShowInfor = new System.Windows.Forms.Panel();
            this.buttonSetInfor = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelDataGrid = new System.Windows.Forms.Panel();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new FontAwesome.Sharp.IconPictureBox();
            this.panelBackControl = new System.Windows.Forms.Panel();
            this.buttonBackEdit = new FontAwesome.Sharp.IconPictureBox();
            this.panelControlOption = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLeft)).BeginInit();
            this.panelSet.SuspendLayout();
            this.panelButton.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.panelShow.SuspendLayout();
            this.panelDataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.panel3.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).BeginInit();
            this.panelBackControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonBackEdit)).BeginInit();
            this.panelControlOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonLeft);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1143, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(41, 461);
            this.panel1.TabIndex = 3;
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.DarkGray;
            this.buttonLeft.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleRight;
            this.buttonLeft.IconColor = System.Drawing.Color.White;
            this.buttonLeft.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonLeft.Location = new System.Drawing.Point(3, 233);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(32, 35);
            this.buttonLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buttonLeft.TabIndex = 0;
            this.buttonLeft.TabStop = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            this.buttonLeft.MouseLeave += new System.EventHandler(this.buttonLeft_MouseLeave);
            this.buttonLeft.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonLeft_MouseMove);
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
            this.panelSet.Size = new System.Drawing.Size(445, 417);
            this.panelSet.TabIndex = 51;
            // 
            // panelButton
            // 
            this.panelButton.BackColor = System.Drawing.Color.DarkGray;
            this.panelButton.Controls.Add(this.buttonAdd);
            this.panelButton.Controls.Add(this.buttonRefresh);
            this.panelButton.Controls.Add(this.buttonRemove);
            this.panelButton.Controls.Add(this.buttonEdit);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButton.Location = new System.Drawing.Point(0, 636);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(428, 74);
            this.panelButton.TabIndex = 45;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.buttonAdd.IconColor = System.Drawing.Color.Black;
            this.buttonAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonAdd.IconSize = 25;
            this.buttonAdd.Location = new System.Drawing.Point(16, 20);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(94, 42);
            this.buttonAdd.TabIndex = 47;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.buttonRefresh.IconColor = System.Drawing.Color.Black;
            this.buttonRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonRefresh.IconSize = 25;
            this.buttonRefresh.Location = new System.Drawing.Point(341, 20);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(94, 42);
            this.buttonRefresh.TabIndex = 46;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemove.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.buttonRemove.IconColor = System.Drawing.Color.Black;
            this.buttonRemove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonRemove.IconSize = 25;
            this.buttonRemove.Location = new System.Drawing.Point(235, 20);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(94, 42);
            this.buttonRemove.TabIndex = 45;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Cooper Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.buttonEdit.IconColor = System.Drawing.Color.Black;
            this.buttonEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonEdit.IconSize = 25;
            this.buttonEdit.Location = new System.Drawing.Point(125, 20);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(94, 42);
            this.buttonEdit.TabIndex = 44;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // panelShowAccount
            // 
            this.panelShowAccount.BackColor = System.Drawing.Color.DarkGray;
            this.panelShowAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelShowAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShowAccount.Location = new System.Drawing.Point(0, 504);
            this.panelShowAccount.Name = "panelShowAccount";
            this.panelShowAccount.Size = new System.Drawing.Size(428, 132);
            this.panelShowAccount.TabIndex = 10;
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
            this.buttonSetAcc.Location = new System.Drawing.Point(0, 468);
            this.buttonSetAcc.Name = "buttonSetAcc";
            this.buttonSetAcc.Size = new System.Drawing.Size(428, 36);
            this.buttonSetAcc.TabIndex = 9;
            this.buttonSetAcc.Text = "       Set account";
            this.buttonSetAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetAcc.UseVisualStyleBackColor = true;
            this.buttonSetAcc.Click += new System.EventHandler(this.buttonSetAcc_Click);
            // 
            // panelShowInfor
            // 
            this.panelShowInfor.BackColor = System.Drawing.Color.DarkGray;
            this.panelShowInfor.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShowInfor.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelShowInfor.ForeColor = System.Drawing.Color.Maroon;
            this.panelShowInfor.Location = new System.Drawing.Point(0, 121);
            this.panelShowInfor.Name = "panelShowInfor";
            this.panelShowInfor.Size = new System.Drawing.Size(428, 347);
            this.panelShowInfor.TabIndex = 4;
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
            this.buttonSetInfor.Size = new System.Drawing.Size(428, 40);
            this.buttonSetInfor.TabIndex = 2;
            this.buttonSetInfor.Text = "       Set information";
            this.buttonSetInfor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSetInfor.UseVisualStyleBackColor = true;
            this.buttonSetInfor.Click += new System.EventHandler(this.buttonSetInfor_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(428, 81);
            this.panel5.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.DimGray;
            this.panelControl.Controls.Add(this.panelSet);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl.Location = new System.Drawing.Point(0, 44);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(445, 417);
            this.panelControl.TabIndex = 53;
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.panel4);
            this.panelShow.Controls.Add(this.panelDataGrid);
            this.panelShow.Controls.Add(this.panel6);
            this.panelShow.Controls.Add(this.panel3);
            this.panelShow.Controls.Add(this.panelSearch);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(0, 0);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(698, 461);
            this.panelShow.TabIndex = 57;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 125);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 221);
            this.panel4.TabIndex = 53;
            // 
            // panelDataGrid
            // 
            this.panelDataGrid.Controls.Add(this.dataGridViewEmployee);
            this.panelDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDataGrid.Location = new System.Drawing.Point(0, 125);
            this.panelDataGrid.Name = "panelDataGrid";
            this.panelDataGrid.Size = new System.Drawing.Size(688, 221);
            this.panelDataGrid.TabIndex = 43;
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.Color.DarkGray;
            this.dataGridViewEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewEmployee.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewEmployee.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(688, 221);
            this.dataGridViewEmployee.TabIndex = 0;
            this.dataGridViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellContentClick);
            this.dataGridViewEmployee.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellMouseLeave);
            this.dataGridViewEmployee.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewGuest_CellMouseMove);
            this.dataGridViewEmployee.MouseLeave += new System.EventHandler(this.dataGridViewGuest_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(688, 125);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 221);
            this.panel6.TabIndex = 54;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panelTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 346);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(698, 115);
            this.panel3.TabIndex = 50;
            // 
            // panelTotal
            // 
            this.panelTotal.AutoScroll = true;
            this.panelTotal.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelTotal.Location = new System.Drawing.Point(353, 0);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(345, 115);
            this.panelTotal.TabIndex = 49;
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(698, 125);
            this.panelSearch.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID, first name, last name";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.textBoxSearch.Location = new System.Drawing.Point(37, 59);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(231, 30);
            this.textBoxSearch.TabIndex = 1;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.buttonSearch.IconColor = System.Drawing.SystemColors.ControlText;
            this.buttonSearch.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonSearch.IconSize = 30;
            this.buttonSearch.Location = new System.Drawing.Point(7, 59);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(95, 30);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.TabStop = false;
            this.buttonSearch.MouseLeave += new System.EventHandler(this.buttonSearch_MouseLeave);
            this.buttonSearch.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonSearch_MouseMove);
            // 
            // panelBackControl
            // 
            this.panelBackControl.BackColor = System.Drawing.Color.DarkGray;
            this.panelBackControl.Controls.Add(this.buttonBackEdit);
            this.panelBackControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBackControl.Location = new System.Drawing.Point(0, 0);
            this.panelBackControl.Name = "panelBackControl";
            this.panelBackControl.Size = new System.Drawing.Size(445, 44);
            this.panelBackControl.TabIndex = 0;
            // 
            // buttonBackEdit
            // 
            this.buttonBackEdit.BackColor = System.Drawing.Color.DarkGray;
            this.buttonBackEdit.IconChar = FontAwesome.Sharp.IconChar.ArrowCircleLeft;
            this.buttonBackEdit.IconColor = System.Drawing.Color.White;
            this.buttonBackEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonBackEdit.Location = new System.Drawing.Point(0, 6);
            this.buttonBackEdit.Name = "buttonBackEdit";
            this.buttonBackEdit.Size = new System.Drawing.Size(32, 32);
            this.buttonBackEdit.TabIndex = 0;
            this.buttonBackEdit.TabStop = false;
            this.buttonBackEdit.Visible = false;
            this.buttonBackEdit.Click += new System.EventHandler(this.buttonBackEdit_Click);
            // 
            // panelControlOption
            // 
            this.panelControlOption.Controls.Add(this.panelControl);
            this.panelControlOption.Controls.Add(this.panelBackControl);
            this.panelControlOption.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControlOption.Location = new System.Drawing.Point(698, 0);
            this.panelControlOption.Name = "panelControlOption";
            this.panelControlOption.Size = new System.Drawing.Size(445, 461);
            this.panelControlOption.TabIndex = 58;
            // 
            // FormEditEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelControlOption);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEditEmployee";
            this.Text = "FormEditEmployee";
            this.Load += new System.EventHandler(this.FormEditEmployee_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonLeft)).EndInit();
            this.panelSet.ResumeLayout(false);
            this.panelButton.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelShow.ResumeLayout(false);
            this.panelDataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).EndInit();
            this.panelBackControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonBackEdit)).EndInit();
            this.panelControlOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox buttonLeft;
        private System.Windows.Forms.Panel panelSet;
        private System.Windows.Forms.Panel panelShowAccount;
        private FontAwesome.Sharp.IconButton buttonSetAcc;
        private System.Windows.Forms.Panel panelShowInfor;
        private FontAwesome.Sharp.IconButton buttonSetInfor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panelButton;
        private FontAwesome.Sharp.IconButton buttonRefresh;
        private FontAwesome.Sharp.IconButton buttonRemove;
        private FontAwesome.Sharp.IconButton buttonEdit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private FontAwesome.Sharp.IconButton buttonAdd;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Panel panelDataGrid;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private FontAwesome.Sharp.IconPictureBox buttonSearch;
        private System.Windows.Forms.Panel panelBackControl;
        private FontAwesome.Sharp.IconPictureBox buttonBackEdit;
        private System.Windows.Forms.Panel panelControlOption;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
    }
}