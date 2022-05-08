namespace PBL3
{
    partial class FormNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkLabelDangXuat = new System.Windows.Forms.LinkLabel();
            this.linkLabelTenNhanVien = new System.Windows.Forms.LinkLabel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButtonLichSuHoaDon = new FontAwesome.Sharp.IconButton();
            this.iconButtonBaoHanh = new FontAwesome.Sharp.IconButton();
            this.iconButtonSanPham = new FontAwesome.Sharp.IconButton();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.linkLabelDangXuat);
            this.panel2.Controls.Add(this.linkLabelTenNhanVien);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 392);
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
            this.linkLabelDangXuat.Location = new System.Drawing.Point(138, 77);
            this.linkLabelDangXuat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelDangXuat.Name = "linkLabelDangXuat";
            this.linkLabelDangXuat.Size = new System.Drawing.Size(62, 13);
            this.linkLabelDangXuat.TabIndex = 5;
            this.linkLabelDangXuat.TabStop = true;
            this.linkLabelDangXuat.Text = "(Đăng xuất)";
            this.linkLabelDangXuat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDangXuat_LinkClicked);
            // 
            // linkLabelTenNhanVien
            // 
            this.linkLabelTenNhanVien.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(161)))));
            this.linkLabelTenNhanVien.AutoSize = true;
            this.linkLabelTenNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.linkLabelTenNhanVien.LinkColor = System.Drawing.Color.White;
            this.linkLabelTenNhanVien.Location = new System.Drawing.Point(4, 77);
            this.linkLabelTenNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelTenNhanVien.Name = "linkLabelTenNhanVien";
            this.linkLabelTenNhanVien.Size = new System.Drawing.Size(76, 13);
            this.linkLabelTenNhanVien.TabIndex = 6;
            this.linkLabelTenNhanVien.TabStop = true;
            this.linkLabelTenNhanVien.Text = "Tên nhân viên";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.iconButtonLichSuHoaDon);
            this.panelMenu.Controls.Add(this.iconButtonBaoHanh);
            this.panelMenu.Controls.Add(this.iconButtonSanPham);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 491);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButtonLichSuHoaDon
            // 
            this.iconButtonLichSuHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.iconButtonLichSuHoaDon.FlatAppearance.BorderSize = 0;
            this.iconButtonLichSuHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLichSuHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.iconButtonLichSuHoaDon.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonLichSuHoaDon.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconButtonLichSuHoaDon.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonLichSuHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLichSuHoaDon.IconSize = 30;
            this.iconButtonLichSuHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLichSuHoaDon.Location = new System.Drawing.Point(0, 256);
            this.iconButtonLichSuHoaDon.Name = "iconButtonLichSuHoaDon";
            this.iconButtonLichSuHoaDon.Size = new System.Drawing.Size(200, 74);
            this.iconButtonLichSuHoaDon.TabIndex = 7;
            this.iconButtonLichSuHoaDon.Text = "Lịch sử hoá đơn";
            this.iconButtonLichSuHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLichSuHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonLichSuHoaDon.UseVisualStyleBackColor = false;
            this.iconButtonLichSuHoaDon.Click += new System.EventHandler(this.iconButtonLichSuHoaDon_Click);
            // 
            // iconButtonBaoHanh
            // 
            this.iconButtonBaoHanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.iconButtonBaoHanh.FlatAppearance.BorderSize = 0;
            this.iconButtonBaoHanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBaoHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.iconButtonBaoHanh.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonBaoHanh.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.iconButtonBaoHanh.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonBaoHanh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBaoHanh.IconSize = 30;
            this.iconButtonBaoHanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBaoHanh.Location = new System.Drawing.Point(0, 182);
            this.iconButtonBaoHanh.Name = "iconButtonBaoHanh";
            this.iconButtonBaoHanh.Size = new System.Drawing.Size(200, 74);
            this.iconButtonBaoHanh.TabIndex = 6;
            this.iconButtonBaoHanh.Text = "Bảo hành";
            this.iconButtonBaoHanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBaoHanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonBaoHanh.UseVisualStyleBackColor = false;
            this.iconButtonBaoHanh.Click += new System.EventHandler(this.iconButtonBaoHanh_Click);
            // 
            // iconButtonSanPham
            // 
            this.iconButtonSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.iconButtonSanPham.FlatAppearance.BorderSize = 0;
            this.iconButtonSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.iconButtonSanPham.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSanPham.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButtonSanPham.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSanPham.IconSize = 30;
            this.iconButtonSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSanPham.Location = new System.Drawing.Point(0, 108);
            this.iconButtonSanPham.Name = "iconButtonSanPham";
            this.iconButtonSanPham.Size = new System.Drawing.Size(200, 74);
            this.iconButtonSanPham.TabIndex = 5;
            this.iconButtonSanPham.Text = "Sản phẩm";
            this.iconButtonSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSanPham.UseVisualStyleBackColor = false;
            this.iconButtonSanPham.Click += new System.EventHandler(this.iconButtonSanPham_Click);
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(200, 0);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(772, 491);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(972, 491);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FormNhanVien";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linkLabelDangXuat;
        private System.Windows.Forms.LinkLabel linkLabelTenNhanVien;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelDesktopPane;
        private FontAwesome.Sharp.IconButton iconButtonSanPham;
        private FontAwesome.Sharp.IconButton iconButtonBaoHanh;
        private FontAwesome.Sharp.IconButton iconButtonLichSuHoaDon;
    }
}