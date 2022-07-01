using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormQuanLiSanPham : Form
    {
        Dictionary<string, string> dictionary = TypeDescriptor.GetProperties(typeof(ViewSanPham_QuanTriVien)).Cast<PropertyDescriptor>().ToDictionary(p => p.Name, p => p.DisplayName);
        bool ascendingSort = true;

        public FormQuanLiSanPham()
        {
            InitializeComponent();

            dictionary.Select(d => d.Value).ToList().ForEach(i => comboBoxKieuSapXep.Items.Add(i));
            comboBoxKieuSapXep.SelectedIndex = 0;

            ReloadDataGridView(null, null);
            dataGridView1.Columns["TenSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["GiaBan"].DefaultCellStyle.Format = "C0";
            dataGridView1.Columns["GiaMua"].DefaultCellStyle.Format = "C0";
        }

        private void ReloadDataGridView(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLButtonQuanLiSanPham.Instance.GetSanPhams(dictionary.FirstOrDefault(d => d.Value == comboBoxKieuSapXep.Text).Key, textBoxTimKiem.Text, ascendingSort);
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            FormChiTietHoacThemSanPham formChiTietHoacThemSanPham = new FormChiTietHoacThemSanPham();
            formChiTietHoacThemSanPham.ShowDialog();
            ReloadDataGridView(null, null);
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            FormChiTietHoacThemSanPham formChiTietHoacThemSanPham = new FormChiTietHoacThemSanPham(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            formChiTietHoacThemSanPham.ShowDialog();
            ReloadDataGridView(null, null);
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa các dữ liệu này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    BLLSanPham.Instance.DeleteSanPham(row.Cells[0].Value.ToString());
                }
                ReloadDataGridView(null, null);
                MessageBox.Show("Đã xoá thành công!");
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

        private void buttonAscendingDescending_Click(object sender, EventArgs e)
        {
            if (ascendingSort == true)
            {
                ascendingSort = false;
                buttonAscendingDescending.Image = Properties.Resources.downarrow20;
                ReloadDataGridView(null, null);
            }
            else
            {
                ascendingSort = true;
                buttonAscendingDescending.Image = Properties.Resources.uparrow20;
                ReloadDataGridView(null, null);
            }
        }
    }
}
