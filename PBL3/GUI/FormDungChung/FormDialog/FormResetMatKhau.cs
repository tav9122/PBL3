using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormResetMatKhau : Form
    {
        public FormResetMatKhau()
        {
            InitializeComponent();
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
            try
            {
                BLLTaiKhoan.Instance.UpdateAndSendTaiKhoanInformationToMail(textBoxEmailAddress.Text, "", BLLTaiKhoan.Instance.GenerateSixLengthRandomMatKhau());
                MessageBox.Show("Đã gửi mật khẩu mới đến email của bạn!");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Email không hợp lệ!");
            }
        }
    }
}
