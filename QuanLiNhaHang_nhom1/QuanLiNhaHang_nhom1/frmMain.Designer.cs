
namespace QuanLiNhaHang_nhom1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuTrangChu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLi = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLNCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLNV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLKH = new System.Windows.Forms.ToolStripMenuItem();
            this.nguyênLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThucDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTienIch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.bànĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmBànToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTrangChu,
            this.mnuQuanLi,
            this.mnuThucDon,
            this.mnuHoaDon,
            this.mnuThongKe,
            this.mnuTimKiem,
            this.mnuTroGiup,
            this.mnuTienIch,
            this.bànĂnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 4);
            this.menuStrip1.Size = new System.Drawing.Size(1750, 46);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuTrangChu
            // 
            this.mnuTrangChu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat,
            this.mnuTaiKhoan,
            this.mnuDangXuat});
            this.mnuTrangChu.Name = "mnuTrangChu";
            this.mnuTrangChu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuTrangChu.Size = new System.Drawing.Size(140, 38);
            this.mnuTrangChu.Text = "&Trang chủ";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuThoat.Size = new System.Drawing.Size(295, 44);
            this.mnuThoat.Text = "Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.Size = new System.Drawing.Size(295, 44);
            this.mnuTaiKhoan.Text = "Tài khoản";
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.Size = new System.Drawing.Size(295, 44);
            this.mnuDangXuat.Text = "Đăng xuất";
            // 
            // mnuQuanLi
            // 
            this.mnuQuanLi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLNCC,
            this.mnuQLNV,
            this.mnuQLKH,
            this.nguyênLiệuToolStripMenuItem});
            this.mnuQuanLi.Name = "mnuQuanLi";
            this.mnuQuanLi.Size = new System.Drawing.Size(112, 38);
            this.mnuQuanLi.Text = "&Quản lí";
            // 
            // mnuQLNCC
            // 
            this.mnuQLNCC.Name = "mnuQLNCC";
            this.mnuQLNCC.Size = new System.Drawing.Size(297, 44);
            this.mnuQLNCC.Text = "&Nhà cung cấp";
            this.mnuQLNCC.Click += new System.EventHandler(this.mnuQLNCC_Click);
            // 
            // mnuQLNV
            // 
            this.mnuQLNV.Name = "mnuQLNV";
            this.mnuQLNV.Size = new System.Drawing.Size(297, 44);
            this.mnuQLNV.Text = "&Nhân viên";
            this.mnuQLNV.Click += new System.EventHandler(this.mnuQLNV_Click);
            // 
            // mnuQLKH
            // 
            this.mnuQLKH.Name = "mnuQLKH";
            this.mnuQLKH.Size = new System.Drawing.Size(297, 44);
            this.mnuQLKH.Text = "&Khách hàng";
            this.mnuQLKH.Click += new System.EventHandler(this.mnuQLKH_Click);
            // 
            // nguyênLiệuToolStripMenuItem
            // 
            this.nguyênLiệuToolStripMenuItem.Name = "nguyênLiệuToolStripMenuItem";
            this.nguyênLiệuToolStripMenuItem.Size = new System.Drawing.Size(297, 44);
            this.nguyênLiệuToolStripMenuItem.Text = "Nguyên liệu";
            // 
            // mnuThucDon
            // 
            this.mnuThucDon.Name = "mnuThucDon";
            this.mnuThucDon.Size = new System.Drawing.Size(136, 38);
            this.mnuThucDon.Text = "&Thực đơn";
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.Size = new System.Drawing.Size(127, 38);
            this.mnuHoaDon.Text = "&Hóa đơn";
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(136, 38);
            this.mnuThongKe.Text = "&Thống kê";
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(134, 38);
            this.mnuTimKiem.Text = "&Tìm kiếm";
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.Size = new System.Drawing.Size(123, 38);
            this.mnuTroGiup.Text = "&Trợ giúp";
            // 
            // mnuTienIch
            // 
            this.mnuTienIch.Name = "mnuTienIch";
            this.mnuTienIch.Size = new System.Drawing.Size(119, 38);
            this.mnuTienIch.Text = "&Tiện ích";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 46);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1750, 30);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(46, 24);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(46, 24);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(46, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(224, 256);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(336, 487);
            this.button1.TabIndex = 4;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 256);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(394, 212);
            this.button2.TabIndex = 5;
            this.button2.Text = "Đặt bàn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(572, 479);
            this.button3.Margin = new System.Windows.Forms.Padding(6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(394, 212);
            this.button3.TabIndex = 6;
            this.button3.Text = "Hủy đặt bàn";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(572, 702);
            this.button4.Margin = new System.Windows.Forms.Padding(6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(394, 212);
            this.button4.TabIndex = 7;
            this.button4.Text = "Thống kê";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(224, 754);
            this.button5.Margin = new System.Windows.Forms.Padding(6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(336, 160);
            this.button5.TabIndex = 8;
            this.button5.Text = "Nhân viên";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // bànĂnToolStripMenuItem
            // 
            this.bànĂnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmBànToolStripMenuItem,
            this.testToolStripMenuItem});
            this.bànĂnToolStripMenuItem.Name = "bànĂnToolStripMenuItem";
            this.bànĂnToolStripMenuItem.Size = new System.Drawing.Size(108, 38);
            this.bànĂnToolStripMenuItem.Text = "Bàn ăn";
            // 
            // thêmBànToolStripMenuItem
            // 
            this.thêmBànToolStripMenuItem.Name = "thêmBànToolStripMenuItem";
            this.thêmBànToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.thêmBànToolStripMenuItem.Text = "Thêm bàn";
            this.thêmBànToolStripMenuItem.Click += new System.EventHandler(this.thêmBànToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.testToolStripMenuItem.Text = "test";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1750, 1254);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Phần mềm quản lí nhà hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuTrangChu;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLi;
        private System.Windows.Forms.ToolStripMenuItem mnuQLNCC;
        private System.Windows.Forms.ToolStripMenuItem mnuQLNV;
        private System.Windows.Forms.ToolStripMenuItem mnuQLKH;
        private System.Windows.Forms.ToolStripMenuItem mnuThucDon;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuTienIch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem nguyênLiệuToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ToolStripMenuItem bànĂnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmBànToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
    }
}

