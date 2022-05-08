using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien(string userName)
        {
            InitializeComponent();
            SetInitialData(userName);
        }

        public void SetInitialData(string userName)
        {
            linkLabelTenNhanVien.Text = userName;
        }

        private void iconButtonSanPham_Click(object sender, EventArgs e)
        {
            QuanLiChung.Instance.OpenChildForm(new FormSanPham(), sender, panelDesktopPane);
        }

        private void iconButtonBaoHanh_Click(object sender, EventArgs e)
        {
            QuanLiChung.Instance.OpenChildForm(new FormBaoHanh(), sender, panelDesktopPane);
        }

        private void iconButtonLichSuHoaDon_Click(object sender, EventArgs e)
        {
            QuanLiChung.Instance.OpenChildForm(new FormLichSuHoaDon(), sender, panelDesktopPane);
        }

        private void linkLabelDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
