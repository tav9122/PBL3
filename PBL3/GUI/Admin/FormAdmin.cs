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
    public partial class FormAdmin : Form
    {
        public FormAdmin(string userName)
        {
            InitializeComponent();
            SetInitialData(userName);
        }

        public void SetInitialData(string userName)
        {
            linkLabelTenAdmin.Text = userName; 
        }

        private void iconbuttonQuanLiSanPham_Click(object sender, EventArgs e)
        {
            QuanLiChung.Instance.OpenChildForm(new FormQuanLiSanPham(), sender, panelDesktopPane);
        }

        private void iconbuttonQuanLiNhanVien_Click(object sender, EventArgs e)
        {
            QuanLiChung.Instance.OpenChildForm(new FormQuanLiNhanVien(), sender, panelDesktopPane);
        }

        private void iconbuttonThongKe_Click(object sender, EventArgs e)
        {
            QuanLiChung.Instance.OpenChildForm(new FormThongKe(), sender, panelDesktopPane);
        }
        
        private void linkLabelDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
