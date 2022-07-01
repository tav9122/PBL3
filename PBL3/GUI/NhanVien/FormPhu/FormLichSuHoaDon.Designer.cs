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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonXem = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAscendingDescending = new System.Windows.Forms.Button();
            this.comboBoxKieuSapXep = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(692, 302);
            this.dataGridView1.TabIndex = 46;
            // 
            // buttonAscendingDescending
            // 
            this.buttonAscendingDescending.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAscendingDescending.FlatAppearance.BorderSize = 0;
            this.buttonAscendingDescending.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonAscendingDescending.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.buttonAscendingDescending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAscendingDescending.Image = global::PBL3.Properties.Resources.uparrow20;
            this.buttonAscendingDescending.Location = new System.Drawing.Point(686, 18);
            this.buttonAscendingDescending.Name = "buttonAscendingDescending";
            this.buttonAscendingDescending.Size = new System.Drawing.Size(20, 26);
            this.buttonAscendingDescending.TabIndex = 94;
            this.buttonAscendingDescending.UseVisualStyleBackColor = true;
            this.buttonAscendingDescending.Click += new System.EventHandler(this.buttonAscendingDescending_Click);
            // 
            // comboBoxKieuSapXep
            // 
            this.comboBoxKieuSapXep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxKieuSapXep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKieuSapXep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxKieuSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKieuSapXep.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBoxKieuSapXep.FormattingEnabled = true;
            this.comboBoxKieuSapXep.Location = new System.Drawing.Point(473, 21);
            this.comboBoxKieuSapXep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxKieuSapXep.Name = "comboBoxKieuSapXep";
            this.comboBoxKieuSapXep.Size = new System.Drawing.Size(207, 24);
            this.comboBoxKieuSapXep.TabIndex = 92;
            this.comboBoxKieuSapXep.DropDownClosed += new System.EventHandler(this.ReloadDataGridView);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(369, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 93;
            this.label4.Text = "Sắp xếp theo:";
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.textBoxTimKiem.Location = new System.Drawing.Point(372, 69);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(332, 24);
            this.textBoxTimKiem.TabIndex = 91;
            this.textBoxTimKiem.Text = "Nhập để tìm kiếm...";
            this.textBoxTimKiem.TextChanged += new System.EventHandler(this.ReloadDataGridView);
            this.textBoxTimKiem.Enter += new System.EventHandler(this.textBoxTimKiem_Enter);
            this.textBoxTimKiem.Leave += new System.EventHandler(this.textBoxTimKiem_Leave);
            // 
            // FormLichSuHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 419);
            this.Controls.Add(this.buttonAscendingDescending);
            this.Controls.Add(this.comboBoxKieuSapXep);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonXem);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FormLichSuHoaDon";
            this.Text = "FormLichSuHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonXem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAscendingDescending;
        private System.Windows.Forms.ComboBox comboBoxKieuSapXep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTimKiem;
    }
}