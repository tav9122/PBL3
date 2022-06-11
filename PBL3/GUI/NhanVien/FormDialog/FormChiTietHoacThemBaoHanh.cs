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
            typeUpdate = false;
        }

        public FormChiTietHoacThemBaoHanh(string soSeri)
        {
            InitializeComponent();
            typeUpdate = true;

            textBoxSoSeri.Text = soSeri;
            dateTimePickerThoiGianGiaoTaoPhieuBaoHanh.Value = BLLBaoHanh.Instance.GetBaoHanh(soSeri).ThoiGianTaoPhieuBaoHanh;
            textBoxGhiChu.Text = BLLBaoHanh.Instance.GetBaoHanh(soSeri).GhiChu;
            radioButtonHoanThanh.Checked = BLLBaoHanh.Instance.GetBaoHanh(soSeri).TrangThai;

            textBoxSoSeri.Enabled = false;
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

        private void textBoxSoSeri_Leave(object sender, EventArgs e)
        {
            try
            {
                var vatPham = BLLVatPham.Instance.GetVatPham(textBoxSoSeri.Text);
                textBoxTenSanPham.Text = vatPham.SanPham.TenSanPham;
                textBoxTenKhachHang.Text = vatPham.HoaDon.KhachHang.TenKhachHang;
                textBoxDiaChi.Text = vatPham.HoaDon.KhachHang.DiaChi;
                textBoxMaKhachHang.Text = vatPham.HoaDon.KhachHang.MaKhachHang;
                textBoxSoDienThoai.Text = vatPham.HoaDon.KhachHang.SoDienThoai;
                buttonXacNhan.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Vật phẩm chưa được mua hoặc không có trên hệ thống");
                buttonXacNhan.Enabled = false;
                return;
            }
            if (BLLButtonBaoHanh.Instance.DaysExceedWarrantyPeriod(textBoxSoSeri.Text) != 0)
            {
                MessageBox.Show("Thông báo: Vật phẩm đã quá hạn bảo hành " + BLLButtonBaoHanh.Instance.DaysExceedWarrantyPeriod(textBoxSoSeri.Text).ToString() + " ngày!");
            }
        }
    }
}
