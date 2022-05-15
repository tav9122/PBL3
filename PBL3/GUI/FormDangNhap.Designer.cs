namespace PBL3
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDangNhap = new System.Windows.Forms.Button();
            this.textBoxMatKhau = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabelQuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButtonAnHienMatKhau = new FontAwesome.Sharp.IconButton();
            this.textBoxCanhBao = new System.Windows.Forms.TextBox();
            this.textBoxTenDangNhap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label1.Location = new System.Drawing.Point(28, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label2.Location = new System.Drawing.Point(28, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên đăng nhập:";
            // 
            // buttonDangNhap
            // 
            this.buttonDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.buttonDangNhap.ForeColor = System.Drawing.Color.White;
            this.buttonDangNhap.Location = new System.Drawing.Point(32, 290);
            this.buttonDangNhap.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.buttonDangNhap.Name = "buttonDangNhap";
            this.buttonDangNhap.Size = new System.Drawing.Size(257, 30);
            this.buttonDangNhap.TabIndex = 2;
            this.buttonDangNhap.Text = "Đăng nhập";
            this.buttonDangNhap.UseVisualStyleBackColor = false;
            this.buttonDangNhap.Click += new System.EventHandler(this.buttonDangNhap_Click);
            // 
            // textBoxMatKhau
            // 
            this.textBoxMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMatKhau.BackColor = System.Drawing.Color.White;
            this.textBoxMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxMatKhau.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxMatKhau.Location = new System.Drawing.Point(32, 198);
            this.textBoxMatKhau.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxMatKhau.Name = "textBoxMatKhau";
            this.textBoxMatKhau.Size = new System.Drawing.Size(257, 17);
            this.textBoxMatKhau.TabIndex = 1;
            this.textBoxMatKhau.UseSystemPasswordChar = true;
            this.textBoxMatKhau.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxMatKhau.Enter += new System.EventHandler(this.textBoxMatKhau_Enter);
            this.textBoxMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDangNhap_KeyDown);
            this.textBoxMatKhau.Leave += new System.EventHandler(this.textBoxMatKhau_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(342, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(36, 363);
            this.panel1.TabIndex = 5;
            // 
            // linkLabelQuenMatKhau
            // 
            this.linkLabelQuenMatKhau.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(125)))), ((int)(((byte)(161)))));
            this.linkLabelQuenMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabelQuenMatKhau.AutoSize = true;
            this.linkLabelQuenMatKhau.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.linkLabelQuenMatKhau.Location = new System.Drawing.Point(203, 232);
            this.linkLabelQuenMatKhau.Name = "linkLabelQuenMatKhau";
            this.linkLabelQuenMatKhau.Size = new System.Drawing.Size(86, 13);
            this.linkLabelQuenMatKhau.TabIndex = 4;
            this.linkLabelQuenMatKhau.TabStop = true;
            this.linkLabelQuenMatKhau.Text = "Quên mật khẩu?";
            this.linkLabelQuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelQuenMatKhau_LinkClicked);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label3.Location = new System.Drawing.Point(27, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "ĐĂNG NHẬP TÀI KHOẢN";
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Location = new System.Drawing.Point(32, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(257, 1);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel3.Location = new System.Drawing.Point(32, 220);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 1);
            this.panel3.TabIndex = 8;
            // 
            // iconButtonAnHienMatKhau
            // 
            this.iconButtonAnHienMatKhau.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButtonAnHienMatKhau.FlatAppearance.BorderSize = 0;
            this.iconButtonAnHienMatKhau.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.iconButtonAnHienMatKhau.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.iconButtonAnHienMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonAnHienMatKhau.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButtonAnHienMatKhau.IconColor = System.Drawing.Color.Black;
            this.iconButtonAnHienMatKhau.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.iconButtonAnHienMatKhau.IconSize = 27;
            this.iconButtonAnHienMatKhau.Location = new System.Drawing.Point(300, 198);
            this.iconButtonAnHienMatKhau.Name = "iconButtonAnHienMatKhau";
            this.iconButtonAnHienMatKhau.Size = new System.Drawing.Size(26, 23);
            this.iconButtonAnHienMatKhau.TabIndex = 3;
            this.iconButtonAnHienMatKhau.UseVisualStyleBackColor = true;
            this.iconButtonAnHienMatKhau.Click += new System.EventHandler(this.iconButtonAnHienMatKhau_Click);
            // 
            // textBoxCanhBao
            // 
            this.textBoxCanhBao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCanhBao.BackColor = System.Drawing.Color.White;
            this.textBoxCanhBao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCanhBao.Enabled = false;
            this.textBoxCanhBao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCanhBao.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxCanhBao.Location = new System.Drawing.Point(32, 259);
            this.textBoxCanhBao.Multiline = true;
            this.textBoxCanhBao.Name = "textBoxCanhBao";
            this.textBoxCanhBao.Size = new System.Drawing.Size(257, 17);
            this.textBoxCanhBao.TabIndex = 9;
            // 
            // textBoxTenDangNhap
            // 
            this.textBoxTenDangNhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxTenDangNhap.BackColor = System.Drawing.Color.White;
            this.textBoxTenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBoxTenDangNhap.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxTenDangNhap.Location = new System.Drawing.Point(32, 133);
            this.textBoxTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBoxTenDangNhap.Multiline = true;
            this.textBoxTenDangNhap.Name = "textBoxTenDangNhap";
            this.textBoxTenDangNhap.Size = new System.Drawing.Size(257, 18);
            this.textBoxTenDangNhap.TabIndex = 0;
            this.textBoxTenDangNhap.UseSystemPasswordChar = true;
            this.textBoxTenDangNhap.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            this.textBoxTenDangNhap.Enter += new System.EventHandler(this.textBoxTenDangNhap_Enter);
            this.textBoxTenDangNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDangNhap_KeyDown);
            this.textBoxTenDangNhap.Leave += new System.EventHandler(this.textBoxTenDangNhap_Leave);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 363);
            this.Controls.Add(this.textBoxTenDangNhap);
            this.Controls.Add(this.textBoxCanhBao);
            this.Controls.Add(this.iconButtonAnHienMatKhau);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabelQuenMatKhau);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxMatKhau);
            this.Controls.Add(this.buttonDangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FormDangNhap";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormDangNhap_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDangNhap;
        private System.Windows.Forms.TextBox textBoxMatKhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linkLabelQuenMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButtonAnHienMatKhau;
        private System.Windows.Forms.TextBox textBoxCanhBao;
        private System.Windows.Forms.TextBox textBoxTenDangNhap;
    }
}