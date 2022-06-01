namespace PBL3
{
    partial class FormLichSuHoaDon
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.comboBoxKieuSapXep = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonXem = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.label2.Location = new System.Drawing.Point(12, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 32);
            this.label2.TabIndex = 39;
            this.label2.Text = "Lịch sử hoá đơn";
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxTimKiem.Location = new System.Drawing.Point(458, 69);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(246, 24);
            this.textBoxTimKiem.TabIndex = 7;
            this.textBoxTimKiem.Text = "Nhập để tìm kiếm...";
            this.textBoxTimKiem.TextChanged += new System.EventHandler(this.ReloadDataGridView);
            this.textBoxTimKiem.Enter += new System.EventHandler(this.textBoxTimKiem_Enter);
            this.textBoxTimKiem.Leave += new System.EventHandler(this.textBoxTimKiem_Leave);
            // 
            // comboBoxKieuSapXep
            // 
            this.comboBoxKieuSapXep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxKieuSapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKieuSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxKieuSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKieuSapXep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBoxKieuSapXep.FormattingEnabled = true;
            this.comboBoxKieuSapXep.Items.AddRange(new object[] {
            "Không sắp xếp"});
            this.comboBoxKieuSapXep.Location = new System.Drawing.Point(552, 20);
            this.comboBoxKieuSapXep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxKieuSapXep.Name = "comboBoxKieuSapXep";
            this.comboBoxKieuSapXep.Size = new System.Drawing.Size(152, 24);
            this.comboBoxKieuSapXep.TabIndex = 8;
            this.comboBoxKieuSapXep.SelectedIndexChanged += new System.EventHandler(this.ReloadDataGridView);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(455, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Sắp xếp theo";
            // 
            // buttonXem
            // 
            this.buttonXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonXem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.buttonXem.Location = new System.Drawing.Point(18, 64);
            this.buttonXem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonXem.Name = "buttonXem";
            this.buttonXem.Size = new System.Drawing.Size(70, 28);
            this.buttonXem.TabIndex = 5;
            this.buttonXem.Text = "Xem";
            this.buttonXem.UseVisualStyleBackColor = true;
            this.buttonXem.Click += new System.EventHandler(this.buttonXem_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonXoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.buttonXoa.Location = new System.Drawing.Point(94, 64);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(70, 28);
            this.buttonXoa.TabIndex = 6;
            this.buttonXoa.Text = "Xoá";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(692, 302);
            this.dataGridView1.TabIndex = 40;
            // 
            // FormLichSuHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 419);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonXem);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.comboBoxKieuSapXep);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FormLichSuHoaDon";
            this.Text = "FormLichSuHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.ComboBox comboBoxKieuSapXep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonXem;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}