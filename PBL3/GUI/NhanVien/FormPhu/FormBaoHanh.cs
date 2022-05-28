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
            dataGridView1.DataSource = BLLQuanLiSanPham.Instance.GetAllBaoHanh();
            buttonSua.Enabled = false;
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

        private void buttonThem_Click(object sender, EventArgs e)
        {
            FormChiTietHoacThemBaoHanh f = new FormChiTietHoacThemBaoHanh("");
            f.ShowDialog();
        }
        private void buttonSua_Click(object sender, EventArgs e)
        {
            FormChiTietHoacThemBaoHanh f = new FormChiTietHoacThemBaoHanh(
                dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            f.ShowDialog();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1) buttonSua.Enabled = true;
            else buttonSua.Enabled = false;
        }
        private void ResizeDataView()
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        
    }
}
