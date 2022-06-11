using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormChiTietHoacThemSanPham : Form
    {
        private bool typeUpdate;
        public FormChiTietHoacThemSanPham()
        {
            InitializeComponent();
            typeUpdate = false;

            labelTieuDe.Text = "Thêm sản phẩm:";

            InitializeComboBoxLoaiSanPhamItems();

        }

        public FormChiTietHoacThemSanPham(string maSanPham)
        {
            InitializeComponent();
            typeUpdate = true;

            labelTieuDe.Text = "Chi tiết sản phẩm:";

            InitializeComboBoxLoaiSanPhamItems();

            var sanPham = BLLSanPham.Instance.GetSanPham(maSanPham);
            textBoxMaSanPham.Text = sanPham.MaSanPham;
            textBoxTenSanPham.Text = sanPham.TenSanPham;
            textBoxGiaBan.Text = sanPham.GiaBan.ToString("C0");
            textBoxSoLuongNhap.Text = sanPham.SoLuongNhap.ToString();
            textBoxSoLuongHienTai.Text = sanPham.SoLuongHienTai.ToString();
            textBoxGiaMua.Text = sanPham.GiaMua.ToString("C0");
            comboBoxLoaiSanPham.Text = sanPham.LoaiSanPham;
            textBoxTenHang.Text = sanPham.TenHang;
            textBoxThoiGianBaoHanh.Text = sanPham.ThoiGianBaoHanh;

            comboBoxLoaiSanPham.Enabled = false;
        }

        public void InitializeComboBoxLoaiSanPhamItems()
        {
            foreach (string i in BLLSanPham.Instance.GetLoaiSanPhams())
            {
                comboBoxLoaiSanPham.Items.Add(i);
            }
        }

        #region Các hàm chức năng cơ bản, hạn chế sửa

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
            this.Close();
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            if (textBoxTenSanPham.Text == "" || textBoxGiaBan.Text == "" || textBoxSoLuongNhap.Text == "" || textBoxSoLuongHienTai.Text == "" || textBoxGiaMua.Text == "" || textBoxTenHang.Text == "" || textBoxThoiGianBaoHanh.Text == "" || comboBoxLoaiSanPham.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                if (typeUpdate)
                {
                    BLLSanPham.Instance.UpdateSanPham(textBoxMaSanPham.Text, textBoxTenSanPham.Text, textBoxTenHang.Text, comboBoxLoaiSanPham.Text, Convert.ToDouble(textBoxGiaMua.Text.Substring(0, textBoxGiaMua.TextLength - 1)), Convert.ToDouble(textBoxGiaBan.Text.Substring(0, textBoxGiaBan.TextLength - 1)), Convert.ToInt32(textBoxSoLuongNhap.Text), Convert.ToInt32(textBoxSoLuongHienTai.Text), textBoxThoiGianBaoHanh.Text);
                    MessageBox.Show("Đã cập nhật thành công!");
                }
                else
                {
                    BLLSanPham.Instance.AddSanPham(textBoxMaSanPham.Text, textBoxTenSanPham.Text, textBoxTenHang.Text, comboBoxLoaiSanPham.Text, Convert.ToDouble(textBoxGiaMua.Text.Substring(0, textBoxGiaMua.TextLength - 1)), Convert.ToDouble(textBoxGiaBan.Text.Substring(0, textBoxGiaBan.TextLength - 1)), Convert.ToInt32(textBoxSoLuongNhap.Text), Convert.ToInt32(textBoxSoLuongHienTai.Text), textBoxThoiGianBaoHanh.Text);
                    MessageBox.Show("Đã thêm thành công!");
                }
                this.Close();
            }
        }

        private void comboBoxLoaiSanPham_TextChanged(object sender, EventArgs e)
        {
            if (!typeUpdate)
                try
                {
                    textBoxMaSanPham.Text = BLLQuanLiChung.Instance.GetNextPrimaryKey(comboBoxLoaiSanPham.Text);
                }
                catch
                {
                }
        }

        private void textBoxGiaBan_Enter(object sender, EventArgs e)
        {
            try { ((TextBox)sender).Text = ((TextBox)sender).Text.Substring(0, ((TextBox)sender).Text.Length - 2); }
            catch { }
        }

        private void textBoxGiaBan_Leave(object sender, EventArgs e)
        {
            try { ((TextBox)sender).Text = String.Format("{0:C0}", Convert.ToDouble(((TextBox)sender).Text)); }
            catch { }

        }
    }
}
