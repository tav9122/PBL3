﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormBaoHanh : Form
    {
        public FormBaoHanh()
        {
            InitializeComponent();
            comboBoxKieuSapXep.SelectedIndex = 0;
            foreach (var i in typeof(ViewKhachHang).GetProperties())
            {
                comboBoxKieuSapXep.Items.Add(i.Name);
            }
            ReloadDataGridView(null, null);
        }

        private void ReloadDataGridView(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLBaoHanh.Instance.GetBaoHanhs(comboBoxKieuSapXep.Text, textBoxTimKiem.Text);
        }

        #region Các hàm chức năng cơ bản, hạn chế sửa.
        private void textBoxTimKiem_Enter(object sender, EventArgs e)
        {
            if (textBoxTimKiem.Text == "Nhập để tìm kiếm...")
            {
                textBoxTimKiem.Text = "";
                textBoxTimKiem.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            }
        }

        private void textBoxTimKiem_Leave(object sender, EventArgs e)
        {
            if (textBoxTimKiem.Text == "")
            {
                textBoxTimKiem.ForeColor = Color.FromArgb(200, 200, 200);
                textBoxTimKiem.Text = "Nhập để tìm kiếm...";
            }
        }
        #endregion

        private void buttonThem_Click(object sender, EventArgs e)
        {
            FormChiTietHoacThemBaoHanh formChiTietHoacThemBaoHanh = new FormChiTietHoacThemBaoHanh();
            formChiTietHoacThemBaoHanh.ShowDialog();
            ReloadDataGridView(null, null);
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            FormChiTietHoacThemBaoHanh formChiTietHoacThemBaoHanh = new FormChiTietHoacThemBaoHanh(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            formChiTietHoacThemBaoHanh.ShowDialog();
            ReloadDataGridView(null, null);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa các dữ liệu này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    BLLBaoHanh.Instance.DeleteBaoHanh(row.Cells[0].Value.ToString());
                }
                MessageBox.Show("Đã xoá thành công!");
                ReloadDataGridView(null, null);
            }
        }
    }
}
