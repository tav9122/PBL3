using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormSanPham : Form
    {
        string maNhanVien;

        Dictionary<string, string> dictionary = TypeDescriptor.GetProperties(typeof(ViewSanPham_NhanVien)).Cast<PropertyDescriptor>().ToDictionary(p => p.Name, p => p.DisplayName);

        public FormSanPham(string maNhanVien)
        {
            InitializeComponent();

            dictionary.Select(d => d.Value).ToList().ForEach(i => comboBoxKieuSapXep.Items.Add(i));
            comboBoxKieuSapXep.SelectedIndex = 0;

            ReloadDataGridView(null, null);
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col != dataGridView1.Columns["SoLuongTrongTuiHang"])
                    col.ReadOnly = true;
            }
            dataGridView1.Columns["TenSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["GiaBan"].DefaultCellStyle.Format = "C0";

            this.maNhanVien = maNhanVien;
        }

        private void ReloadDataGridView(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLButtonSanPham.Instance.GetSanPhams(dictionary.FirstOrDefault(d => d.Value == comboBoxKieuSapXep.Text).Key, textBoxTimKiem.Text);
        }

        private void buttonXoaTuiHang_Click(object sender, EventArgs e)
        {
            BLLSanPham.Instance.ResetTemp();
            textBoxTuiHang.Text = "";
            ReloadDataGridView(null, null);
            MessageBox.Show("Đã xoá túi hàng thành công!");
        }

        private void buttonThanhToan_Click(object sender, EventArgs e)
        {
            if (BLLSanPham.Instance.GetSanPhamWithTempValueGreaterThanZero().Count == 0)
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

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(dataGridView1.CurrentCell.Value) > Convert.ToInt32(dataGridView1.CurrentRow.Cells["SoLuongHienTai"].Value))
            {
                MessageBox.Show("Số lượng nhập vào lớn hơn số lượng hiện có trong kho!");
                BLLSanPham.Instance.SetTempValue(dataGridView1.CurrentRow.Cells["MaSanPham"].Value.ToString(), Convert.ToInt32(dataGridView1.CurrentRow.Cells["SoLuongHienTai"].Value));
                dataGridView1.CurrentCell.Value = Convert.ToInt32(dataGridView1.CurrentRow.Cells["SoLuongHienTai"].Value);
            }
            else
            {
                BLLSanPham.Instance.SetTempValue(dataGridView1.CurrentRow.Cells["MaSanPham"].Value.ToString(), Convert.ToInt32(dataGridView1.CurrentRow.Cells["SoLuongTrongTuiHang"].Value));
            }
            textBoxTuiHang.Text = "";
            foreach (SanPham sanPham in BLLSanPham.Instance.GetSanPhamWithTempValueGreaterThanZero())
            {
                textBoxTuiHang.Text += sanPham.TenSanPham + " x " + sanPham.Temp + ",    ";
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            textBoxTuiHang.Text = "";
            foreach (SanPham sanPham in BLLSanPham.Instance.GetSanPhamWithTempValueGreaterThanZero())
            {
                textBoxTuiHang.Text += sanPham.TenSanPham + " x " + sanPham.Temp + ",    ";
            }
        }
    }
}
