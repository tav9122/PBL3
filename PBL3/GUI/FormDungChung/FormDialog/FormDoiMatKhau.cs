using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormDoiMatKhau : Form
    {
        string currentMatKhau;

        public FormDoiMatKhau(string maNhanVien)
        {
            InitializeComponent();

            textBoxTenDangNhap.Text = BLLTaiKhoan.Instance.GetTenDangNhapNhanVien(maNhanVien);
            currentMatKhau = BLLTaiKhoan.Instance.GetMatKhauNhanVien(maNhanVien);
        }

        #region Các hàm cơ bản, hạn chế sửa.
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
            BLLTaiKhoan.Instance.UpdateMatKhauNhanVien(textBoxTenDangNhap.Text, textBoxMatKhauCu.Text);
            MessageBox.Show("Đổi mật khẩu thành công!");
            this.Close();
        }

        private void textBoxMatKhauCu_Leave(object sender, EventArgs e)
        {
            if (textBoxMatKhauCu.Text != currentMatKhau)
            {
                textBoxCanhBao.Text = "Mật khẩu cũ không đúng!";
                textBoxMatKhauMoi.Enabled = false;
                textBoxNhapLaiMatKhauMoi.Enabled = false;
            }
            else
            {
                textBoxCanhBao.Text = "";
                textBoxMatKhauMoi.Enabled = true;
                textBoxNhapLaiMatKhauMoi.Enabled = true;
            }
        }

        private void textBoxMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMatKhauMoi.Text == "" && textBoxNhapLaiMatKhauMoi.Text == "")
            {
                buttonXacNhan.Enabled = false;
                textBoxCanhBao.Text = "";
                return;
            }
            if (textBoxNhapLaiMatKhauMoi.Text != textBoxMatKhauMoi.Text)
            {
                textBoxCanhBao.Text = "Mật khẩu mới không khớp!";
                buttonXacNhan.Enabled = false;
            }
            else
            {
                textBoxCanhBao.Text = "";
                buttonXacNhan.Enabled = true;
            }
        }

        int count = 0;
        private void buttonAnHienMatKhau_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                textBoxMatKhauCu.Multiline = false;
                textBoxNhapLaiMatKhauMoi.Multiline = false;
                buttonAnHienMatKhau.Image = Properties.Resources.openedeye20;
            }
            else
            {
                textBoxMatKhauCu.Multiline = true;
                textBoxNhapLaiMatKhauMoi.Multiline = true;
                buttonAnHienMatKhau.Image = Properties.Resources.closedeye20;
            }
        }
    }
}
