using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormThongTinCaNhan : Form
    {
        bool typeQuanTriVien = false;

        string currentMatKhau;

        public FormThongTinCaNhan()
        {
            InitializeComponent();
            typeQuanTriVien = true;
            textBoxTenDangNhap.Enabled = true;
            label1.Text = "Đổi mật khẩu:";
            textBoxTenDangNhap.Text = "qtv";
            currentMatKhau = BLLQuanLiChung.Instance.GetMatKhauQuanTriVien();
            textBoxMatKhau.Text = BLLQuanLiChung.Instance.GetMatKhauQuanTriVien();

            groupBox2.Location = new System.Drawing.Point(175, 105);
            this.Size = new System.Drawing.Size(617, 387);
            buttonXacNhan.Location = new System.Drawing.Point(197, 344);
            buttonHuyBo.Location = new System.Drawing.Point(324, 344);

            label9.Visible = false;
            label2.Visible = false;
            label5.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            textBoxDiaChi.Visible = false;
            textBoxHoVaTen.Visible = false;
            textBoxSoDienThoai.Visible = false;
            dateTimePickerNgaySinh.Visible = false;
            textBoxMaNhanVien.Visible = false;
            label10.Visible = false;
            groupBox1.Visible = false;
            dataGridView1.Visible = false;
        }

        public FormThongTinCaNhan(string maNhanVien)
        {
            InitializeComponent();
            typeQuanTriVien = false;
            var nhanVien = BLLQuanLiNhanVien.Instance.GetNhanVien(maNhanVien);
            textBoxMaNhanVien.Text = nhanVien.MaNhanVien;
            textBoxHoVaTen.Text = nhanVien.HoVaTen;
            textBoxDiaChi.Text = nhanVien.DiaChi;
            textBoxSoDienThoai.Text = nhanVien.SoDienThoai;
            textBoxTenDangNhap.Text = BLLQuanLiNhanVien.Instance.GetTenDangNhapNhanVien(maNhanVien);
            radioButtonNam.Checked = nhanVien.GioiTinh;
            dateTimePickerNgaySinh.Value = nhanVien.NgaySinh;
            dataGridView1.DataSource = BLLQuanLiNhanVien.Instance.GetLichLamViecNhanVien(maNhanVien);
            currentMatKhau = BLLQuanLiNhanVien.Instance.GetMatKhauNhanVien(maNhanVien);
            textBoxMatKhau.Text = BLLQuanLiNhanVien.Instance.GetMatKhauNhanVien(maNhanVien);
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
            count = 1;
            buttonAnHienMatKhau.PerformClick();
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
            if (textBoxDiaChi.Text == "" || textBoxSoDienThoai.Text == "")
            {
                MessageBox.Show("Không được để trống các trường!");
            }
            else
            {
                if (textBoxMatKhau.Text != currentMatKhau && textBoxMatKhau.Text != textBoxNhapLaiMatKhauMoi.Text)
                {
                    MessageBox.Show("Mật khẩu ở cả 2 trường cần phải giống nhau!");
                }
                else
                {
                    if (typeQuanTriVien == true)
                    {
                        BLLQuanLiChung.Instance.UpdateMatKhauQuanTriVien(textBoxMatKhau.Text);
                        this.Close();
                    }
                    else
                    {
                        BLLQuanLiNhanVien.Instance.UpdateNhanVien(textBoxMaNhanVien.Text, textBoxMatKhau.Text, textBoxSoDienThoai.Text, textBoxDiaChi.Text);
                        this.Close();
                    }
                }
            }
        }
    }
}
