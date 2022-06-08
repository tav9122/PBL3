using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormChiTietHoacThemLichLamViec : Form
    {
        public bool typeUpdate = false;
        public List<ViewNhanVien> listNhanVienTamThoi = new List<ViewNhanVien>();

        public FormChiTietHoacThemLichLamViec()
        {
            InitializeComponent();
            InitializeNewLichLamViecInformation();

            dataGridView1.Columns["HoVaTen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["LichLamViecs"].Visible = false;
            dataGridView1.Columns["NgaySinh"].Visible = false;
            dataGridView1.Columns["TenDangNhap"].Visible = false;
            dataGridView1.Columns["MucLuong"].Visible = false;
        }

        public FormChiTietHoacThemLichLamViec(string maLichLamViec)
        {
            InitializeComponent();
            InitializeLichLamViecInformation(maLichLamViec);

            dataGridView1.Columns["HoVaTen"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["LichLamViecs"].Visible = false;
            dataGridView1.Columns["NgaySinh"].Visible = false;
            dataGridView1.Columns["TenDangNhap"].Visible = false;
            dataGridView1.Columns["MucLuong"].Visible = false;
        }

        private void InitializeNewLichLamViecInformation()
        {
            typeUpdate = false;
            labelTieuDe.Text = "Thêm lịch làm việc:";
            textBoxMaLichLamViec.Text = BLLQuanLiChung.Instance.GetNextPrimaryKey(BLLQuanLiLichLamViec.Instance.GetMaLichLamViecs());
            dataGridView1.DataSource = BLLQuanLiLichLamViec.Instance.GetNhanViensOfLichLamViec("");
        }

        private void InitializeLichLamViecInformation(string maLichLamViec)
        {
            typeUpdate = true;
            labelTieuDe.Text = "Chi tiết lịch làm việc:";

            listNhanVienTamThoi = BLLQuanLiLichLamViec.Instance.GetNhanViensOfLichLamViec(maLichLamViec);

            var lichLamViec = BLLQuanLiLichLamViec.Instance.GetLichLamViec(maLichLamViec);
            textBoxMaLichLamViec.Text = lichLamViec.MaLichLamViec;
            textBoxThoiGianBatDau.Text = lichLamViec.ThoiGianBatDau;
            textBoxThoiGianKetThuc.Text = lichLamViec.ThoiGianKetThuc;
            textBoxNgayLamViecTrongTuan.Text = lichLamViec.NgayLamViec;
            dataGridView1.DataSource = BLLQuanLiLichLamViec.Instance.GetNhanViensOfLichLamViec(lichLamViec.MaLichLamViec);
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


        private void ReceiveNhanViens(List<ViewNhanVien> listNhanVienTamThoi)
        {
            dataGridView1.DataSource = listNhanVienTamThoi;
            this.listNhanVienTamThoi = listNhanVienTamThoi;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            FormThemNhanVienVaoLichLamViec formThemNhanVienVaoLichLamViec = new FormThemNhanVienVaoLichLamViec(textBoxMaLichLamViec.Text);
            formThemNhanVienVaoLichLamViec.sendNhanViens = new FormThemNhanVienVaoLichLamViec.SendNhanViens(ReceiveNhanViens);
            formThemNhanVienVaoLichLamViec.ShowDialog();
        }

        private void buttonXacNhan_Click(object sender, EventArgs e)
        {
            if (textBoxNgayLamViecTrongTuan.Text == "" || textBoxThoiGianBatDau.Text == "" || textBoxThoiGianKetThuc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
                return;
            }
            if (typeUpdate == true)
            {
                BLLQuanLiLichLamViec.Instance.UpdateLichLamViec(textBoxMaLichLamViec.Text, textBoxThoiGianBatDau.Text, textBoxThoiGianKetThuc.Text, textBoxNgayLamViecTrongTuan.Text, listNhanVienTamThoi.Select(nv => nv.MaNhanVien).ToList());
                MessageBox.Show("Cập nhật thành công!");
            }
            else
            {
                BLLQuanLiLichLamViec.Instance.AddLichLamViec(textBoxMaLichLamViec.Text, textBoxThoiGianBatDau.Text, textBoxThoiGianKetThuc.Text, textBoxNgayLamViecTrongTuan.Text, listNhanVienTamThoi.Select(nv => nv.MaNhanVien).ToList());
                MessageBox.Show("Thêm thành công!");
            }
            BLLQuanLiChung.Instance.alreadyOpenFormQuanLiNhanVien = false;
            BLLQuanLiChung.Instance.formQuanLiNhanVien = null;
            this.Close();
        }

        private void buttonHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
