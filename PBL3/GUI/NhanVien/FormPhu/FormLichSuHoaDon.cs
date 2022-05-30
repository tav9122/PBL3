using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormLichSuHoaDon : Form
    {
        public FormLichSuHoaDon()
        {
            InitializeComponent();
            comboBoxKieuSapXep.SelectedIndex = 0;
            foreach (var i in typeof(ViewHoaDon).GetProperties())
            {
                comboBoxKieuSapXep.Items.Add(i.Name);
            }
            ReloadDataGridView(null, null);
        }

        private void ReloadDataGridView(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLLichSuHoaDon.Instance.GetHoaDons(comboBoxKieuSapXep.Text, textBoxTimKiem.Text);
        }

        #region Các hàm chức năng cơ bản, hạn chế sửa.

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns["ThanhTien"].DefaultCellStyle.Format = "C0";
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

        #endregion

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa các dữ liệu này?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    BLLLichSuHoaDon.Instance.DeleteHoaDon(row.Cells[0].Value.ToString());
                }
                MessageBox.Show("Đã xoá thành công!");
                ReloadDataGridView(null, null);
            }
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            FormChiTietHoacThemHoaDon formChiTietHoacThemHoaDon = new FormChiTietHoacThemHoaDon(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            formChiTietHoacThemHoaDon.ShowDialog();
        }
    }
}
