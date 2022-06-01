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
            InitializeNewNhanVienInformation();

            dataGridView1.Columns["NhanViens"].Visible = false;
        }

        public FormChiTietHoacThemNhanVien(string maNhanVien)
        {
            InitializeComponent();
            InitializeNhanVienInformation(maNhanVien);

            dataGridView1.Columns["NhanViens"].Visible = false;
        }

        private void InitializeNewNhanVienInformation()
        {
            typeUpdate = false;
            labelTieuDe.Text = "Thêm nhân viên:";
            textBoxMaNhanVien.Text = BLLQuanLiChung.Instance.GetNextPrimaryKey(BLLQuanLiNhanVien.Instance.GetMaNhanViens());
            dataGridView1.DataSource = BLLQuanLiNhanVien.Instance.GetLichLamViecsOfNhanVien("");
        }

        private void InitializeNhanVienInformation(string maNhanVien)
        {
            typeUpdate = true;
            labelTieuDe.Text = "Chi tiết nhân viên:";

            listLichLamViecTamThoi = BLLQuanLiNhanVien.Instance.GetLichLamViecsOfNhanVien(maNhanVien);

            var nhanVien = BLLQuanLiNhanVien.Instance.GetNhanVien(maNhanVien);
            currentMatKhau = BLLQuanLiNhanVien.Instance.GetMatKhauNhanVien(nhanVien.MaNhanVien);
            textBoxMaNhanVien.Text = nhanVien.MaNhanVien;
            textBoxTenNhanVien.Text = nhanVien.HoVaTen;
            textBoxDiaChi.Text = nhanVien.DiaChi;
            textBoxSoDienThoai.Text = nhanVien.SoDienThoai;
            textBoxMucLuong.Text = nhanVien.MucLuong.ToString();
            radioButtonNam.Checked = nhanVien.GioiTinh;
            dateTimePickerNgaySinh.Value = nhanVien.NgaySinh;
            textBoxTenDangNhap.Text = BLLQuanLiNhanVien.Instance.GetTenDangNhapNhanVien(nhanVien.MaNhanVien);
            textBoxMatKhau.Text = BLLQuanLiNhanVien.Instance.GetMatKhauNhanVien(nhanVien.MaNhanVien);
            dataGridView1.DataSource = BLLQuanLiNhanVien.Instance.GetLichLamViecsOfNhanVien(nhanVien.MaNhanVien);

            textBoxTenDangNhap.Enabled = false;
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

        private void ReceiveLichLamViecs(List<ViewLichLamViec> listLichLamViecTamThoi)
        {
            dataGridView1.DataSource = listLichLamViecTamThoi;
            this.listLichLamViecTamThoi = listLichLamViecTamThoi;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            FormThemLichLamViecVaoNhanVien formThemLichLamViecVaoNhanVien = new FormThemLichLamViecVaoNhanVien(textBoxMaNhanVien.Text);
            formThemLichLamViecVaoNhanVien.sendLichLamViecs = new FormThemLichLamViecVaoNhanVien.SendLichLamViecs(ReceiveLichLamViecs);
            formThemLichLamViecVaoNhanVien.ShowDialog();
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            if (textBoxTenNhanVien.Text == "" || textBoxSoDienThoai.Text == "" || textBoxDiaChi.Text == "" || textBoxMucLuong.Text == "" || textBoxTenDangNhap.Text == "" || textBoxMatKhau.Text == "")
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
                BLLQuanLiNhanVien.Instance.UpdateNhanVien(textBoxMaNhanVien.Text, textBoxSoDienThoai.Text, textBoxDiaChi.Text, textBoxTenNhanVien.Text, dateTimePickerNgaySinh.Value, radioButtonNam.Checked, Convert.ToDouble(textBoxMucLuong.Text), listLichLamViecTamThoi.Select(llv => llv.MaLichLamViec).ToList());
                BLLQuanLiNhanVien.Instance.UpdateMatKhauNhanVien(textBoxTenDangNhap.Text, textBoxMatKhau.Text);
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                BLLQuanLiNhanVien.Instance.AddNhanVien(textBoxMaNhanVien.Text, textBoxSoDienThoai.Text, textBoxDiaChi.Text, textBoxTenNhanVien.Text, dateTimePickerNgaySinh.Value, radioButtonNam.Checked, Convert.ToDouble(textBoxMucLuong.Text), listLichLamViecTamThoi.Select(llv => llv.MaLichLamViec).ToList(), textBoxTenDangNhap.Text, textBoxMatKhau.Text);
                MessageBox.Show("Thêm thành công!");
            }
            BLLQuanLiChung.Instance.alreadyOpenFormQuanLiLichLamViec = false;
            BLLQuanLiChung.Instance.formQuanLiLichLamViec = null;
            this.Close();
        }

        private void buttonHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxTenDangNhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (BLLQuanLiNhanVien.Instance.GetMatKhauNhanVien(textBoxTenDangNhap.Text) != null)
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
