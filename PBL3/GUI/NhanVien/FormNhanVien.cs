using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormNhanVien : Form
    {
        FormManHinhChinh formManHinhChinh = new FormManHinhChinh();

        string maNhanVien;

        public FormNhanVien(string maNhanVien)
        {
            InitializeComponent();
            InitializeFormManHinhChinh();

            if (maNhanVien == "QTV")
                contextMenuStrip1.Items.Remove(contextMenuStrip1.Items[0]);
            linkLabelTenNhanVien.Text = BLLNhanVien.Instance.GetNhanVien(maNhanVien).HoVaTen;

            this.maNhanVien = maNhanVien;
        }

        private void InitializeFormManHinhChinh()
        {
            formManHinhChinh.TopLevel = false;
            formManHinhChinh.FormBorderStyle = FormBorderStyle.None;
            formManHinhChinh.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(formManHinhChinh);
            panelDesktopPane.Tag = formManHinhChinh;
            formManHinhChinh.BringToFront();
            formManHinhChinh.Show();
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

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        #endregion

        private void buttonSanPham_Click(object sender, EventArgs e)
        {
            BLLQuanLiChung.Instance.OpenChildForm(new FormSanPham(maNhanVien), sender, panelDesktopPane);
        }

        private void buttonBaoHanh_Click(object sender, EventArgs e)
        {
            BLLQuanLiChung.Instance.OpenChildForm(new FormBaoHanh(), sender, panelDesktopPane);
        }

        private void buttonLichSuHoaDon_Click(object sender, EventArgs e)
        {
            BLLQuanLiChung.Instance.OpenChildForm(new FormLichSuHoaDon(), sender, panelDesktopPane);
        }

        private void buttonQuanLiKhachHang_Click(object sender, EventArgs e)
        {
            BLLQuanLiChung.Instance.OpenChildForm(new FormQuanLiKhachHang(), sender, panelDesktopPane);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            BLLQuanLiChung.Instance.ResetProperties();
        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongTinNhanVien formThongTinCaNhan = new FormThongTinNhanVien(maNhanVien);
            formThongTinCaNhan.ShowDialog();
        }

        private void toolStripMenuItemĐổiMậtKhẩu_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau formDoiMatKhau = new FormDoiMatKhau(maNhanVien);
            formDoiMatKhau.ShowDialog();
        }

        private void linkLabelTenNhanVien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Point position = new Point(200, 0);
            contextMenuStrip1.Show(linkLabelTenNhanVien, position);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BLLQuanLiChung.Instance.DisableButton();
            formManHinhChinh.BringToFront();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Size = new Size(pictureBox1.Size.Width - 3, pictureBox1.Size.Height - 3);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox1.Size = new Size(pictureBox1.Size.Width + 3, pictureBox1.Size.Height + 3);
        }

        private void ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.WhiteSmoke;
        }

        private void ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.Gainsboro;
        }
    }
}
