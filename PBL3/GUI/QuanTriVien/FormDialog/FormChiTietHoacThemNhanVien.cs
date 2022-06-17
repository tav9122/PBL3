using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormChiTietHoacThemNhanVien : Form
    {
        public bool typeUpdate = false;
        public List<ViewLichLamViec> listLichLamViecTamThoi = new List<ViewLichLamViec>();
        public string currentMatKhau = "";
        public FormChiTietHoacThemNhanVien()
        {
            InitializeComponent();
            typeUpdate = false;

            labelTieuDe.Text = "Thêm nhân viên:";
            buttonTaoHoacResetMatKhau.Text = "Tạo mật khẩu";

            textBoxMaNhanVien.Text = BLLQuanLiChung.Instance.GetNextPrimaryKey(BLLNhanVien.Instance.GetMaNhanViens());

            dataGridView1.DataSource = BLLNhanVienLichLamViec.Instance.GetLichLamViecsOfNhanVien("");
            dataGridView1.Columns["NhanViens"].Visible = false;
        }

        public FormChiTietHoacThemNhanVien(string maNhanVien)
        {
            InitializeComponent();
            typeUpdate = true;

            labelTieuDe.Text = "Chi tiết nhân viên:";
            buttonTaoHoacResetMatKhau.Text = "Reset mật khẩu";

            listLichLamViecTamThoi = BLLNhanVienLichLamViec.Instance.GetLichLamViecsOfNhanVien(maNhanVien);

            var nhanVien = BLLNhanVien.Instance.GetNhanVien(maNhanVien);
            currentMatKhau = BLLTaiKhoan.Instance.GetMatKhauNhanVien(nhanVien.MaNhanVien);
            textBoxMaNhanVien.Text = nhanVien.MaNhanVien;
            textBoxTenNhanVien.Text = nhanVien.HoVaTen;
            textBoxDiaChi.Text = nhanVien.DiaChi;
            textBoxSoDienThoai.Text = nhanVien.SoDienThoai;
            textBoxEmail.Text = nhanVien.Email;
            textBoxMucLuong.Text = nhanVien.MucLuong.ToString();
            radioButtonNam.Checked = nhanVien.GioiTinh;
            dateTimePickerNgaySinh.Value = nhanVien.NgaySinh;
            textBoxTenDangNhap.Text = BLLTaiKhoan.Instance.GetTenDangNhapNhanVien(nhanVien.MaNhanVien);
            textBoxMatKhau.Text = BLLTaiKhoan.Instance.GetMatKhauNhanVien(nhanVien.MaNhanVien);

            textBoxTenDangNhap.Enabled = false;

            dataGridView1.DataSource = BLLNhanVienLichLamViec.Instance.GetLichLamViecsOfNhanVien(nhanVien.MaNhanVien);
            dataGridView1.Columns["NhanViens"].Visible = false;
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
            if (textBoxTenNhanVien.Text == "" || textBoxSoDienThoai.Text == "" || textBoxEmail.Text == "" || textBoxDiaChi.Text == "" || textBoxMucLuong.Text == "" || textBoxTenDangNhap.Text == "" || textBoxMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (textBoxMatKhau.Text != currentMatKhau && textBoxMatKhau.Text != textBoxNhapLaiMatKhauMoi.Text)
            {
                MessageBox.Show("Mật khẩu ở hai trường cần phải giống nhau!");
                return;
            }
            if (typeUpdate == true)
            {
                BLLNhanVien.Instance.UpdateNhanVien(textBoxMaNhanVien.Text, textBoxSoDienThoai.Text, textBoxEmail.Text, textBoxDiaChi.Text, textBoxTenNhanVien.Text, dateTimePickerNgaySinh.Value, radioButtonNam.Checked, Convert.ToDouble(textBoxMucLuong.Text), listLichLamViecTamThoi.Select(llv => llv.MaLichLamViec).ToList());
                BLLTaiKhoan.Instance.UpdateMatKhauNhanVien(textBoxTenDangNhap.Text, textBoxMatKhau.Text);
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                BLLNhanVien.Instance.AddNhanVien(textBoxMaNhanVien.Text, textBoxSoDienThoai.Text, textBoxEmail.Text, textBoxDiaChi.Text, textBoxTenNhanVien.Text, dateTimePickerNgaySinh.Value, radioButtonNam.Checked, Convert.ToDouble(textBoxMucLuong.Text), listLichLamViecTamThoi.Select(llv => llv.MaLichLamViec).ToList(), textBoxTenDangNhap.Text, textBoxMatKhau.Text);
                BLLQuanLiChung.Instance.ResetAndSendNewPasswordToEmail(textBoxEmail.Text, textBoxMatKhau.Text);
                MessageBox.Show("Thêm thành công!, mật khẩu đã được gửi tới email của nhân viên.");
            }
            BLLQuanLiChung.Instance.alreadyOpenFormQuanLiLichLamViec = false;
            BLLQuanLiChung.Instance.formQuanLiLichLamViec = null;
            this.Close();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            FormThemLichLamViecVaoNhanVien formThemLichLamViecVaoNhanVien = new FormThemLichLamViecVaoNhanVien(textBoxMaNhanVien.Text);
            formThemLichLamViecVaoNhanVien.sendLichLamViecs = new FormThemLichLamViecVaoNhanVien.SendLichLamViecs(ReceiveLichLamViecs);
            formThemLichLamViecVaoNhanVien.ShowDialog();
        }

        private void buttonTaoHoacResetMatKhau_Click(object sender, EventArgs e)
        {
            string newPassword = "";
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                newPassword += chars[rnd.Next(chars.Length)];
            }

            if (typeUpdate == true)
            {
                BLLQuanLiChung.Instance.ResetAndSendNewPasswordToEmail(textBoxEmail.Text, newPassword);
                currentMatKhau = BLLTaiKhoan.Instance.GetMatKhauNhanVien(textBoxMaNhanVien.Text);
                textBoxMatKhau.Text = BLLTaiKhoan.Instance.GetMatKhauNhanVien(textBoxMaNhanVien.Text);
                MessageBox.Show("Mật khẩu đã được gửi tới email của nhân viên.");
            }
            else
            {
                currentMatKhau = newPassword;
                textBoxMatKhau.Text = newPassword;
            }
        }
        private void ReceiveLichLamViecs(List<ViewLichLamViec> listLichLamViecTamThoi)
        {
            dataGridView1.DataSource = listLichLamViecTamThoi;
            this.listLichLamViecTamThoi = listLichLamViecTamThoi;
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

        private void textBoxTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (BLLTaiKhoan.Instance.GetMatKhauNhanVien(textBoxTenDangNhap.Text) != null)
                {
                    textBoxCanhBao.Text = "Tên đăng nhập đã tồn tại";
                    buttonXacNhan.Enabled = false;
                }
            }
            catch
            {
                textBoxCanhBao.Text = "";
                buttonXacNhan.Enabled = true;
            }
        }
    }
}
