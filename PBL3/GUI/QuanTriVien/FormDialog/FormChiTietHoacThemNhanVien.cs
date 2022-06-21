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
        public string newMatKhau = "";


        public FormChiTietHoacThemNhanVien()
        {
            InitializeComponent();
            typeUpdate = false;

            labelTieuDe.Text = "Thêm nhân viên:";

            textBoxMaNhanVien.Text = BLLQuanLiChung.Instance.GetNextPrimaryKey(BLLNhanVien.Instance.GetMaNhanViens());
            textBoxTenDangNhap.Text = BLLQuanLiChung.Instance.GetNextPrimaryKey(BLLTaiKhoan.Instance.GetMaTaiKhoans());
            dateTimePickerNgayBatDauLamViec.Value = DateTime.Now;

            dataGridView1.DataSource = BLLNhanVienLichLamViec.Instance.GetLichLamViecsOfNhanVien("");

            buttonTaoMatKhauMoiChoNhanVien.Visible = false;
            dataGridView1.Columns["NhanViens"].Visible = false;
        }

        public FormChiTietHoacThemNhanVien(string maNhanVien)
        {
            InitializeComponent();
            typeUpdate = true;

            labelTieuDe.Text = "Chi tiết nhân viên:";

            listLichLamViecTamThoi = BLLNhanVienLichLamViec.Instance.GetLichLamViecsOfNhanVien(maNhanVien);

            var nhanVien = BLLNhanVien.Instance.GetNhanVien(maNhanVien);
            newMatKhau = BLLTaiKhoan.Instance.GetTaiKhoan(nhanVien.MaNhanVien).MatKhau;
            textBoxMaNhanVien.Text = nhanVien.MaNhanVien;
            textBoxTenNhanVien.Text = nhanVien.HoVaTen;
            textBoxDiaChi.Text = nhanVien.DiaChi;
            textBoxSoDienThoai.Text = nhanVien.SoDienThoai;
            textBoxEmail.Text = nhanVien.Email;
            textBoxMucLuong.Text = nhanVien.MucLuong.ToString();
            radioButtonNam.Checked = nhanVien.GioiTinh;
            dateTimePickerNgaySinh.Value = nhanVien.NgaySinh;
            dateTimePickerNgayBatDauLamViec.Value = nhanVien.NgayBatDauLamViec;
            textBoxTenDangNhap.Text = BLLTaiKhoan.Instance.GetTaiKhoan(nhanVien.MaNhanVien).TenDangNhap;

            textBoxTenDangNhap.Enabled = true;
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
            if (textBoxTenNhanVien.Text == "" || textBoxSoDienThoai.Text == "" || textBoxEmail.Text == "" || textBoxDiaChi.Text == "" || textBoxMucLuong.Text == "" || textBoxTenDangNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (!textBoxEmail.Text.Contains("@"))
            {
                MessageBox.Show("Email không hợp lệ!");
                return;
            }

            if (typeUpdate == true)
            {
                foreach (var i in BLLTaiKhoan.Instance.GetTaiKhoans().Where(tk => tk.NhanVien.MaNhanVien != textBoxMaNhanVien.Text))
                {
                    if (i.TenDangNhap == textBoxTenDangNhap.Text)
                    {
                        MessageBox.Show("Tên đăng nhập đã tồn tại!");
                        return;
                    }
                }
                BLLNhanVien.Instance.UpdateNhanVien(textBoxMaNhanVien.Text, textBoxSoDienThoai.Text, textBoxEmail.Text, textBoxDiaChi.Text, textBoxTenNhanVien.Text, dateTimePickerNgaySinh.Value, radioButtonNam.Checked, Convert.ToDouble(textBoxMucLuong.Text), listLichLamViecTamThoi.Select(llv => llv.MaLichLamViec).ToList());

                string thongBao = "Cập nhật thành công!";
                if (newMatKhau != BLLTaiKhoan.Instance.GetTaiKhoan(BLLNhanVien.Instance.GetNhanVien(textBoxMaNhanVien.Text).MaNhanVien).MatKhau || textBoxTenDangNhap.Text != BLLTaiKhoan.Instance.GetTaiKhoan(BLLNhanVien.Instance.GetNhanVien(textBoxMaNhanVien.Text).MaNhanVien).TenDangNhap)
                {
                    BLLTaiKhoan.Instance.UpdateAndSendTaiKhoanInformationToMail(textBoxEmail.Text, textBoxTenDangNhap.Text, newMatKhau);
                    thongBao += "\nThông tin tài khoản mới đã được gửi tới email của nhân viên.";
                }
                MessageBox.Show(thongBao);
            }
            else
            {
                buttonTaoMatKhauMoiChoNhanVien_Click(null, null);
                BLLNhanVien.Instance.AddNhanVien(textBoxMaNhanVien.Text, textBoxSoDienThoai.Text, textBoxEmail.Text, textBoxDiaChi.Text, textBoxTenNhanVien.Text, dateTimePickerNgaySinh.Value, radioButtonNam.Checked, Convert.ToDouble(textBoxMucLuong.Text), dateTimePickerNgayBatDauLamViec.Value, listLichLamViecTamThoi.Select(llv => llv.MaLichLamViec).ToList(), textBoxTenDangNhap.Text, newMatKhau);
                BLLTaiKhoan.Instance.UpdateAndSendTaiKhoanInformationToMail(textBoxEmail.Text, textBoxTenDangNhap.Text, newMatKhau);
                MessageBox.Show("Thêm thành công! \nThông tin tài khoản mới đã được gửi tới email của nhân viên.");
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

        private void buttonTaoMatKhauMoiChoNhanVien_Click(object sender, EventArgs e)
        {
            string matKhauMoi = "";
            string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                matKhauMoi += chars[rnd.Next(chars.Length)];
            }
            newMatKhau = matKhauMoi;
            if (typeUpdate == true)
                MessageBox.Show("Đã tạo mật khẩu mới cho nhân viên. Nhấn xác nhận để lưu!");
        }

        private void ReceiveLichLamViecs(List<ViewLichLamViec> listLichLamViecTamThoi)
        {
            dataGridView1.DataSource = listLichLamViecTamThoi;
            this.listLichLamViecTamThoi = listLichLamViecTamThoi;
        }
    }
}
