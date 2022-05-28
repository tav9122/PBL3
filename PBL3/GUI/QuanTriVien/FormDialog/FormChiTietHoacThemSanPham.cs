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
            InitializeComboBoxLoaiSanPhamItems();
            typeUpdate = false;
            labelTieuDe.Text = "Thêm sản phẩm:";
        }

        public FormChiTietHoacThemSanPham(string maSanPham)
        {
            InitializeComponent();
            InitializeComboBoxLoaiSanPhamItems();
            InitializeSanPhamInformations(maSanPham);
            typeUpdate = true;
            labelTieuDe.Text = "Chi tiết sản phẩm:";
            comboBoxLoaiSanPham.Enabled = false;
        }
        #region Các hàm chức năng cơ bản, hạn chế sửa
        public void InitializeSanPhamInformations(string maSanPham)
        {
            var sanPham = BLLQuanLiSanPham.Instance.GetSanPham(maSanPham);
            textBoxMaSanPham.Text = sanPham.MaSanPham;
            textBoxTenSanPham.Text = sanPham.TenSanPham;
            textBoxGiaBan.Text = sanPham.GiaBan.ToString();
            textBoxSoLuongNhap.Text = sanPham.SoLuongNhap.ToString();
            textBoxSoLuongHienTai.Text = sanPham.SoLuongHienTai.ToString();
            textBoxGiaMua.Text = sanPham.GiaMua.ToString();
            comboBoxLoaiSanPham.Text = sanPham.LoaiSanPham;
            textBoxTenHang.Text = sanPham.TenHang;
            textBoxThoiGianBaoHanh.Text = sanPham.ThoiGianBaoHanh;
        }
        public void InitializeComboBoxLoaiSanPhamItems()
        {
            foreach (string i in BLLQuanLiSanPham.Instance.GetLoaiSanPhams())
            {
                comboBoxLoaiSanPham.Items.Add(i);
            }
        }

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

        private void buttonHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxLoaiSanPham_TextChanged(object sender, EventArgs e)
        {
            if (!typeUpdate)
                try
                {
                    textBoxMaSanPham.Text = BLLQuanLiChung.Instance.GetNextPrimaryKey(BLLQuanLiSanPham.Instance.GetLoaiSanPhams(), comboBoxLoaiSanPham.Text);
                }
                catch
                {
                }
        }
        private void textBoxSoLuongNhap_Leave(object sender, EventArgs e)
        {
            if (!typeUpdate)
                textBoxSoLuongHienTai.Text = textBoxSoLuongNhap.Text;
            else
            {
                try
                {
                    if (Convert.ToInt32(textBoxSoLuongNhap.Text) < BLLQuanLiSanPham.Instance.GetSanPham(textBoxMaSanPham.Text).SoLuongNhap)
                    {
                        textBoxSoLuongNhap.Text = BLLQuanLiSanPham.Instance.GetSanPham(textBoxMaSanPham.Text).SoLuongNhap.ToString();
                    }
                    textBoxSoLuongHienTai.Text = (BLLQuanLiSanPham.Instance.GetSanPham(textBoxMaSanPham.Text).SoLuongHienTai + (Convert.ToInt32(textBoxSoLuongNhap.Text) - BLLQuanLiSanPham.Instance.GetSanPham(textBoxMaSanPham.Text).SoLuongNhap)).ToString();
                }
                catch
                {
                    textBoxSoLuongNhap.Text = BLLQuanLiSanPham.Instance.GetSanPham(textBoxMaSanPham.Text).SoLuongNhap.ToString();
                }
            }
        }
        #endregion

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
                    int currentSoLuongNhap = BLLQuanLiSanPham.Instance.GetSanPham(textBoxMaSanPham.Text).SoLuongNhap;
                    BLLQuanLiSanPham.Instance.UpdateSanPham(textBoxMaSanPham.Text, textBoxTenSanPham.Text, textBoxTenHang.Text, comboBoxLoaiSanPham.Text, Convert.ToDouble(textBoxGiaMua.Text), Convert.ToDouble(textBoxGiaBan.Text), Convert.ToInt32(textBoxSoLuongNhap.Text), Convert.ToInt32(textBoxSoLuongHienTai.Text), textBoxThoiGianBaoHanh.Text);
                    BLLQuanLiSanPham.Instance.InitializeNewSeri(Convert.ToInt32(textBoxSoLuongNhap.Text) - currentSoLuongNhap, textBoxMaSanPham.Text);
                }
                else
                {
                    BLLQuanLiSanPham.Instance.AddSanPham(textBoxMaSanPham.Text, textBoxTenSanPham.Text, textBoxTenHang.Text, comboBoxLoaiSanPham.Text, Convert.ToDouble(textBoxGiaMua.Text), Convert.ToDouble(textBoxGiaBan.Text), Convert.ToInt32(textBoxSoLuongNhap.Text), Convert.ToInt32(textBoxSoLuongHienTai.Text), textBoxThoiGianBaoHanh.Text);
                    BLLQuanLiSanPham.Instance.InitializeNewSeri(Convert.ToInt32(textBoxSoLuongNhap.Text), textBoxMaSanPham.Text);
                }
                this.Close();
            }
        }
    }
}
