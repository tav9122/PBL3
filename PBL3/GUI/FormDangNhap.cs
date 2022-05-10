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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            if (textBoxTenDangNhap.Text == "qtv" && textBoxMatKhau.Text == "qtv")
            {
                FormQuanTriVien formAdmin = new FormQuanTriVien(textBoxTenDangNhap.Text);
                this.Hide();
                formAdmin.ShowDialog();
                this.Show();
            }
            else if (textBoxTenDangNhap.Text == "nv" && textBoxMatKhau.Text == "nv")
            {
                FormNhanVien formNhanVien = new FormNhanVien(textBoxTenDangNhap.Text);
                this.Hide();
                formNhanVien.ShowDialog();
                this.Show();
            }
            textBoxMatKhau.Text = "";
            textBoxTenDangNhap.Text = "";
        }

        private void linkLabelQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Quên thì chịu chứ sao h :<");
        }
    }
}
