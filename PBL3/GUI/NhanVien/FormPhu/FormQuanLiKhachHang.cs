using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormQuanLiKhachHang : Form
    {
        public FormQuanLiKhachHang()
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
            dataGridView1.DataSource = BLLQuanLiKhachHang.Instance.GetKhachHangs(comboBoxKieuSapXep.Text, textBoxTimKiem.Text);
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

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            BLLQuanLiKhachHang.Instance.DeleteKhachHang(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            ReloadDataGridView(null, null);
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
