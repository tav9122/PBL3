using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormQuanLiSanPham : Form
    {
        public FormQuanLiSanPham()
        {
            InitializeComponent();

            comboBoxKieuSapXep.SelectedIndex = 0;
            foreach (var i in typeof(ViewSanPham_QuanTriVien).GetProperties())
            {
                comboBoxKieuSapXep.Items.Add(i.Name);
            }
            ReloadDataGridView(null, null);
        }

        private void ReloadDataGridView(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLQuanLiSanPham.Instance.GetSanPhams(comboBoxKieuSapXep.Text, textBoxTimKiem.Text);
        }

        #region Các hàm chức năng cơ bản, hạn chế sửa

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

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string maSanPham;
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                maSanPham = row.Cells[0].Value.ToString();
                BLLQuanLiSanPham.Instance.DeleteSanPham(maSanPham);
            }
            ReloadDataGridView(null, null);
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
    }
}
