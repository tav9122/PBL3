using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormBaoHanh : Form
    {
        public FormBaoHanh()
        {
            InitializeComponent();
            UpdateView();
            comboBoxSapXep.Items.AddRange(new string[]
            {
                "SoSeri", "TenVatPham", "TenKhachHang", "ThoiGianBatDauBaoHanh", "TrangThai"
            });
            buttonSua.Enabled = false;
        }
        private void textBoxTimKiem_Enter(object sender, EventArgs e)
        {
            if (textBoxTimKiem.Text == "Tìm theo tên khách/tên sản phẩm...")
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
                textBoxTimKiem.Text = "Tìm theo tên khách/tên sản phẩm...";
            }
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            FormChiTietHoacThemBaoHanh f = new FormChiTietHoacThemBaoHanh("",
                comboBoxSapXep.SelectedIndex);
            f.Del = new FormChiTietHoacThemBaoHanh.BaoHanhDel(UpdateView);
            f.ShowDialog();
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            FormChiTietHoacThemBaoHanh f = new FormChiTietHoacThemBaoHanh(
                dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                comboBoxSapXep.SelectedIndex);
            f.Del = new FormChiTietHoacThemBaoHanh.BaoHanhDel(UpdateView);
            f.ShowDialog();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1) buttonSua.Enabled = true;
            else buttonSua.Enabled = false;
        }
        private void UpdateView(int ordertype = 0, string search = "")
        {
            dataGridView1.DataSource = BLLQuanLiSanPham.Instance.GetAllBaoHanh(ordertype, search);
            dataGridView1.ClearSelection();
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void comboBoxSapXep_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxSapXep.SelectedIndex != -1) UpdateView(comboBoxSapXep.SelectedIndex);
        }

        private void textBoxTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                UpdateView(comboBoxSapXep.SelectedIndex, textBoxTimKiem.Text);
            }
        }
    }
}
