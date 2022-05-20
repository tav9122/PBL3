namespace PBL3.GUI.NhanVien
{
    partial class FormChiTietHoacThemHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChiTietHoacThemHoaDon));
            this.buttonThoat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTongTienKhachTra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerThoiGianGiaoDich = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxMaHoaDon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxDiaChi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxTenKhachHang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoDienThoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMaKhachHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBoxMaNhanVien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonThoat
            // 
            this.buttonThoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.buttonThoat.Location = new System.Drawing.Point(28, 479);
            this.buttonThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(88, 28);
            this.buttonThoat.TabIndex = 48;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 18);
            this.label5.TabIndex = 44;
            this.label5.Text = "Thời gian giao dịch:";
            // 
            // textBoxTongTienKhachTra
            // 
            this.textBoxTongTienKhachTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxTongTienKhachTra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTongTienKhachTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxTongTienKhachTra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxTongTienKhachTra.Location = new System.Drawing.Point(171, 196);
            this.textBoxTongTienKhachTra.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTongTienKhachTra.Name = "textBoxTongTienKhachTra";
            this.textBoxTongTienKhachTra.Size = new System.Drawing.Size(172, 22);
            this.textBoxTongTienKhachTra.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 41;
            this.label3.Text = "Tổng tiền khách trả:";
            // 
            // dateTimePickerThoiGianGiaoDich
            // 
            this.dateTimePickerThoiGianGiaoDich.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePickerThoiGianGiaoDich.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePickerThoiGianGiaoDich.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.dateTimePickerThoiGianGiaoDich.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerThoiGianGiaoDich.Location = new System.Drawing.Point(171, 159);
            this.dateTimePickerThoiGianGiaoDich.Name = "dateTimePickerThoiGianGiaoDich";
            this.dateTimePickerThoiGianGiaoDich.Size = new System.Drawing.Size(172, 22);
            this.dateTimePickerThoiGianGiaoDich.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 29);
            this.panel1.TabIndex = 40;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // textBoxMaHoaDon
            // 
            this.textBoxMaHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxMaHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMaHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMaHoaDon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxMaHoaDon.Location = new System.Drawing.Point(132, 86);
            this.textBoxMaHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMaHoaDon.Name = "textBoxMaHoaDon";
            this.textBoxMaHoaDon.Size = new System.Drawing.Size(159, 22);
            this.textBoxMaHoaDon.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mã hoá đơn:";
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTieuDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.labelTieuDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.labelTieuDe.Location = new System.Drawing.Point(23, 42);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(320, 27);
            this.labelTieuDe.TabIndex = 37;
            this.labelTieuDe.Text = "Chi tiết hoặc thêm hoá đơn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.textBoxDiaChi);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBoxTenKhachHang);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxSoDienThoai);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxMaKhachHang);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.groupBox2.Location = new System.Drawing.Point(438, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 169);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng:";
            // 
            // textBoxDiaChi
            // 
            this.textBoxDiaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxDiaChi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
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
            this.textBoxTenKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxTenKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxTenKhachHang.Location = new System.Drawing.Point(122, 60);
            this.textBoxTenKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTenKhachHang.Name = "textBoxTenKhachHang";
            this.textBoxTenKhachHang.Size = new System.Drawing.Size(159, 22);
            this.textBoxTenKhachHang.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "Tên khách hàng:";
            // 
            // textBoxSoDienThoai
            // 
            this.textBoxSoDienThoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSoDienThoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxSoDienThoai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxSoDienThoai.Location = new System.Drawing.Point(107, 97);
            this.textBoxSoDienThoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxSoDienThoai.Name = "textBoxSoDienThoai";
            this.textBoxSoDienThoai.Size = new System.Drawing.Size(174, 22);
            this.textBoxSoDienThoai.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 49;
            this.label6.Text = "Số điện thoại:";
            // 
            // textBoxMaKhachHang
            // 
            this.textBoxMaKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMaKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxMaKhachHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxMaKhachHang.Location = new System.Drawing.Point(122, 24);
            this.textBoxMaKhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMaKhachHang.Name = "textBoxMaKhachHang";
            this.textBoxMaKhachHang.Size = new System.Drawing.Size(159, 22);
            this.textBoxMaKhachHang.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 18);
            this.label7.TabIndex = 47;
            this.label7.Text = "Mã khách hàng:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 256);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(713, 215);
            this.dataGridView1.TabIndex = 51;
            // 
            // textBoxMaNhanVien
            // 
            this.textBoxMaNhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxMaNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMaNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.textBoxMaNhanVien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxMaNhanVien.Location = new System.Drawing.Point(132, 122);
            this.textBoxMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxMaNhanVien.Name = "textBoxMaNhanVien";
            this.textBoxMaNhanVien.Size = new System.Drawing.Size(159, 22);
            this.textBoxMaNhanVien.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 18);
            this.label8.TabIndex = 52;
            this.label8.Text = "Mã nhân viên:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(739, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(19, 18);
            this.button2.TabIndex = 26;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(718, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(15, 18);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // FormChiTietHoacThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(761, 520);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxMaNhanVien);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTongTienKhachTra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerThoiGianGiaoDich);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxMaHoaDon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormChiTietHoacThemHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTongTienKhachTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePickerThoiGianGiaoDich;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxMaHoaDon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxTenKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSoDienThoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMaKhachHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxMaNhanVien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxDiaChi;
        private System.Windows.Forms.Label label9;
    }
}