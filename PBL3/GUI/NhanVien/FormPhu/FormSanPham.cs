﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormSanPham : Form
    {
        string maNhanVien;
        public FormSanPham(string maNhanVien)
        {
            InitializeComponent();
            comboBoxKieuSapXep.SelectedIndex = 0;
            foreach (var i in typeof(ViewSanPham_NhanVien).GetProperties())
            {
                comboBoxKieuSapXep.Items.Add(i.Name);
            }
            ReloadDataGridView(null, null);
            this.maNhanVien = maNhanVien;
        }

        private void ReloadDataGridView(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLSanPham.Instance.GetSanPhams(comboBoxKieuSapXep.Text, textBoxTimKiem.Text);
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

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            textBoxTuiHang.Text = "";
            foreach (ViewSanPham_NhanVien sanPham in BLLSanPham.Instance.GetTuiHang())
            {
                textBoxTuiHang.Text += sanPham.TenSanPham + " x " + sanPham.SoLuongTrongTuiHang + ",    ";
            }

            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col != dataGridView1.Columns["SoLuongTrongTuiHang"])
                    col.ReadOnly = true;
            }
            dataGridView1.Columns["TenSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["GiaBan"].DefaultCellStyle.Format = "C0";
        }


        private void buttonXoaTuiHang_Click(object sender, EventArgs e)
        {
            BLLSanPham.Instance.ResetSoLuongTrongTuiHang();
            textBoxTuiHang.Text = "";
            MessageBox.Show("Đã xoá túi hàng thành công!");
            ReloadDataGridView(null, null);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(dataGridView1.CurrentCell.Value) > Convert.ToInt32(dataGridView1.CurrentRow.Cells["SoLuongHienTai"].Value))
            {
                MessageBox.Show("Số lượng nhập vào lớn hơn số lượng hiện có trong kho!");
                BLLSanPham.Instance.SetSoLuongTrongTuiHang(dataGridView1.CurrentRow.Cells["MaSanPham"].Value.ToString(), Convert.ToInt32(dataGridView1.CurrentRow.Cells["SoLuongHienTai"].Value));
                dataGridView1.CurrentCell.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SoLuongHienTai"].Value);
            }
            else
            {
                BLLSanPham.Instance.SetSoLuongTrongTuiHang(dataGridView1.CurrentRow.Cells["MaSanPham"].Value.ToString(), Convert.ToInt32(dataGridView1.CurrentRow.Cells["SoLuongTrongTuiHang"].Value));
            }
            textBoxTuiHang.Text = "";
            foreach (ViewSanPham_NhanVien sanPham in BLLSanPham.Instance.GetTuiHang())
            {
                textBoxTuiHang.Text += sanPham.TenSanPham + " x " + sanPham.SoLuongTrongTuiHang + ",    ";
            }
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            if (BLLSanPham.Instance.GetTuiHang().Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào trong túi hàng!");
            }
            else
            {
                FormChiTietHoacThemHoaDon formChiTietHoacThemHoaDon = new FormChiTietHoacThemHoaDon(maNhanVien);
                formChiTietHoacThemHoaDon.ShowDialog();
                ReloadDataGridView(null, null);
            }
        }
    }
}
