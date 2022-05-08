namespace PBL3
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabelDangXuat = new System.Windows.Forms.LinkLabel();
            this.linkLabelTenAdmin = new System.Windows.Forms.LinkLabel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonThongKe = new FontAwesome.Sharp.IconButton();
            this.iconButtonQuanLiNhanVien = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButtonQuanLiSanPham = new FontAwesome.Sharp.IconButton();
            this.panel2.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(200, 0);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(772, 492);
            this.panelDesktopPane.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabelDangXuat);
            this.panel2.Controls.Add(this.linkLabelTenAdmin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 393);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 99);
            this.panel2.TabIndex = 1;
            // 
            // linkLabelDangXuat
            // 
            this.linkLabelDangXuat.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(161)))));
            this.linkLabelDangXuat.AutoSize = true;
            this.linkLabelDangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.linkLabelDangXuat.LinkColor = System.Drawing.Color.White;
            this.linkLabelDangXuat.Location = new System.Drawing.Point(138, 76);
            this.linkLabelDangXuat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelDangXuat.Name = "linkLabelDangXuat";
            this.linkLabelDangXuat.Size = new System.Drawing.Size(62, 13);
            this.linkLabelDangXuat.TabIndex = 5;
            this.linkLabelDangXuat.TabStop = true;
            this.linkLabelDangXuat.Text = "(Đăng xuất)";
            this.linkLabelDangXuat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDangXuat_LinkClicked);
            // 
            // linkLabelTenAdmin
            // 
            this.linkLabelTenAdmin.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(161)))));
            this.linkLabelTenAdmin.AutoSize = true;
            this.linkLabelTenAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.linkLabelTenAdmin.LinkColor = System.Drawing.Color.White;
            this.linkLabelTenAdmin.Location = new System.Drawing.Point(4, 76);
            this.linkLabelTenAdmin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelTenAdmin.Name = "linkLabelTenAdmin";
            this.linkLabelTenAdmin.Size = new System.Drawing.Size(57, 13);
            this.linkLabelTenAdmin.TabIndex = 6;
            this.linkLabelTenAdmin.TabStop = true;
            this.linkLabelTenAdmin.Text = "Tên admin";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.iconButtonThongKe);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.iconButtonQuanLiNhanVien);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.iconButtonQuanLiSanPham);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 492);
            this.panelMenu.TabIndex = 3;
            // 
            // iconButtonThongKe
            // 
            this.iconButtonThongKe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.iconButtonThongKe.FlatAppearance.BorderSize = 0;
            this.iconButtonThongKe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.iconButtonThongKe.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThongKe.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconButtonThongKe.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonThongKe.IconSize = 30;
            this.iconButtonThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThongKe.Location = new System.Drawing.Point(0, 256);
            this.iconButtonThongKe.Name = "iconButtonThongKe";
            this.iconButtonThongKe.Size = new System.Drawing.Size(200, 74);
            this.iconButtonThongKe.TabIndex = 8;
            this.iconButtonThongKe.Text = "Thống kê";
            this.iconButtonThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonThongKe.UseVisualStyleBackColor = false;
            this.iconButtonThongKe.Click += new System.EventHandler(this.iconbuttonThongKe_Click);
            // 
            // iconButtonQuanLiNhanVien
            // 
            this.iconButtonQuanLiNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.iconButtonQuanLiNhanVien.FlatAppearance.BorderSize = 0;
            this.iconButtonQuanLiNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonQuanLiNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.iconButtonQuanLiNhanVien.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonQuanLiNhanVien.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.iconButtonQuanLiNhanVien.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonQuanLiNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonQuanLiNhanVien.IconSize = 30;
            this.iconButtonQuanLiNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQuanLiNhanVien.Location = new System.Drawing.Point(0, 182);
            this.iconButtonQuanLiNhanVien.Name = "iconButtonQuanLiNhanVien";
            this.iconButtonQuanLiNhanVien.Size = new System.Drawing.Size(200, 74);
            this.iconButtonQuanLiNhanVien.TabIndex = 7;
            this.iconButtonQuanLiNhanVien.Text = "Quản lí nhân viên";
            this.iconButtonQuanLiNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQuanLiNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonQuanLiNhanVien.UseVisualStyleBackColor = false;
            this.iconButtonQuanLiNhanVien.Click += new System.EventHandler(this.iconbuttonQuanLiNhanVien_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Location = new System.Drawing.Point(-8, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(217, 108);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(54, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 51);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // iconButtonQuanLiSanPham
            // 
            this.iconButtonQuanLiSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.iconButtonQuanLiSanPham.FlatAppearance.BorderSize = 0;
            this.iconButtonQuanLiSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonQuanLiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.iconButtonQuanLiSanPham.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonQuanLiSanPham.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.iconButtonQuanLiSanPham.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonQuanLiSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonQuanLiSanPham.IconSize = 30;
            this.iconButtonQuanLiSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQuanLiSanPham.Location = new System.Drawing.Point(0, 108);
            this.iconButtonQuanLiSanPham.Name = "iconButtonQuanLiSanPham";
            this.iconButtonQuanLiSanPham.Size = new System.Drawing.Size(200, 74);
            this.iconButtonQuanLiSanPham.TabIndex = 6;
            this.iconButtonQuanLiSanPham.Text = "Quản lí sản phẩm";
            this.iconButtonQuanLiSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonQuanLiSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonQuanLiSanPham.UseVisualStyleBackColor = false;
            this.iconButtonQuanLiSanPham.Click += new System.EventHandler(this.iconbuttonQuanLiSanPham_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 492);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FormAdmin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabelDangXuat;
        private System.Windows.Forms.LinkLabel linkLabelTenAdmin;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButtonQuanLiSanPham;
        private FontAwesome.Sharp.IconButton iconButtonThongKe;
        private FontAwesome.Sharp.IconButton iconButtonQuanLiNhanVien;
    }
}