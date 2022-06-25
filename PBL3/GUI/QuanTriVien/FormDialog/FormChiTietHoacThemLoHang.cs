using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormChiTietHoacThemLoHang : Form
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();

        public bool typeView = false;

        public FormChiTietHoacThemLoHang()
        {
            dictionary = TypeDescriptor.GetProperties(typeof(ViewSanPham_QuanTriVien_LoHang)).Cast<PropertyDescriptor>().ToDictionary(p => p.Name, p => p.DisplayName);

            InitializeComponent();
            typeView = false;

            labelTieuDe.Text = "Thêm lô hàng:";

            dictionary.Select(d => d.Value).ToList().ForEach(i => comboBoxKieuSapXep.Items.Add(i));
            comboBoxKieuSapXep.SelectedIndex = 0;

            textBoxMaLoHang.Text = BLLQuanLiChung.Instance.GetNextPrimaryKey(BLLLoHang.Instance.GetMaLoHangs());
            dateTimePicker1.Value = DateTime.Now;
            textBoxTongTien.Text = 0.ToString("C0");

            ReloadDataGridView(null, null);
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                if (col != dataGridView1.Columns["SoLuongNhapThem"])
                    col.ReadOnly = true;
            }
            dataGridView1.Columns["TenSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["GiaMua"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["GiaBan"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["GiaBan"].DefaultCellStyle.Format = "C0";
            dataGridView1.Columns["GiaMua"].DefaultCellStyle.Format = "C0";

            labelSoLuongCacVatPhamDangHienThi.Visible = false;
            labelTongTienCacVatPhamDangHienThi.Visible = false;
        }

        public FormChiTietHoacThemLoHang(string maLoHang)
        {
            dictionary = TypeDescriptor.GetProperties(typeof(ViewVatPham_QuanTriVien)).Cast<PropertyDescriptor>().ToDictionary(p => p.Name, p => p.DisplayName);

            InitializeComponent();
            typeView = true;

            labelTieuDe.Text = "Chi tiết lô hàng:";

            textBoxMaLoHang.Text = maLoHang;

            dictionary.Select(d => d.Value).ToList().ForEach(i => comboBoxKieuSapXep.Items.Add(i));
            comboBoxKieuSapXep.SelectedIndex = 0;

            var loHang = BLLLoHang.Instance.GetLoHang(maLoHang);
            dateTimePicker1.Value = loHang.ThoiGianNhapHang;
            textBoxTongTien.Text = loHang.TongTien.ToString("C0");

            buttonXacNhan.Visible = false;
            buttonThemSanPhamMoi.Visible = false;
            buttonResetSoLuongNhapThem.Visible = false;
            dataGridView1.ReadOnly = true;

            ReloadDataGridView(null, null);
            dataGridView1.Columns["TenSanPham"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["SoSeri"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["GiaMua"].DefaultCellStyle.Format = "C0";
        }

        private void ReloadDataGridView(object sender, EventArgs e)
        {
            if (typeView == false)
                dataGridView1.DataSource = BLLButtonQuanLiLoHang.Instance.GetSanPhams(dictionary.FirstOrDefault(d => d.Value == comboBoxKieuSapXep.Text).Key, textBoxTimKiem.Text);
            else
            {
                dataGridView1.DataSource = BLLButtonQuanLiLoHang.Instance.GetVatPhams(dictionary.FirstOrDefault(d => d.Value == comboBoxKieuSapXep.Text).Key, textBoxTimKiem.Text, textBoxMaLoHang.Text);
                labelSoLuongCacVatPhamDangHienThi.Text = "Số lượng các vật phẩm đang hiển thị: " + dataGridView1.RowCount.ToString();

                double tongTien = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    tongTien += (double)row.Cells["GiaMua"].Value;
                }
                labelTongTienCacVatPhamDangHienThi.Text = "Tổng tiền các vật phẩm đang hiển thị: " + tongTien.ToString("C0");
            }
        }
        #region Các hàm chức năng cơ bản, hạn chế sửa.

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        private void buttonHuyBo_Click(object sender, EventArgs e)
        {
            BLLSanPham.Instance.ResetTemp();
            this.Close();
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            if (BLLSanPham.Instance.GetSanPhamWithTempValueGreaterThanZero().Count == 0)
            {
                MessageBox.Show("Số lượng sản phẩm nhập thêm không được bằng 0!");
                return;
            }
            BLLLoHang.Instance.AddLoHang(textBoxMaLoHang.Text, dateTimePicker1.Value, Convert.ToDouble(textBoxTongTien.Text.Substring(0, textBoxTongTien.Text.Length - 2)));
            foreach (SanPham sanPham in BLLSanPham.Instance.GetSanPhamWithTempValueGreaterThanZero())
            {
                BLLVatPham.Instance.InitializeNewVatPhams(sanPham.Temp, sanPham.MaSanPham, textBoxMaLoHang.Text);
            }

            BLLQuanLiChung.Instance.alreadyOpenFormQuanLiSanPham = false;
            BLLQuanLiChung.Instance.formQuanLiSanPham = null;
            BLLQuanLiChung.Instance.alreadyOpenFormThongKeTheoBang = false;
            BLLQuanLiChung.Instance.formThongKeTheoBang = null;

            MessageBox.Show("Lưu lô nhập hàng thành công!");
            this.Close();
        }

        private void buttonThemSanPhamMoi_Click(object sender, EventArgs e)
        {
            FormChiTietHoacThemSanPham formChiTietHoacThemSanPham = new FormChiTietHoacThemSanPham();
            formChiTietHoacThemSanPham.ShowDialog();
            ReloadDataGridView(null, null);
        }

        private void buttonResetSoLuongNhapThem_Click(object sender, EventArgs e)
        {
            textBoxTongTien.Text = 0.ToString("C0");
            BLLSanPham.Instance.ResetTemp();
            ReloadDataGridView(null, null);
            MessageBox.Show("Đã reset thành công!");
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Convert.ToInt32(dataGridView1.CurrentCell.Value) < 0)
            {
                MessageBox.Show("Số lượng nhập không hợp lệ!");
                dataGridView1.CurrentCell.Value = 0;
            }
            BLLSanPham.Instance.SetTempValue(dataGridView1.CurrentRow.Cells["MaSanPham"].Value.ToString(), Convert.ToInt32(dataGridView1.CurrentRow.Cells["SoLuongNhapThem"].Value));
            textBoxTongTien.Text = BLLButtonQuanLiLoHang.Instance.GetTongTien().ToString("C0");
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
