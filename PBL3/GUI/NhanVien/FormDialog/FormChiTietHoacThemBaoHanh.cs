using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormChiTietHoacThemBaoHanh : Form
    {
        bool typeUpdate = false;
        public FormChiTietHoacThemBaoHanh()
        {
            InitializeComponent();
            InitializeNewBaoHanhInformation();
        }

        public FormChiTietHoacThemBaoHanh(string soSeri)
        {
            InitializeComponent();
            InitializeBaoHanhInformation(soSeri);
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

        private void textBoxSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            if (BLLQuanLiKhachHang.Instance.GetKhachHang(textBoxSoDienThoai.Text) != null)
            {
                textBoxTenKhachHang.Text = BLLQuanLiKhachHang.Instance.GetKhachHang(textBoxSoDienThoai.Text).TenKhachHang;
                textBoxDiaChi.Text = BLLQuanLiKhachHang.Instance.GetKhachHang(textBoxSoDienThoai.Text).DiaChi;
                textBoxMaKhachHang.Text = BLLQuanLiKhachHang.Instance.GetKhachHang(textBoxSoDienThoai.Text).MaKhachHang;
            }
        }
        private void textBoxSoSeri_TextChanged(object sender, EventArgs e)
        {
            textBoxTenSanPham.Text = BLLSanPham.Instance.GetTenSanPhamBySoSeri(textBoxSoSeri.Text);
        }

        private void InitializeNewBaoHanhInformation()
        {
            typeUpdate = false;
        }

        private void InitializeBaoHanhInformation(string soSeri)
        {
            typeUpdate = true;
            textBoxSoSeri.Text = soSeri;
            textBoxSoSeri.Enabled = false;
            dateTimePickerThoiGianGiaoTaoPhieuBaoHanh.Value = BLLBaoHanh.Instance.GetBaoHanh(soSeri).ThoiGianTaoPhieuBaoHanh;
            textBoxSoDienThoai.Text = BLLSanPham.Instance.GetSoDienThoaiKhachHangBySoSeri(soSeri);
            textBoxSoDienThoai.Enabled = false;
            textBoxGhiChu.Text = BLLBaoHanh.Instance.GetBaoHanh(soSeri).GhiChu;
            radioButtonHoanThanh.Checked = BLLBaoHanh.Instance.GetBaoHanh(soSeri).TrangThai;
        }

        private void buttonHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            if (typeUpdate == false)
            {
                if (textBoxSoSeri.Text == "" || textBoxSoDienThoai.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                }
                else if (BLLSanPham.Instance.GetSoDienThoaiKhachHangBySoSeri(textBoxSoSeri.Text) == null)
                {
                    MessageBox.Show("Sản phẩm này chưa được mua hoặc không có trong hệ thống!");
                }
                else if (BLLQuanLiKhachHang.Instance.GetKhachHang(textBoxSoDienThoai.Text) == null)
                {
                    MessageBox.Show("Khách hàng không tồn tại!");
                }
                else if (BLLBaoHanh.Instance.GetBaoHanh(textBoxSoSeri.Text) != null)
                {
                    MessageBox.Show("Sản phẩm này đã đang có trong danh sách bảo hành!");
                }
                else
                {
                    BLLBaoHanh.Instance.AddBaoHanh(textBoxSoSeri.Text, radioButtonHoanThanh.Checked, textBoxGhiChu.Text, DateTime.Now);
                    MessageBox.Show("Đã thêm thành công!");
                    this.Close();
                }
            }
            else
            {
                BLLBaoHanh.Instance.UpdateBaoHanh(textBoxSoSeri.Text, radioButtonHoanThanh.Checked, textBoxGhiChu.Text);
                MessageBox.Show("Đã cập nhật thành công!");
                this.Close();
            }
        }
    }
}
