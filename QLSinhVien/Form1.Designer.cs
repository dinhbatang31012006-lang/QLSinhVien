namespace QLSinhVien
{
    partial class Form1
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
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.butNganh = new System.Windows.Forms.Button();
            this.btnLop = new System.Windows.Forms.Button();
            this.btnSinhvien = new System.Windows.Forms.Button();
            this.btnDiem = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSidebar.Controls.Add(this.btnDangXuat);
            this.panelSidebar.Controls.Add(this.btnDiem);
            this.panelSidebar.Controls.Add(this.btnSinhvien);
            this.panelSidebar.Controls.Add(this.btnLop);
            this.panelSidebar.Controls.Add(this.butNganh);
            this.panelSidebar.Controls.Add(this.btnKhoa);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(153, 450);
            this.panelSidebar.TabIndex = 1;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelHeader
            // 
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(153, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(647, 85);
            this.panelHeader.TabIndex = 2;
            // 
            // btnKhoa
            // 
            this.btnKhoa.Location = new System.Drawing.Point(3, 67);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(147, 33);
            this.btnKhoa.TabIndex = 0;
            this.btnKhoa.Text = "Quản lý Khoa";
            this.btnKhoa.UseVisualStyleBackColor = true;
            // 
            // butNganh
            // 
            this.butNganh.Location = new System.Drawing.Point(3, 106);
            this.butNganh.Name = "butNganh";
            this.butNganh.Size = new System.Drawing.Size(147, 29);
            this.butNganh.TabIndex = 1;
            this.butNganh.Text = "Quản lý Ngành";
            this.butNganh.UseVisualStyleBackColor = true;
            // 
            // btnLop
            // 
            this.btnLop.Location = new System.Drawing.Point(3, 141);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(147, 26);
            this.btnLop.TabIndex = 2;
            this.btnLop.Text = "Quản lý Lớp";
            this.btnLop.UseVisualStyleBackColor = true;
            // 
            // btnSinhvien
            // 
            this.btnSinhvien.Location = new System.Drawing.Point(3, 173);
            this.btnSinhvien.Name = "btnSinhvien";
            this.btnSinhvien.Size = new System.Drawing.Size(147, 30);
            this.btnSinhvien.TabIndex = 3;
            this.btnSinhvien.Text = "Quản lý Sinh viên";
            this.btnSinhvien.UseVisualStyleBackColor = true;
            // 
            // btnDiem
            // 
            this.btnDiem.Location = new System.Drawing.Point(3, 209);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(147, 29);
            this.btnDiem.TabIndex = 4;
            this.btnDiem.Text = "Quản lý Điểm";
            this.btnDiem.UseVisualStyleBackColor = true;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(3, 244);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(147, 29);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(153, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(647, 365);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button btnDiem;
        private System.Windows.Forms.Button btnSinhvien;
        private System.Windows.Forms.Button btnLop;
        private System.Windows.Forms.Button butNganh;
        private System.Windows.Forms.Button btnKhoa;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

