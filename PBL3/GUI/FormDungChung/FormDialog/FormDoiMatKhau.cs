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

            textBoxTenDangNhap.Text = BLLQuanLiNhanVien.Instance.GetTenDangNhapNhanVien(maNhanVien);
            currentMatKhau = BLLQuanLiNhanVien.Instance.GetMatKhauNhanVien(maNhanVien);
            textBoxMatKhau.Text = BLLQuanLiNhanVien.Instance.GetMatKhauNhanVien(maNhanVien);
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

        int count = 0;
        private void buttonAnHienMatKhau_Click(object sender, EventArgs e)
        {
            count++;
            if (count % 2 == 0)
            {
                textBoxMatKhau.Multiline = false;
                textBoxNhapLaiMatKhauMoi.Multiline = false;
                buttonAnHienMatKhau.Image = Properties.Resources.openedeye20;
            }
            else
            {
                textBoxMatKhau.Multiline = true;
                textBoxNhapLaiMatKhauMoi.Multiline = true;
                buttonAnHienMatKhau.Image = Properties.Resources.closedeye20;
            }
        }

        private void buttonHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBoxMatKhau_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMatKhau.Text != currentMatKhau)
            {
                label8.Visible = true;
                textBoxNhapLaiMatKhauMoi.Visible = true;
                if (textBoxNhapLaiMatKhauMoi.Text != textBoxMatKhau.Text)
                {
                    textBoxCanhBao.Text = "Mật khẩu không khớp";
                }
                else
                    textBoxCanhBao.Text = "";
            }
            else
            {
                label8.Visible = false;
                textBoxNhapLaiMatKhauMoi.Visible = false;
                textBoxCanhBao.Text = "";
            }
        }

        private void textBoxNhapLaiMatKhauMoi_TextChanged(object sender, EventArgs e)
        {
            if (textBoxNhapLaiMatKhauMoi.Text != textBoxMatKhau.Text)
            {
                textBoxCanhBao.Text = "Mật khẩu không khớp";
            }
            else
                textBoxCanhBao.Text = "";
        }
        #endregion

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            if (textBoxMatKhau.Text != currentMatKhau && textBoxMatKhau.Text != textBoxNhapLaiMatKhauMoi.Text)
            {
                MessageBox.Show("Mật khẩu ở cả 2 trường cần phải giống nhau!");
            }
            else
            {
                BLLQuanLiNhanVien.Instance.UpdateMatKhauNhanVien(textBoxTenDangNhap.Text, textBoxMatKhau.Text);
                this.Close();
            }
        }
    }
}
