using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormChiTietHoacThemKhachHang : Form
    {
        bool typeUpdate = false;
        public FormChiTietHoacThemKhachHang(string maKhachHang)
        {
            InitializeComponent();
            InitializeKhachHangInformations(maKhachHang);
        }
        public FormChiTietHoacThemKhachHang()
        {
            InitializeComponent();
            InitializeNewKhachHangInformations();
        }

        #region Các hàm chức năng cơ bản, hạn chế sửa

        public void InitializeNewKhachHangInformations()
        {
            typeUpdate = false;
            labelTieuDe.Text = "Thêm khách hàng:";
            textBoxMaKhachHang.Text = BLLQuanLiChung.Instance.GetNextPrimaryKey(BLLQuanLiKhachHang.Instance.GetMaKhachHangs());
        }

        public void InitializeKhachHangInformations(string maKhachHang)
        {
            typeUpdate = true;
            labelTieuDe.Text = "Chi tiết khách hàng:";
            var khachHang = BLLQuanLiKhachHang.Instance.GetKhachHang(maKhachHang);
            textBoxMaKhachHang.Text = khachHang.MaKhachHang;
            textBoxTenKhachHang.Text = khachHang.TenKhachHang;
            textBoxDiaChi.Text = khachHang.DiaChi;
            textBoxSoDienThoai.Text = khachHang.SoDienThoai;
            textBoxGhiChu.Text = khachHang.GhiChu;
        }
        private void buttonHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
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
        #endregion

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            if (textBoxDiaChi.Text == "" || textBoxMaKhachHang.Text == "" || textBoxSoDienThoai.Text == "" || textBoxTenKhachHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                if (typeUpdate == true)
                {
                    BLLQuanLiKhachHang.Instance.UpdateKhachHang(textBoxMaKhachHang.Text, textBoxTenKhachHang.Text, textBoxDiaChi.Text, textBoxSoDienThoai.Text, textBoxGhiChu.Text);
                    MessageBox.Show("Đã cập nhật thành công!");
                    BLLQuanLiChung.Instance.alreadyOpenFormBaoHanh = false;
                    BLLQuanLiChung.Instance.formBaoHanh = null;
                    this.Close();
                }
                else
                {
                    BLLQuanLiKhachHang.Instance.AddKhachHang(textBoxMaKhachHang.Text, textBoxTenKhachHang.Text, textBoxDiaChi.Text, textBoxSoDienThoai.Text, textBoxGhiChu.Text);
                    MessageBox.Show("Đã thêm thành công!");
                    this.Close();
                }

            }
        }
    }
}
