using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormQuanTriVien : Form
    {
        private FormManHinhChinh formManHinhChinh = new FormManHinhChinh();

        string maQuanTriVien;
        public FormQuanTriVien(string maQuanTriVien)
        {
            InitializeComponent();
            InitializeFormManHinhChinh();

            linkLabelTenQuanTriVien.Text = BLLQuanLiNhanVien.Instance.GetTenNhanVien(maQuanTriVien);
            this.maQuanTriVien = maQuanTriVien;
        }

        #region Các hàm chức năng cơ bản, hạn chế sửa

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
        private void buttonQuanLiSanPham_Click(object sender, EventArgs e)
        {
            BLLQuanLiChung.Instance.OpenChildForm(new FormQuanLiSanPham(), sender, panelDesktopPane);
        }

        private void buttonQuanLiNhanVien_Click(object sender, EventArgs e)
        {
            BLLQuanLiChung.Instance.OpenChildForm(new FormQuanLiNhanVien(), sender, panelDesktopPane);
        }
        private void buttonQuanLiLichLamViec_Click(object sender, EventArgs e)
        {
            BLLQuanLiChung.Instance.OpenChildForm(new FormQuanLiLichLamViec(), sender, panelDesktopPane);

        }

        private void buttonThongKe_Click(object sender, EventArgs e)
        {
            BLLQuanLiChung.Instance.OpenChildForm(new FormThongKe(), sender, panelDesktopPane);
        }

        private void linkLabelTenQuanTriVien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Point position = new Point(200, 0);
            contextMenuStrip1.Show(linkLabelTenQuanTriVien, position);
        }

        private void ToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.WhiteSmoke;
        }

        private void ToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ((ToolStripMenuItem)sender).ForeColor = Color.Gainsboro;
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
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            BLLQuanLiChung.Instance.ResetProperties();
        }
        #endregion

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDoiMatKhau formDoiMatKhau = new FormDoiMatKhau(maQuanTriVien);
            formDoiMatKhau.ShowDialog();
        }
    }
}
