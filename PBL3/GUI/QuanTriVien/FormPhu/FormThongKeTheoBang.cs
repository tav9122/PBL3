using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormThongKeTheoBang : Form
    {
        Dictionary<string, string> dictionaryTongTien = TypeDescriptor.GetProperties(typeof(ViewSanPham_QuanTriVien_ThongKeTheoBang_TongTien)).Cast<PropertyDescriptor>().ToDictionary(p => p.Name, p => p.DisplayName);
        Dictionary<string, string> dictionarySoLuong = TypeDescriptor.GetProperties(typeof(ViewSanPham_QuanTriVien_ThongKeTheoBang_SoLuong)).Cast<PropertyDescriptor>().ToDictionary(p => p.Name, p => p.DisplayName);

        public FormThongKeTheoBang()
        {
            InitializeComponent();

            comboBoxKieuThongKe.SelectedIndex = 0;

            dictionaryTongTien.Select(d => d.Value).ToList().ForEach(i => comboBoxKieuSapXep.Items.Add(i));
            comboBoxKieuSapXep.SelectedIndex = 0;

            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, DateTime.Now.Day, 0, 0, 0);

            ReloadDataGridView(null, null);
            dataGridView1.Columns["TenSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void ReloadDataGridView(object sender, EventArgs e)
        {
            if (sender is ComboBox && ((ComboBox)sender).Name == "comboBoxKieuThongKe")
            {
                comboBoxKieuSapXep.Items.Clear();
            }

            dateTimePicker1.Value = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, dateTimePicker1.Value.Day, 0, 0, 0);
            dateTimePicker2.Value = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day, 23, 59, 59);

            if (comboBoxKieuThongKe.Text == "Tổng tiền nhập hàng và doanh thu")
            {
                if (sender is ComboBox && ((ComboBox)sender).Name == "comboBoxKieuThongKe")
                {
                    dictionaryTongTien.Select(d => d.Value).ToList().ForEach(i => comboBoxKieuSapXep.Items.Add(i));
                    comboBoxKieuSapXep.SelectedIndex = 0;
                }
                dataGridView1.DataSource = BLLButtonThongKeTheoBang.Instance.GetTongTienSanPhams(dictionaryTongTien.FirstOrDefault(d => d.Value == comboBoxKieuSapXep.Text).Key, textBoxTimKiem.Text, dateTimePicker1.Value, dateTimePicker2.Value);

                double tongTienNhap = 0;
                double tongDoanhThu = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    tongTienNhap += (double)row.Cells["TongTienNhap"].Value;
                    tongDoanhThu += (double)row.Cells["TongDoanhThu"].Value;
                }
                labelTongNhapDangHienThi.Text = "Tổng số tiền nhập hàng của các sản phẩm đang hiển thị: " + tongTienNhap.ToString("C0");
                labelTongBanDangHienThi.Text = "Tổng doanh thu của các sản phẩm đang hiển thị: " + tongDoanhThu.ToString("C0");

                dataGridView1.Columns["TongDoanhThu"].DefaultCellStyle.Format = "C0";
                dataGridView1.Columns["TongTienNhap"].DefaultCellStyle.Format = "C0";
            }

            else if (comboBoxKieuThongKe.Text == "Số lượng nhập và bán")
            {
                if (sender is ComboBox && ((ComboBox)sender).Name == "comboBoxKieuThongKe")
                {
                    dictionarySoLuong.Select(d => d.Value).ToList().ForEach(i => comboBoxKieuSapXep.Items.Add(i));
                    comboBoxKieuSapXep.SelectedIndex = 0;
                }

                dataGridView1.DataSource = BLLButtonThongKeTheoBang.Instance.GetSoLuongSanPhams(dictionarySoLuong.FirstOrDefault(d => d.Value == comboBoxKieuSapXep.Text).Key, textBoxTimKiem.Text, dateTimePicker1.Value, dateTimePicker2.Value);

                int soLuongNhap = 0;
                int tongSoLuongBan = 0;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    soLuongNhap += (int)row.Cells["SoLuongNhap"].Value;
                    tongSoLuongBan += (int)row.Cells["SoLuongBan"].Value;
                }
                labelTongNhapDangHienThi.Text = "Tổng số lượng nhập của các sản phẩm đang hiển thị: " + soLuongNhap + " sản phẩm";
                labelTongBanDangHienThi.Text = "Tổng số lượng đã bán của các sản phẩm đang hiển thị: " + tongSoLuongBan + " sản phẩm";
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
    }
}
