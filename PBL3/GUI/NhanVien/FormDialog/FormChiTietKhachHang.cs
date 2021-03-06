using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormChiTietKhachHang : Form
    {
        public FormChiTietKhachHang(string maKhachHang)
        {
            InitializeComponent();

            var khachHang = BLLKhachHang.Instance.GetKhachHang(maKhachHang);
            textBoxMaKhachHang.Text = khachHang.MaKhachHang;
            textBoxTenKhachHang.Text = khachHang.TenKhachHang;
            textBoxDiaChi.Text = khachHang.DiaChi;
            textBoxSoDienThoai.Text = khachHang.SoDienThoai;
            textBoxGhiChu.Text = khachHang.GhiChu;
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
            if (textBoxDiaChi.Text == "" || textBoxMaKhachHang.Text == "" || textBoxSoDienThoai.Text == "" || textBoxTenKhachHang.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
            else
            {
                BLLKhachHang.Instance.UpdateKhachHang(textBoxMaKhachHang.Text, textBoxTenKhachHang.Text, textBoxDiaChi.Text, textBoxSoDienThoai.Text, textBoxGhiChu.Text);
                BLLQuanLiChung.Instance.alreadyOpenFormBaoHanh = false;
                BLLQuanLiChung.Instance.formBaoHanh = null;
                MessageBox.Show("Đã cập nhật thành công!");
                this.Close();
            }
        }
    }
}
