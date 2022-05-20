namespace PBL3
{
    partial class FormManHinhChinh
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
            this.label2 = new System.Windows.Forms.Label();
            this.labelGioPhutGiay = new System.Windows.Forms.Label();
            this.labelNgayThangNam = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.label2.Location = new System.Drawing.Point(230, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 39);
            this.label2.TabIndex = 28;
            this.label2.Text = "Màn hình chính";
            // 
            // labelGioPhutGiay
            // 
            this.labelGioPhutGiay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelGioPhutGiay.AutoSize = true;
            this.labelGioPhutGiay.BackColor = System.Drawing.Color.White;
            this.labelGioPhutGiay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGioPhutGiay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelGioPhutGiay.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGioPhutGiay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.labelGioPhutGiay.Location = new System.Drawing.Point(151, 127);
            this.labelGioPhutGiay.Name = "labelGioPhutGiay";
            this.labelGioPhutGiay.Size = new System.Drawing.Size(427, 110);
            this.labelGioPhutGiay.TabIndex = 31;
            this.labelGioPhutGiay.Text = "22:22:22";
            // 
            // labelNgayThangNam
            // 
            this.labelNgayThangNam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelNgayThangNam.AutoSize = true;
            this.labelNgayThangNam.BackColor = System.Drawing.Color.White;
            this.labelNgayThangNam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelNgayThangNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelNgayThangNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayThangNam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.labelNgayThangNam.Location = new System.Drawing.Point(43, 277);
            this.labelNgayThangNam.Name = "labelNgayThangNam";
            this.labelNgayThangNam.Size = new System.Drawing.Size(628, 39);
            this.labelNgayThangNam.TabIndex = 33;
            this.labelNgayThangNam.Text = "Chủ nhật, Ngày 22 Tháng 02 Năm 2022";
            this.labelNgayThangNam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormManHinhChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 419);
            this.Controls.Add(this.labelNgayThangNam);
            this.Controls.Add(this.labelGioPhutGiay);
            this.Controls.Add(this.label2);
            this.Name = "FormManHinhChinh";
            this.Text = "FormManHinhChinh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelGioPhutGiay;
        private System.Windows.Forms.Label labelNgayThangNam;
        private System.Windows.Forms.Timer timer1;
    }
}