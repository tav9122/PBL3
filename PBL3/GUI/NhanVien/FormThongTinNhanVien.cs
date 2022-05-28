﻿using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormThongTinNhanVien : Form
    {
        public FormThongTinNhanVien(string maNhanVien)
        {
            InitializeComponent();
            InitializeNhanVienInformations(maNhanVien);
        }

        #region Các hàm chức năng cơ bản, hạn chế sửa

        private void InitializeNhanVienInformations(string maNhanVien)
        {
            var nhanVien = BLLQuanLiNhanVien.Instance.GetNhanVien(maNhanVien);
            textBoxMaNhanVien.Text = nhanVien.MaNhanVien;
            textBoxHoVaTen.Text = nhanVien.HoVaTen;
            textBoxDiaChi.Text = nhanVien.DiaChi;
            textBoxSoDienThoai.Text = nhanVien.SoDienThoai;
            radioButtonNam.Checked = nhanVien.GioiTinh;
            dateTimePickerNgaySinh.Value = nhanVien.NgaySinh;
            dataGridView1.DataSource = BLLQuanLiNhanVien.Instance.GetLichLamViecNhanVien(maNhanVien);
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

        private void buttonHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
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
                BLLQuanLiNhanVien.Instance.UpdateNhanVien(textBoxMaNhanVien.Text, textBoxSoDienThoai.Text, textBoxDiaChi.Text);
                this.Close();
            }
        }
    }
}
