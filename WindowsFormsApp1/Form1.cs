using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iconButtonQuanLiSanPham_Click(object sender, EventArgs e)
        {
            QuanLiChung.Instance.OpenChildForm(new FormQuanLiSanPham(), sender, panelDesktopPane);
        }

        private void iconButtonQuanLiNhanVien_Click(object sender, EventArgs e)
        {
            QuanLiChung.Instance.OpenChildForm(new FormQuanLiNhanVien(), sender, panelDesktopPane);

        }
    }
}
