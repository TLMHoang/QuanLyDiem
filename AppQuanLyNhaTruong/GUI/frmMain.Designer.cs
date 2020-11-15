namespace GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bsLop = new System.Windows.Forms.BindingSource(this.components);
            this.btnDiem = new System.Windows.Forms.Button();
            this.btnPCMonHoc = new System.Windows.Forms.Button();
            this.dgvDanhSachLop = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(670, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.LogOutToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.menuToolStripMenuItem.Text = "Xin chào ";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.adminToolStripMenuItem.Text = "Đổi mật khẩu";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // LogOutToolStripMenuItem
            // 
            this.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem";
            this.LogOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LogOutToolStripMenuItem.Text = "Đăng Xuất";
            this.LogOutToolStripMenuItem.Click += new System.EventHandler(this.LogOutToolStripMenuItem_Click);
            // 
            // btnDiem
            // 
            this.btnDiem.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDiem.FlatAppearance.BorderSize = 0;
            this.btnDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiem.ForeColor = System.Drawing.Color.White;
            this.btnDiem.Location = new System.Drawing.Point(234, 275);
            this.btnDiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(186, 76);
            this.btnDiem.TabIndex = 3;
            this.btnDiem.Text = "Quản lý điểm";
            this.btnDiem.UseVisualStyleBackColor = false;
            this.btnDiem.Click += new System.EventHandler(this.btnDiem_Click);
            // 
            // btnPCMonHoc
            // 
            this.btnPCMonHoc.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPCMonHoc.FlatAppearance.BorderSize = 0;
            this.btnPCMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPCMonHoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPCMonHoc.ForeColor = System.Drawing.Color.White;
            this.btnPCMonHoc.Location = new System.Drawing.Point(234, 171);
            this.btnPCMonHoc.Margin = new System.Windows.Forms.Padding(2);
            this.btnPCMonHoc.Name = "btnPCMonHoc";
            this.btnPCMonHoc.Size = new System.Drawing.Size(186, 76);
            this.btnPCMonHoc.TabIndex = 7;
            this.btnPCMonHoc.Text = "Danh Sách Lớp";
            this.btnPCMonHoc.UseVisualStyleBackColor = false;
            this.btnPCMonHoc.Click += new System.EventHandler(this.btnPCMonHoc_Click);
            // 
            // dgvDanhSachLop
            // 
            this.dgvDanhSachLop.AutoGenerateColumns = false;
            this.dgvDanhSachLop.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachLop.DataSource = this.bsLop;
            this.dgvDanhSachLop.Location = new System.Drawing.Point(11, 381);
            this.dgvDanhSachLop.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDanhSachLop.Name = "dgvDanhSachLop";
            this.dgvDanhSachLop.RowHeadersWidth = 30;
            this.dgvDanhSachLop.RowTemplate.Height = 24;
            this.dgvDanhSachLop.Size = new System.Drawing.Size(651, 185);
            this.dgvDanhSachLop.TabIndex = 2;
            this.dgvDanhSachLop.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvDanhSachLop_CellBeginEdit);
            this.dgvDanhSachLop.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLop_CellContentClick);
            this.dgvDanhSachLop.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachLop_CellEndEdit);
            this.dgvDanhSachLop.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgvDanhSachLop_UserAddedRow);
            this.dgvDanhSachLop.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvDanhSachLop_UserDeletingRow);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 72);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quản Lý";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 586);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDanhSachLop);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnPCMonHoc);
            this.Controls.Add(this.btnDiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Điểm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LogOutToolStripMenuItem;
        private System.Windows.Forms.BindingSource bsLop;
        private System.Windows.Forms.Button btnDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLopDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPCMonHoc;
        private System.Windows.Forms.DataGridView dgvDanhSachLop;
        private System.Windows.Forms.Label label1;
    }
}