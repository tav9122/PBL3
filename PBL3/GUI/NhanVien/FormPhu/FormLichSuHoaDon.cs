using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormLichSuHoaDon : Form
    {
        Dictionary<string, string> dictionary = TypeDescriptor.GetProperties(typeof(ViewHoaDon)).Cast<PropertyDescriptor>().ToDictionary(p => p.Name, p => p.DisplayName);
        bool ascendingSort = true;

        public FormLichSuHoaDon()
        {
            InitializeComponent();

            dictionary.Select(d => d.Value).ToList().ForEach(i => comboBoxKieuSapXep.Items.Add(i));
            comboBoxKieuSapXep.SelectedIndex = 0;

            ReloadDataGridView(null, null);
            dataGridView1.Columns["ThanhTien"].DefaultCellStyle.Format = "C0";
            dataGridView1.Columns["TenNhanVien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void ReloadDataGridView(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLLButtonLichSuHoaDon.Instance.GetHoaDons(dictionary.FirstOrDefault(d => d.Value == comboBoxKieuSapXep.Text).Key, textBoxTimKiem.Text, ascendingSort);
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            FormChiTietHoacThemHoaDon formChiTietHoacThemHoaDon = new FormChiTietHoacThemHoaDon(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            formChiTietHoacThemHoaDon.ShowDialog();
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
