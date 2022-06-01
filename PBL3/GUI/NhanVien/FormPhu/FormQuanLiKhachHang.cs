using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormQuanLiKhachHang : Form
    {
        Dictionary<string, string> dictionary = TypeDescriptor.GetProperties(typeof(ViewKhachHang)).Cast<PropertyDescriptor>().ToDictionary(p => p.Name, p => p.DisplayName);
        public FormQuanLiKhachHang()
        {
            InitializeComponent();

            comboBoxKieuSapXep.SelectedIndex = 0;
            dictionary.Select(d => d.Value).ToList().ForEach(i => comboBoxKieuSapXep.Items.Add(i));

        }

        private void ReloadDataGridView(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLQuanLiKhachHang.Instance.GetKhachHangs(dictionary.FirstOrDefault(d => d.Value == comboBoxKieuSapXep.Text).Key, textBoxTimKiem.Text);
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

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa các dữ liệu này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    BLLQuanLiKhachHang.Instance.DeleteKhachHang(row.Cells[0].Value.ToString());
                }
                ReloadDataGridView(null, null);
                MessageBox.Show("Đã xoá thành công!");
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            FormChiTietHoacThemKhachHang formChiTietHoacThemKhachHang = new FormChiTietHoacThemKhachHang(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            formChiTietHoacThemKhachHang.ShowDialog();
            ReloadDataGridView(null, null);
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            FormChiTietHoacThemKhachHang formChiTietHoacThemKhachHang = new FormChiTietHoacThemKhachHang();
            formChiTietHoacThemKhachHang.ShowDialog();
            ReloadDataGridView(null, null);
        }
    }
}
