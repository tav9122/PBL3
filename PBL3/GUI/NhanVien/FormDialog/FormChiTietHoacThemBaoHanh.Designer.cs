﻿namespace PBL3
{
    partial class FormChiTietHoacThemBaoHanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietHoacThemBaoHanh));
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.dateTimePickerThoiGianGiaoTaoPhieuBaoHanh = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonHoanThanh = new System.Windows.Forms.RadioButton();
            this.radioButtonChuaHoanThanh = new System.Windows.Forms.RadioButton();
            this.textBoxGhiChu = new System.Windows.Forms.TextBox();
            this.buttonXacNhan = new System.Windows.Forms.Button();
            this.buttonHuyBo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxTenSanPham = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoSeri = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTenKhachHang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSoDienThoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMaKhachHang = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 18);
            this.label8.TabIndex = 65;
            this.label8.Text = "Thời gian tạo phiếu bảo hành:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 29);
            this.panel1.TabIndex = 57;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(739, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 18);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.buttonThoat.Location = new System.Drawing.Point(28, 525);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(88, 28);
            this.buttonThoat.TabIndex = 62;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.labelTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.labelTieuDe.Location = new System.Drawing.Point(23, 42);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(409, 27);
            this.labelTieuDe.TabIndex = 54;
            this.labelTieuDe.Text = "Chi tiết bảo hành hoặc thêm bảo hành:";
            // 
            // dateTimePickerThoiGianGiaoTaoPhieuBaoHanh
            // 
            this.dateTimePickerThoiGianGiaoTaoPhieuBaoHanh.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerThoiGianGiaoTaoPhieuBaoHanh.Enabled = false;
            this.dateTimePickerThoiGianGiaoTaoPhieuBaoHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dateTimePickerThoiGianGiaoTaoPhieuBaoHanh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerThoiGianGiaoTaoPhieuBaoHanh.Location = new System.Drawing.Point(232, 83);
            this.dateTimePickerThoiGianGiaoTaoPhieuBaoHanh.Name = "dateTimePickerThoiGianGiaoTaoPhieuBaoHanh";
            this.dateTimePickerThoiGianGiaoTaoPhieuBaoHanh.Size = new System.Drawing.Size(172, 22);
            this.dateTimePickerThoiGianGiaoTaoPhieuBaoHanh.TabIndex = 66;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonHoanThanh);
            this.groupBox1.Controls.Add(this.radioButtonChuaHoanThanh);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(28, 333);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 72);
            this.groupBox1.TabIndex = 67;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Trạng thái";
            // 
            // radioButtonHoanThanh
            // 
            this.radioButtonHoanThanh.AutoSize = true;
            this.radioButtonHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHoanThanh.Location = new System.Drawing.Point(11, 23);
            this.radioButtonHoanThanh.Name = "radioButtonHoanThanh";
            this.radioButtonHoanThanh.Size = new System.Drawing.Size(93, 20);
            this.radioButtonHoanThanh.TabIndex = 34;
            this.radioButtonHoanThanh.Text = "Hoàn thành";
            this.radioButtonHoanThanh.UseVisualStyleBackColor = true;
            // 
            // radioButtonChuaHoanThanh
            // 
            this.radioButtonChuaHoanThanh.AutoSize = true;
            this.radioButtonChuaHoanThanh.Checked = true;
            this.radioButtonChuaHoanThanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonChuaHoanThanh.Location = new System.Drawing.Point(11, 49);
            this.radioButtonChuaHoanThanh.Name = "radioButtonChuaHoanThanh";
            this.radioButtonChuaHoanThanh.Size = new System.Drawing.Size(124, 20);
            this.radioButtonChuaHoanThanh.TabIndex = 35;
            this.radioButtonChuaHoanThanh.TabStop = true;
            this.radioButtonChuaHoanThanh.Text = "Chưa hoàn thành";
            this.radioButtonChuaHoanThanh.UseVisualStyleBackColor = true;
            // 
            // textBoxGhiChu
            // 
            this.textBoxGhiChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGhiChu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxGhiChu.Location = new System.Drawing.Point(28, 147);
            this.textBoxGhiChu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxGhiChu.Multiline = true;
            this.textBoxGhiChu.Name = "textBoxGhiChu";
            this.textBoxGhiChu.Size = new System.Drawing.Size(376, 169);
            this.textBoxGhiChu.TabIndex = 68;
            // 
            // buttonXacNhan
            // 
            this.buttonXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXacNhan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.buttonXacNhan.Location = new System.Drawing.Point(277, 432);
            this.buttonXacNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonXacNhan.Name = "buttonXacNhan";
            this.buttonXacNhan.Size = new System.Drawing.Size(88, 28);
            this.buttonXacNhan.TabIndex = 70;
            this.buttonXacNhan.Text = "Xác nhận";
            this.buttonXacNhan.UseVisualStyleBackColor = true;
            this.buttonXacNhan.Click += new System.EventHandler(this.buttonXacNhan_Click);
            // 
            // buttonHuyBo
            // 
            this.buttonHuyBo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHuyBo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuyBo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.buttonHuyBo.Location = new System.Drawing.Point(404, 432);
            this.buttonHuyBo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonHuyBo.Name = "buttonHuyBo";
            this.buttonHuyBo.Size = new System.Drawing.Size(88, 28);
            this.buttonHuyBo.TabIndex = 69;
            this.buttonHuyBo.Text = "Huỷ bỏ";
            this.buttonHuyBo.UseVisualStyleBackColor = true;
            this.buttonHuyBo.Click += new System.EventHandler(this.buttonHuyBo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxTenSanPham);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxSoSeri);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(441, 76);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 94);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin vật phẩm:";
            // 
            // textBoxTenSanPham
            // 
            this.textBoxTenSanPham.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTenSanPham.Enabled = false;
            this.textBoxTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxTenSanPham.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxTenSanPham.Location = new System.Drawing.Point(122, 59);
            this.textBoxTenSanPham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTenSanPham.Name = "textBoxTenSanPham";
            this.textBoxTenSanPham.Size = new System.Drawing.Size(159, 22);
            this.textBoxTenSanPham.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "Tên sản phẩm:";
            // 
            // textBoxSoSeri
            // 
            this.textBoxSoSeri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSoSeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxSoSeri.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxSoSeri.Location = new System.Drawing.Point(122, 24);
            this.textBoxSoSeri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSoSeri.Name = "textBoxSoSeri";
            this.textBoxSoSeri.Size = new System.Drawing.Size(159, 22);
            this.textBoxSoSeri.TabIndex = 48;
            this.textBoxSoSeri.TextChanged += new System.EventHandler(this.textBoxSoSeri_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 18);
            this.label7.TabIndex = 47;
            this.label7.Text = "Số seri:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxDiaChi);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxTenKhachHang);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBoxSoDienThoai);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxMaKhachHang);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox3.Location = new System.Drawing.Point(441, 186);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 169);
            this.groupBox3.TabIndex = 74;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khách hàng:";
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDiaChi.Enabled = false;
            this.textBoxDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxDiaChi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxDiaChi.Location = new System.Drawing.Point(66, 134);
            this.textBoxDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDiaChi.Name = "textBoxDiaChi";
            this.textBoxDiaChi.Size = new System.Drawing.Size(215, 22);
            this.textBoxDiaChi.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 53;
            this.label9.Text = "Địa chỉ:";
            // 
            // textBoxTenKhachHang
            // 
            this.textBoxTenKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTenKhachHang.Enabled = false;
            this.textBoxTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxTenKhachHang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxTenKhachHang.Location = new System.Drawing.Point(122, 99);
            this.textBoxTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTenKhachHang.Name = "textBoxTenKhachHang";
            this.textBoxTenKhachHang.Size = new System.Drawing.Size(159, 22);
            this.textBoxTenKhachHang.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 18);
            this.label5.TabIndex = 51;
            this.label5.Text = "Tên khách hàng:";
            // 
            // textBoxSoDienThoai
            // 
            this.textBoxSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxSoDienThoai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxSoDienThoai.Location = new System.Drawing.Point(122, 61);
            this.textBoxSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            this.textBoxSoDienThoai.Size = new System.Drawing.Size(159, 22);
            this.textBoxSoDienThoai.TabIndex = 50;
            this.textBoxSoDienThoai.TextChanged += new System.EventHandler(this.textBoxSoDienThoai_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 49;
            this.label6.Text = "Số điện thoại:";
            // 
            // textBoxMaKhachHang
            // 
            this.textBoxMaKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMaKhachHang.Enabled = false;
            this.textBoxMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxMaKhachHang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textBoxMaKhachHang.Location = new System.Drawing.Point(122, 24);
            this.textBoxMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMaKhachHang.Name = "textBoxMaKhachHang";
            this.textBoxMaKhachHang.Size = new System.Drawing.Size(159, 22);
            this.textBoxMaKhachHang.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 18);
            this.label10.TabIndex = 47;
            this.label10.Text = "Mã khách hàng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 18);
            this.label11.TabIndex = 75;
            this.label11.Text = "Ghi chú bảo hành:";
            // 
            // FormChiTietHoacThemBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 473);
            this.ControlBox = false;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonXacNhan);
            this.Controls.Add(this.buttonHuyBo);
            this.Controls.Add(this.textBoxGhiChu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePickerThoiGianGiaoTaoPhieuBaoHanh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.labelTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChiTietHoacThemBaoHanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.DateTimePicker dateTimePickerThoiGianGiaoTaoPhieuBaoHanh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonHoanThanh;
        private System.Windows.Forms.RadioButton radioButtonChuaHoanThanh;
        private System.Windows.Forms.TextBox textBoxGhiChu;
        private System.Windows.Forms.Button buttonXacNhan;
        private System.Windows.Forms.Button buttonHuyBo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxTenSanPham;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSoSeri;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxTenKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxSoDienThoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMaKhachHang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}