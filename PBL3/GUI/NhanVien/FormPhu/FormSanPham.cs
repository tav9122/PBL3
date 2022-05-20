using System;
using System.Drawing;
using System.Windows.Forms;

namespace PBL3
{
    public partial class FormSanPham : Form
    {
        public FormSanPham()
        {
            InitializeComponent();
        }
        private void textBoxTimKiem_Enter(object sender, EventArgs e)
        {
            if (textBoxTimKiem.Text == "Nhập để tìm kiếm...")
            {
                textBoxTimKiem.Text = "";
                textBoxTimKiem.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            }
        }

        private void textBoxTimKiem_Leave(object sender, EventArgs e)
        {
            if (textBoxTimKiem.Text == "")
            {
                textBoxTimKiem.ForeColor = Color.FromArgb(200, 200, 200);
                textBoxTimKiem.Text = "Nhập để tìm kiếm...";
            }
        }

        private void textBoxTuiHang_Enter(object sender, EventArgs e)
        {
            if (textBoxTuiHang.Text == "Các sản phẩm trong túi hàng hiện tại:...")
            {
                textBoxTuiHang.Text = "";
                textBoxTuiHang.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            }
        }

        private void textBoxTuiHang_Leave(object sender, EventArgs e)
        {
            if (textBoxTuiHang.Text == "")
            {
                textBoxTuiHang.ForeColor = Color.FromArgb(200, 200, 200);
                textBoxTuiHang.Text = "Các sản phẩm trong túi hàng hiện tại:...";
            }
        }

        private void textBoxTuiHang_TextChanged(object sender, EventArgs e)
        {
            if (textBoxTuiHang.Text.Contains("Các sản phẩm trong túi hàng hiện tại:..."))
            {
                textBoxTuiHang.Text.Replace("Các sản phẩm trong túi hàng hiện tại:...", "");
                textBoxTuiHang.ForeColor = Color.FromKnownColor(KnownColor.ControlText);
            }
        }
    }
}
