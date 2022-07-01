namespace PBL3
{
    partial class FormChiTietHoacThemSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietHoacThemSanPham));
            this.textBoxGiaBan = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonXacNhan = new System.Windows.Forms.Button();
            this.buttonHuyBo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTenHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTenSanPham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMaSanPham = new System.Windows.Forms.TextBox();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.textBoxSoLuongHienTai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxGiaMua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSoLuongNhap = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxThoiGianBaoHanh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLoaiSanPham = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxGiaBan
            // 
            this.textBoxGiaBan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGiaBan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxGiaBan.Location = new System.Drawing.Point(584, 86);
            this.textBoxGiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGiaBan.Name = "textBoxGiaBan";
            this.textBoxGiaBan.Size = new System.Drawing.Size(182, 22);
            this.textBoxGiaBan.TabIndex = 4;
            this.textBoxGiaBan.Enter += new System.EventHandler(this.textBoxGiaBan_Enter);
            this.textBoxGiaBan.Leave += new System.EventHandler(this.textBoxGiaBan_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(441, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 18);
            this.label11.TabIndex = 132;
            this.label11.Text = "Giá bán:";
            // 
            // buttonXacNhan
            // 
            this.buttonXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.buttonXacNhan.Location = new System.Drawing.Point(289, 345);
            this.buttonXacNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonXacNhan.Name = "buttonXacNhan";
            this.buttonXacNhan.Size = new System.Drawing.Size(88, 28);
            this.buttonXacNhan.TabIndex = 9;
            this.buttonXacNhan.Text = "Xác nhận";
            this.buttonXacNhan.UseVisualStyleBackColor = true;
            this.buttonXacNhan.Click += new System.EventHandler(this.buttonXacNhan_Click);
            // 
            // buttonHuyBo
            // 
            this.buttonHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuyBo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.buttonHuyBo.Location = new System.Drawing.Point(416, 345);
            this.buttonHuyBo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonHuyBo.Name = "buttonHuyBo";
            this.buttonHuyBo.Size = new System.Drawing.Size(88, 28);
            this.buttonHuyBo.TabIndex = 10;
            this.buttonHuyBo.Text = "Huỷ bỏ";
            this.buttonHuyBo.UseVisualStyleBackColor = true;
            this.buttonHuyBo.Click += new System.EventHandler(this.buttonHuyBo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 29);
            this.panel1.TabIndex = 119;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(748, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 18);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // textBoxTenHang
            // 
            this.textBoxTenHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTenHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenHang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxTenHang.Location = new System.Drawing.Point(136, 216);
            this.textBoxTenHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTenHang.Name = "textBoxTenHang";
            this.textBoxTenHang.Size = new System.Drawing.Size(258, 22);
            this.textBoxTenHang.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 18);
            this.label5.TabIndex = 127;
            this.label5.Text = "Tên hãng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 18);
            this.label2.TabIndex = 117;
            this.label2.Text = "Mã sản phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 125;
            this.label4.Text = "Loại sản phẩm:";
            // 
            // textBoxTenSanPham
            // 
            this.textBoxTenSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTenSanPham.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxTenSanPham.Location = new System.Drawing.Point(136, 172);
            this.textBoxTenSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTenSanPham.Name = "textBoxTenSanPham";
            this.textBoxTenSanPham.Size = new System.Drawing.Size(258, 22);
            this.textBoxTenSanPham.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 123;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // textBoxMaSanPham
            // 
            this.textBoxMaSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMaSanPham.Enabled = false;
            this.textBoxMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaSanPham.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxMaSanPham.Location = new System.Drawing.Point(136, 86);
            this.textBoxMaSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMaSanPham.Name = "textBoxMaSanPham";
            this.textBoxMaSanPham.Size = new System.Drawing.Size(258, 22);
            this.textBoxMaSanPham.TabIndex = 0;
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.labelTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.labelTieuDe.Location = new System.Drawing.Point(23, 42);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(324, 27);
            this.labelTieuDe.TabIndex = 116;
            this.labelTieuDe.Text = "Chi tiết hoặc thêm sản phẩm:";
            // 
            // textBoxSoLuongHienTai
            // 
            this.textBoxSoLuongHienTai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSoLuongHienTai.Enabled = false;
            this.textBoxSoLuongHienTai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoLuongHienTai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxSoLuongHienTai.Location = new System.Drawing.Point(584, 216);
            this.textBoxSoLuongHienTai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSoLuongHienTai.Name = "textBoxSoLuongHienTai";
            this.textBoxSoLuongHienTai.Size = new System.Drawing.Size(182, 22);
            this.textBoxSoLuongHienTai.TabIndex = 7;
            this.textBoxSoLuongHienTai.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(441, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 18);
            this.label6.TabIndex = 138;
            this.label6.Text = "Số lượng hiện tại:";
            // 
            // textBoxGiaMua
            // 
            this.textBoxGiaMua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGiaMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGiaMua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxGiaMua.Location = new System.Drawing.Point(584, 130);
            this.textBoxGiaMua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGiaMua.Name = "textBoxGiaMua";
            this.textBoxGiaMua.Size = new System.Drawing.Size(182, 22);
            this.textBoxGiaMua.TabIndex = 5;
            this.textBoxGiaMua.Enter += new System.EventHandler(this.textBoxGiaBan_Enter);
            this.textBoxGiaMua.Leave += new System.EventHandler(this.textBoxGiaBan_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(441, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 18);
            this.label7.TabIndex = 136;
            this.label7.Text = "Giá mua:";
            // 
            // textBoxSoLuongNhap
            // 
            this.textBoxSoLuongNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSoLuongNhap.Enabled = false;
            this.textBoxSoLuongNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoLuongNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxSoLuongNhap.Location = new System.Drawing.Point(584, 172);
            this.textBoxSoLuongNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSoLuongNhap.Name = "textBoxSoLuongNhap";
            this.textBoxSoLuongNhap.Size = new System.Drawing.Size(182, 22);
            this.textBoxSoLuongNhap.TabIndex = 6;
            this.textBoxSoLuongNhap.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(441, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 18);
            this.label12.TabIndex = 134;
            this.label12.Text = "Số lượng nhập:";
            // 
            // textBoxThoiGianBaoHanh
            // 
            this.textBoxThoiGianBaoHanh.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxThoiGianBaoHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxThoiGianBaoHanh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxThoiGianBaoHanh.Location = new System.Drawing.Point(584, 260);
            this.textBoxThoiGianBaoHanh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxThoiGianBaoHanh.Name = "textBoxThoiGianBaoHanh";
            this.textBoxThoiGianBaoHanh.Size = new System.Drawing.Size(182, 22);
            this.textBoxThoiGianBaoHanh.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 140;
            this.label1.Text = "Thời gian bảo hành:";
            // 
            // comboBoxLoaiSanPham
            // 
            this.comboBoxLoaiSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLoaiSanPham.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBoxLoaiSanPham.FormattingEnabled = true;
            this.comboBoxLoaiSanPham.Location = new System.Drawing.Point(136, 130);
            this.comboBoxLoaiSanPham.Name = "comboBoxLoaiSanPham";
            this.comboBoxLoaiSanPham.Size = new System.Drawing.Size(258, 24);
            this.comboBoxLoaiSanPham.TabIndex = 1;
            this.comboBoxLoaiSanPham.TextChanged += new System.EventHandler(this.comboBoxLoaiSanPham_TextChanged);
            // 
            // FormChiTietHoacThemSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(792, 386);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxLoaiSanPham);
            this.Controls.Add(this.textBoxThoiGianBaoHanh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSoLuongHienTai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxGiaMua);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxSoLuongNhap);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBoxGiaBan);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.buttonXacNhan);
            this.Controls.Add(this.buttonHuyBo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxTenHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTenSanPham);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxMaSanPham);
            this.Controls.Add(this.labelTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChiTietHoacThemSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxGiaBan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button buttonXacNhan;
        private System.Windows.Forms.Button buttonHuyBo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxTenHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTenSanPham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMaSanPham;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.TextBox textBoxSoLuongHienTai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxGiaMua;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSoLuongNhap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxThoiGianBaoHanh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLoaiSanPham;
    }
}