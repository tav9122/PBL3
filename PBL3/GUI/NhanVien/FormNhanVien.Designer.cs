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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhanVien));
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButtonLichSuHoaDon = new FontAwesome.Sharp.IconButton();
            this.iconButtonBaoHanh = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.linkLabelTenNhanVien = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconButtonSanPham = new FontAwesome.Sharp.IconButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.thôngTinNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.Location = new System.Drawing.Point(200, 18);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(800, 527);
            this.panelDesktopPane.TabIndex = 6;
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMaximize.BackgroundImage")));
            this.buttonMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Location = new System.Drawing.Point(772, 0);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(21, 18);
            this.buttonMaximize.TabIndex = 1;
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.BackgroundImage")));
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(747, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(21, 18);
            this.buttonMinimize.TabIndex = 0;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.iconButtonLichSuHoaDon);
            this.panelMenu.Controls.Add(this.iconButtonBaoHanh);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.iconButtonSanPham);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 545);
            this.panelMenu.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(161)))));
            this.panel1.Location = new System.Drawing.Point(24, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 1);
            this.panel1.TabIndex = 0;
            // 
            // iconButtonLichSuHoaDon
            // 
            this.iconButtonLichSuHoaDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.iconButtonLichSuHoaDon.FlatAppearance.BorderSize = 0;
            this.iconButtonLichSuHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonLichSuHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.iconButtonLichSuHoaDon.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonLichSuHoaDon.IconChar = FontAwesome.Sharp.IconChar.Clock;
            this.iconButtonLichSuHoaDon.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonLichSuHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonLichSuHoaDon.IconSize = 30;
            this.iconButtonLichSuHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLichSuHoaDon.Location = new System.Drawing.Point(0, 269);
            this.iconButtonLichSuHoaDon.Name = "iconButtonLichSuHoaDon";
            this.iconButtonLichSuHoaDon.Size = new System.Drawing.Size(200, 74);
            this.iconButtonLichSuHoaDon.TabIndex = 8;
            this.iconButtonLichSuHoaDon.Text = "Lịch sử hoá đơn";
            this.iconButtonLichSuHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonLichSuHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonLichSuHoaDon.UseVisualStyleBackColor = false;
            this.iconButtonLichSuHoaDon.Click += new System.EventHandler(this.iconButtonLichSuHoaDon_Click);
            // 
            // iconButtonBaoHanh
            // 
            this.iconButtonBaoHanh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.iconButtonBaoHanh.FlatAppearance.BorderSize = 0;
            this.iconButtonBaoHanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonBaoHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.iconButtonBaoHanh.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonBaoHanh.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.iconButtonBaoHanh.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonBaoHanh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonBaoHanh.IconSize = 30;
            this.iconButtonBaoHanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBaoHanh.Location = new System.Drawing.Point(0, 195);
            this.iconButtonBaoHanh.Name = "iconButtonBaoHanh";
            this.iconButtonBaoHanh.Size = new System.Drawing.Size(200, 74);
            this.iconButtonBaoHanh.TabIndex = 7;
            this.iconButtonBaoHanh.Text = "Bảo hành";
            this.iconButtonBaoHanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonBaoHanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonBaoHanh.UseVisualStyleBackColor = false;
            this.iconButtonBaoHanh.Click += new System.EventHandler(this.iconButtonBaoHanh_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.linkLabelTenNhanVien);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // linkLabelTenNhanVien
            // 
            this.linkLabelTenNhanVien.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(161)))));
            this.linkLabelTenNhanVien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelTenNhanVien.LinkColor = System.Drawing.Color.White;
            this.linkLabelTenNhanVien.Location = new System.Drawing.Point(33, 82);
            this.linkLabelTenNhanVien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabelTenNhanVien.Name = "linkLabelTenNhanVien";
            this.linkLabelTenNhanVien.Size = new System.Drawing.Size(136, 18);
            this.linkLabelTenNhanVien.TabIndex = 7;
            this.linkLabelTenNhanVien.TabStop = true;
            this.linkLabelTenNhanVien.Text = "TÊN NHÂN VIÊN";
            this.linkLabelTenNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabelTenNhanVien.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelTenNhanVien_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(62, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // iconButtonSanPham
            // 
            this.iconButtonSanPham.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.iconButtonSanPham.FlatAppearance.BorderSize = 0;
            this.iconButtonSanPham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.iconButtonSanPham.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSanPham.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconButtonSanPham.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSanPham.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSanPham.IconSize = 30;
            this.iconButtonSanPham.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSanPham.Location = new System.Drawing.Point(0, 121);
            this.iconButtonSanPham.Name = "iconButtonSanPham";
            this.iconButtonSanPham.Size = new System.Drawing.Size(200, 74);
            this.iconButtonSanPham.TabIndex = 6;
            this.iconButtonSanPham.Text = "Sản phẩm";
            this.iconButtonSanPham.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSanPham.UseVisualStyleBackColor = false;
            this.iconButtonSanPham.Click += new System.EventHandler(this.iconButtonSanPham_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.contextMenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(0, 0);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinNhânViênToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 48);
            // 
            // thôngTinNhânViênToolStripMenuItem
            // 
            this.thôngTinNhânViênToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thôngTinNhânViênToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.thôngTinNhânViênToolStripMenuItem.Name = "thôngTinNhânViênToolStripMenuItem";
            this.thôngTinNhânViênToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.thôngTinNhânViênToolStripMenuItem.Text = "Thông tin nhân viên";
            this.thôngTinNhânViênToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.thôngTinNhânViênToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.đăngXuấtToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            this.đăngXuấtToolStripMenuItem.MouseEnter += new System.EventHandler(this.ToolStripMenuItem_MouseEnter);
            this.đăngXuấtToolStripMenuItem.MouseLeave += new System.EventHandler(this.ToolStripMenuItem_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.buttonMaximize);
            this.panel2.Controls.Add(this.buttonMinimize);
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 18);
            this.panel2.TabIndex = 7;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 545);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FormNhanVien";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButtonLichSuHoaDon;
        private FontAwesome.Sharp.IconButton iconButtonBaoHanh;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.LinkLabel linkLabelTenNhanVien;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButtonSanPham;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Panel panel2;
    }
}