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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.btnTrangchu = new System.Windows.Forms.Button();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnDiem = new System.Windows.Forms.Button();
            this.btnSinhvien = new System.Windows.Forms.Button();
            this.btnLop = new System.Windows.Forms.Button();
            this.butNganh = new System.Windows.Forms.Button();
            this.btnKhoa = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTen = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSidebar.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSidebar.Controls.Add(this.btnTrangchu);
            this.panelSidebar.Controls.Add(this.btnDangXuat);
            this.panelSidebar.Controls.Add(this.btnDiem);
            this.panelSidebar.Controls.Add(this.btnSinhvien);
            this.panelSidebar.Controls.Add(this.btnLop);
            this.panelSidebar.Controls.Add(this.butNganh);
            this.panelSidebar.Controls.Add(this.btnKhoa);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(152, 429);
            this.panelSidebar.TabIndex = 1;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnTrangchu
            // 
            this.btnTrangchu.Image = ((System.Drawing.Image)(resources.GetObject("btnTrangchu.Image")));
            this.btnTrangchu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrangchu.Location = new System.Drawing.Point(0, 23);
            this.btnTrangchu.Name = "btnTrangchu";
            this.btnTrangchu.Size = new System.Drawing.Size(150, 45);
            this.btnTrangchu.TabIndex = 6;
            this.btnTrangchu.Text = "Trang chủ";
            this.btnTrangchu.UseVisualStyleBackColor = true;
            this.btnTrangchu.Click += new System.EventHandler(this.btnTrangchu_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 275);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(150, 45);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDiem
            // 
            this.btnDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnDiem.Image")));
            this.btnDiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDiem.Location = new System.Drawing.Point(0, 224);
            this.btnDiem.Name = "btnDiem";
            this.btnDiem.Size = new System.Drawing.Size(150, 45);
            this.btnDiem.TabIndex = 4;
            this.btnDiem.Text = "Điểm";
            this.btnDiem.UseVisualStyleBackColor = true;
            // 
            // btnSinhvien
            // 
            this.btnSinhvien.Image = ((System.Drawing.Image)(resources.GetObject("btnSinhvien.Image")));
            this.btnSinhvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinhvien.Location = new System.Drawing.Point(0, 173);
            this.btnSinhvien.Name = "btnSinhvien";
            this.btnSinhvien.Size = new System.Drawing.Size(150, 45);
            this.btnSinhvien.TabIndex = 3;
            this.btnSinhvien.Text = " Sinh viên";
            this.btnSinhvien.UseVisualStyleBackColor = true;
            this.btnSinhvien.Click += new System.EventHandler(this.btnSinhvien_Click);
            // 
            // btnLop
            // 
            this.btnLop.Location = new System.Drawing.Point(0, 173);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(150, 45);
            this.btnLop.TabIndex = 2;
            this.btnLop.Text = "Lớp";
            this.btnLop.UseVisualStyleBackColor = true;
            // 
            // butNganh
            // 
            this.butNganh.Image = ((System.Drawing.Image)(resources.GetObject("butNganh.Image")));
            this.butNganh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butNganh.Location = new System.Drawing.Point(0, 122);
            this.butNganh.Name = "butNganh";
            this.butNganh.Size = new System.Drawing.Size(150, 45);
            this.butNganh.TabIndex = 1;
            this.butNganh.Text = " Ngành";
            this.butNganh.UseVisualStyleBackColor = true;
            // 
            // btnKhoa
            // 
            this.btnKhoa.Image = ((System.Drawing.Image)(resources.GetObject("btnKhoa.Image")));
            this.btnKhoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhoa.Location = new System.Drawing.Point(0, 71);
            this.btnKhoa.Name = "btnKhoa";
            this.btnKhoa.Size = new System.Drawing.Size(150, 45);
            this.btnKhoa.TabIndex = 0;
            this.btnKhoa.Text = " Khoa";
            this.btnKhoa.UseVisualStyleBackColor = true;
            this.btnKhoa.Click += new System.EventHandler(this.btnKhoa_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblTen);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(152, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(648, 49);
            this.panelHeader.TabIndex = 2;
            this.panelHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.panelHeader_Paint);
            // 
            // lblTen
            // 
            this.lblTen.AutoEllipsis = true;
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTen.Location = new System.Drawing.Point(91, 9);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(450, 32);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "HỆ THỐNG QUẢN LÝ SINH VIÊN";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.label1);
            this.pnlContent.Location = new System.Drawing.Point(152, 44);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(648, 382);
            this.pnlContent.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSidebar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
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
        private System.Windows.Forms.Button btnTrangchu;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label label1;
    }
}

