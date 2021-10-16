
namespace Management_Hotel.View.ViewManager
{
    partial class FormDivisionEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelControl = new System.Windows.Forms.Panel();
            this.labelWeek = new System.Windows.Forms.Label();
            this.panelDropControl = new System.Windows.Forms.Panel();
            this.buttonDropControl = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.dataGridViewDivision = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonNextView = new FontAwesome.Sharp.IconPictureBox();
            this.buttonPreviousView = new FontAwesome.Sharp.IconPictureBox();
            this.timerHighLightLableWeek = new System.Windows.Forms.Timer(this.components);
            this.panelDropControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDropControl)).BeginInit();
            this.panelShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDivision)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNextView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPreviousView)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(800, 127);
            this.panelControl.TabIndex = 0;
            this.panelControl.Visible = false;
            // 
            // labelWeek
            // 
            this.labelWeek.AutoSize = true;
            this.labelWeek.BackColor = System.Drawing.Color.DimGray;
            this.labelWeek.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeek.ForeColor = System.Drawing.Color.Silver;
            this.labelWeek.Location = new System.Drawing.Point(593, 3);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Size = new System.Drawing.Size(61, 22);
            this.labelWeek.TabIndex = 6;
            this.labelWeek.Text = "From";
            // 
            // panelDropControl
            // 
            this.panelDropControl.Controls.Add(this.buttonDropControl);
            this.panelDropControl.Controls.Add(this.panel1);
            this.panelDropControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDropControl.Location = new System.Drawing.Point(0, 127);
            this.panelDropControl.Name = "panelDropControl";
            this.panelDropControl.Size = new System.Drawing.Size(800, 26);
            this.panelDropControl.TabIndex = 1;
            // 
            // buttonDropControl
            // 
            this.buttonDropControl.BackColor = System.Drawing.Color.DimGray;
            this.buttonDropControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonDropControl.ForeColor = System.Drawing.Color.Silver;
            this.buttonDropControl.IconChar = FontAwesome.Sharp.IconChar.CaretDown;
            this.buttonDropControl.IconColor = System.Drawing.Color.Silver;
            this.buttonDropControl.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.buttonDropControl.IconSize = 26;
            this.buttonDropControl.Location = new System.Drawing.Point(714, 0);
            this.buttonDropControl.Name = "buttonDropControl";
            this.buttonDropControl.Size = new System.Drawing.Size(32, 26);
            this.buttonDropControl.TabIndex = 0;
            this.buttonDropControl.TabStop = false;
            this.buttonDropControl.Click += new System.EventHandler(this.buttonDropControl_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(746, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(54, 26);
            this.panel1.TabIndex = 1;
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.dataGridViewDivision);
            this.panelShow.Controls.Add(this.panel5);
            this.panelShow.Controls.Add(this.panel4);
            this.panelShow.Controls.Add(this.panel2);
            this.panelShow.Controls.Add(this.panel3);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShow.Location = new System.Drawing.Point(0, 153);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(800, 297);
            this.panelShow.TabIndex = 2;
            // 
            // dataGridViewDivision
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewDivision.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDivision.BackgroundColor = System.Drawing.Color.DimGray;
            this.dataGridViewDivision.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dataGridViewDivision.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDivision.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDivision.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDivision.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewDivision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDivision.GridColor = System.Drawing.Color.Black;
            this.dataGridViewDivision.Location = new System.Drawing.Point(50, 37);
            this.dataGridViewDivision.Name = "dataGridViewDivision";
            this.dataGridViewDivision.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDivision.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewDivision.RowHeadersVisible = false;
            this.dataGridViewDivision.RowTemplate.Height = 40;
            this.dataGridViewDivision.RowTemplate.ReadOnly = true;
            this.dataGridViewDivision.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDivision.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewDivision.Size = new System.Drawing.Size(700, 227);
            this.dataGridViewDivision.TabIndex = 2;
            this.dataGridViewDivision.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewDivision_DataBindingComplete);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(50, 264);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(700, 33);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(750, 37);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 260);
            this.panel4.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 260);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelWeek);
            this.panel3.Controls.Add(this.buttonNextView);
            this.panel3.Controls.Add(this.buttonPreviousView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 37);
            this.panel3.TabIndex = 1;
            // 
            // buttonNextView
            // 
            this.buttonNextView.BackColor = System.Drawing.Color.DimGray;
            this.buttonNextView.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonNextView.ForeColor = System.Drawing.Color.Silver;
            this.buttonNextView.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleRight;
            this.buttonNextView.IconColor = System.Drawing.Color.Silver;
            this.buttonNextView.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonNextView.IconSize = 30;
            this.buttonNextView.Location = new System.Drawing.Point(30, 0);
            this.buttonNextView.Name = "buttonNextView";
            this.buttonNextView.Size = new System.Drawing.Size(30, 37);
            this.buttonNextView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.buttonNextView.TabIndex = 1;
            this.buttonNextView.TabStop = false;
            this.buttonNextView.Click += new System.EventHandler(this.buttonNextView_Click);
            this.buttonNextView.MouseLeave += new System.EventHandler(this.buttonNextView_MouseLeave);
            this.buttonNextView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonNextView_MouseMove);
            // 
            // buttonPreviousView
            // 
            this.buttonPreviousView.BackColor = System.Drawing.Color.DimGray;
            this.buttonPreviousView.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPreviousView.ForeColor = System.Drawing.Color.Silver;
            this.buttonPreviousView.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft;
            this.buttonPreviousView.IconColor = System.Drawing.Color.Silver;
            this.buttonPreviousView.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.buttonPreviousView.IconSize = 30;
            this.buttonPreviousView.Location = new System.Drawing.Point(0, 0);
            this.buttonPreviousView.Name = "buttonPreviousView";
            this.buttonPreviousView.Size = new System.Drawing.Size(30, 37);
            this.buttonPreviousView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.buttonPreviousView.TabIndex = 0;
            this.buttonPreviousView.TabStop = false;
            this.buttonPreviousView.Click += new System.EventHandler(this.buttonPreviousView_Click);
            this.buttonPreviousView.MouseLeave += new System.EventHandler(this.buttonNextView_MouseLeave);
            this.buttonPreviousView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.buttonNextView_MouseMove);
            // 
            // timerHighLightLableWeek
            // 
            this.timerHighLightLableWeek.Tick += new System.EventHandler(this.timerHighLightLableWeek_Tick);
            // 
            // FormDivisionEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelShow);
            this.Controls.Add(this.panelDropControl);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDivisionEmployee";
            this.Text = "FormDivisionEmployee";
            this.Load += new System.EventHandler(this.FormDivisionEmployee_Load);
            this.panelDropControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonDropControl)).EndInit();
            this.panelShow.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDivision)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNextView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPreviousView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label labelWeek;
        private System.Windows.Forms.Panel panelDropControl;
        private FontAwesome.Sharp.IconPictureBox buttonDropControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox buttonNextView;
        private FontAwesome.Sharp.IconPictureBox buttonPreviousView;
        private System.Windows.Forms.DataGridView dataGridViewDivision;
        private System.Windows.Forms.Timer timerHighLightLableWeek;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}